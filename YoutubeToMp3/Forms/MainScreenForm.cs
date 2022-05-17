using ATL;
using YoutubeToMp3.Helpers;
using YoutubeToMp3.Services;

namespace YoutubeToMp3.Forms
{
    public partial class MainScreenForm : Form
    {
        private readonly ConverterService _converterService;

        public MainScreenForm()
        {
            _converterService = new ConverterService();
            InitializeComponent();
            InitializeTimer();
        }

        #region Events

        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            txtSavePath.Visible = false;
            fbdSavePath.Reset();
            var dialogResult = fbdSavePath.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                fbdSavePath.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            txtSavePath.Visible = true;
            txtSavePath.Text = fbdSavePath.SelectedPath;
        }

        private async void btnConvert_ClickAsync(object sender, EventArgs e)
        {
            Progress<int> convertProgress = new();
            convertProgress.ProgressChanged += UpdateProgressBar;

            ResetAllControls();

            if (string.IsNullOrEmpty(txbVideoUrl.Text))
            {
                ShowError("YouTube or YouTube Music video Url is required!");
                txbVideoUrl.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fbdSavePath.SelectedPath))
            {
                fbdSavePath.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            var convertResult = await _converterService.ConvertYouTubeVideoToMp3Async(txbVideoUrl.Text, fbdSavePath.SelectedPath, convertProgress);

            if (!convertResult.ConvertSuccessful)
            {
                ShowError(convertResult.ErrorMessage);
                ResetProgressBar();
                return;
            }

            progressBar.Increment(50);

            ShowSuccessfullConvertDetails(convertResult.FilePath, convertResult.FileThumbnailUrl);
        }

        private void UpdateProgressBar(object? sender, int e)
        {
            progressBar.Value = e;
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            lblNoInternetConnection.Visible = false;
            bool isThereInternetConnection = await NetworkHelpers.CheckInternetConnectionAsync();
            pbxInternetConnection.Image = isThereInternetConnection ? Properties.Resources.InternetConnection : Properties.Resources.NoInternetConnection;

            if (isThereInternetConnection)
            {
                DisableControls(false);
                pbxInternetConnection.Image = Properties.Resources.InternetConnection;
            }
            else
            {
                DisableControls(true);
                lblNoInternetConnection.Visible = true;
                pbxInternetConnection.Image = Properties.Resources.NoInternetConnection;
            }
        }

        private void pbxFoundABug_Click(object sender, EventArgs e)
        {
            OpenGitHubRepoIssuePage();
        }

        private void lblFoundABug_Click(object sender, EventArgs e)
        {
            OpenGitHubRepoIssuePage();
        }

        #endregion

        #region Helpers Methods

        private static void OpenGitHubRepoIssuePage()
        {
            var destinationurl = "https://github.com/Hazaaa/Youtube-To-Mp3/issues";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }

        private void InitializeTimer()
        {
            timer.Tick += new EventHandler(timer_Tick!);
            timer.Start();
        }

        private void DisableControls(bool disabled)
        {
            txbVideoUrl.Enabled = !disabled;
            btnSelectSavePath.Enabled = !disabled;
            btnConvert.Enabled = !disabled;
        }

        private void ShowSuccessfullConvertDetails(string filePath, string? fileThumbnail)
        {
            lblConvertStatus.Text = "YouTube video successfully converted!";
            lblConvertStatus.ForeColor = Color.Green;
            lblConvertStatus.Visible = true;
            pbxStatusIcon.Visible = true;
            pbxStatusIcon.Image = Properties.Resources.Completed;
            MoveErrorDivider();
            PopulateAudioDetailsControls(filePath, fileThumbnail);
            ToggleAudioDetailsControls(true);
        }

        private void ShowError(string errorMessage)
        {
            lblConvertStatus.Text = errorMessage;
            lblConvertStatus.ForeColor = Color.Firebrick;
            lblConvertStatus.Visible = true;
            pbxStatusIcon.Visible = true;
            pbxStatusIcon.Image = Properties.Resources.Error;
            MoveErrorDivider();
        }

        private void ToggleAudioDetailsControls(bool showDetails)
        {
            lblAudioDetails.Visible = showDetails;
            lblAudioTitle.Visible = showDetails;
            lblAudioTitleText.Visible = showDetails;
            lblAudioDuration.Visible = showDetails;
            lblAudioDurationText.Visible = showDetails;
            lblAudioBitRate.Visible = showDetails;
            lblAudioBitRateText.Visible = showDetails;
            lblAudioSize.Visible = showDetails;
            lblAudioSizeText.Visible = showDetails;
            pbxThumbnail.Visible = showDetails;
            pbxStatusIcon.Visible = showDetails;
        }

        private void PopulateAudioDetailsControls(string filePath, string? fileThumbnail)
        {
            Track audioFile = new Track(filePath);
            FileInfo fileInfo = new FileInfo(filePath);
            lblAudioTitleText.Text = audioFile.Title;
            lblAudioDurationText.Text = TimeHelpers.ConvertSecondToMinutes(audioFile.Duration);
            lblAudioBitRateText.Text = $"{audioFile.Bitrate}kbps";
            lblAudioSizeText.Text = $"{SizeHelpers.ConvertBytesToMegabytes(fileInfo.Length):N2}MB";

            if (!string.IsNullOrWhiteSpace(fileThumbnail))
            {
                pbxThumbnail.Load(fileThumbnail);
            }
        }

        private void ResetAllControls()
        {
            lblConvertStatus.Visible = false;
            ResetProgressBar();
            MoveErrorDivider(true);
            ToggleAudioDetailsControls(false);
        }

        private void ResetProgressBar()
        {
            progressBar.Value = 0;
            progressBar.Update();
        }

        private void MoveErrorDivider(bool defaultPosition = false)
        {
            var DEFAULT_ERROR_DIVIDER_POSITION = new Point(0, 166);

            if (defaultPosition)
            {
                lblErrorDivider.Location = DEFAULT_ERROR_DIVIDER_POSITION;
            } else
            {
                lblErrorDivider.Location = new Point(0, 190);
            }
        }

        #endregion
    }
}

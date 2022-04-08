

namespace BatchTorrentEdit
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 选择的种子文件
        /// </summary>
        public List<FileInfo> SelectfileInfos = new List<FileInfo>();
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择种子所在的文件夹";
            dialog.SelectedPath = Base_Path;
            //dialog.RootFolder = Environment.SpecialFolder.Programs;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                SelectfileInfos.Clear();
                var alltorrent = new DirectoryInfo(foldPath).GetFiles("*.torrent");
                if (alltorrent.Length > 0)
                {
                    var TorrentNameStartsWith = TextBox_TorrentNameStartsWith.Text.Trim();
                    foreach (var item in alltorrent)
                    {
                        if (!string.IsNullOrEmpty(TorrentNameStartsWith))
                        {
                            if (item.Name.StartsWith(TorrentNameStartsWith))
                            {
                                SelectfileInfos.Add(item);
                            }
                        }
                        else
                        {
                            SelectfileInfos.Add(item);
                        }

                    }
                    if (SelectfileInfos.Count > 0)
                    {
                        Label_SelectTorrentsMsg.Text = $"ALL {SelectfileInfos.Count()} Counts";
                        MessageBox.Show($"Good Select {SelectfileInfos.Count()} Torrents");
                    }
                    else
                    {
                        MessageBox.Show("ERROR You Set TorrentNameStartsWith ,No matches");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR No Torrent Files");
                }
            }
        }

        /// <summary>
        /// 缓存的当前程序路径
        /// </summary>
        private static string CacheBase_Path = null;
        /// <summary>
        /// 当前的程序路径
        /// </summary>
        public static string Base_Path
        {
            get
            {
                if (string.IsNullOrEmpty(CacheBase_Path))
                {
                    CacheBase_Path = AppDomain.CurrentDomain.RelativeSearchPath ?? AppDomain.CurrentDomain.BaseDirectory;

                }

                return CacheBase_Path;
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //BitTorrentHelp.EditBitTorrent("D://[Audiences].Zack.Snyder's.Justice.League.2021.UHD.BluRay.2160p.10bit.HDR.2Audio.TrueHD(Atmos).7.1.x265-beAst.torrent",
            //    "D://test.torrent", "https://t.audiences.me", "https://ppt.duan.red"
            //    );


            //if (SelectfileInfos.Count>1)
            //{
            //    var firstitem = SelectfileInfos.First();

            //}
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string oldTarker = TextBox_BeforTarkerHostName.Text.Trim();
                string newTarker = TextBox_NewTarkerHostName.Text.Trim();
                foreach (var item in SelectfileInfos)
                {
                    var baseDirectory = System.IO.Path.GetDirectoryName(item.FullName);
                    var saveDirectory = System.IO.Path.Combine(baseDirectory, "ChangeTorrent");
                    System.IO.Directory.CreateDirectory(saveDirectory);
                    var savepath = System.IO.Path.Combine(saveDirectory, item.Name);
                    if (System.IO.File.Exists(savepath))
                    {
                        System.IO.File.Delete(savepath);
                    }
                    var bttask = BitTorrentHelp.EditBitTorrent(item.FullName,
                        savepath, oldTarker, newTarker
                        );
                    bttask.Wait();
                }

                //保存缓存  
                //不能运行 因为 https://github.com/aloneguid/config/pull/129
                //MainConfig.Main_Settings.BeforTarkerHostName = oldTarker;
                //MainConfig.Main_Settings.NewTarkerHostName = newTarker;
                MessageBox.Show($"OK! Save Path is [ChangeTorrent]");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.ToString()}");
            }

        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //读取设置缓存
            TextBox_BeforTarkerHostName.Text= MainConfig.Main_Settings.BeforTarkerHostName;
            TextBox_NewTarkerHostName.Text = MainConfig.Main_Settings.NewTarkerHostName;
           
        }

    }
}
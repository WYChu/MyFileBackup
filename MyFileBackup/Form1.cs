using MyFileBackup.Handlers;
using MyFileBackup.Medels;
using MyFileBackup.Services;
using System;
using System.Windows.Forms;

namespace MyFileBackup
{
    public partial class MainForm : Form
    {
        private ConfigManager configManager = new ConfigManager();
        private MyBackupService myBackupService = new MyBackupService();
        private ScheduleManager scheduleManager = new ScheduleManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //myBackupService.DoBackup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitForm();
            //ShowConfig();
            //ShowSchedule();
        }

        /// <summary>
        /// 初始化表單
        /// </summary>
        private void InitForm()
        {
            //myBackupService.ProcessJsonConfigs();
        }

        /// <summary>
        /// 顯示Config資訊
        /// </summary>
        private void ShowConfig()
        {
            for (int i = 0; i < configManager.Count; i++)
            {
                Config config = configManager[i];
                string ext = config.Ext;
                string location = config.Location;
                bool subDirectory = config.SubDirectory;
                string unit = config.Unit;
                bool remove = config.Remove;
                string[] handler = config.Handlers;
                string destination = config.Destination;
                string dir = config.Dir;
                string connectionString = config.ConnectionString;
                var rows = this.configGridView.Rows;

                rows.Add(new object[] { ext, location, subDirectory, unit, remove, handler, destination, dir, connectionString });
            }
            string configNum = this.configNumber.Text;
            this.configNumber.Text = configNum.Replace("$num", configManager.Count.ToString());
        }

        /// <summary>
        /// 顯示Scehdule資訊
        /// </summary>
        private void ShowSchedule()
        {
            for (int i = 0; i < scheduleManager.Count; i++)
            {
                Schedule schedule = scheduleManager[i];
                string ext = schedule.Ext;
                string time = schedule.Time;
                string interval = schedule.Interval;
                var rows = this.scheduleGridView.Rows;

                rows.Add(new object[] { ext, time, interval });
            }
            string scheduleNum = this.scheduleNumber.Text;
            this.scheduleNumber.Text = scheduleNum.Replace("$num", scheduleManager.Count.ToString());
        }
    }
}
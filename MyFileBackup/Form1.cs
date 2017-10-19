using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFileBackup.Models;

namespace MyFileBackup
{
    public partial class Form1 : Form
    {
        private ConfigManager configManager = new ConfigManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitForm();
        }

        /// <summary>
        /// 初始化表單
        /// </summary>
        private void InitForm()
        {
            configManager.ProcessConfigs();
            //int configCount = configManager.Count;
        }
    }
}
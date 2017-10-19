namespace MyFileBackup
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.configGridView = new System.Windows.Forms.DataGridView();
            this.ext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.scheduleExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configNumber = new System.Windows.Forms.Label();
            this.scheduleNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.configGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // configGridView
            // 
            this.configGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ext,
            this.location,
            this.subDirectory,
            this.unit,
            this.remove,
            this.handler,
            this.destination,
            this.dir,
            this.connectionString});
            this.configGridView.Location = new System.Drawing.Point(8, 40);
            this.configGridView.Name = "configGridView";
            this.configGridView.RowTemplate.Height = 24;
            this.configGridView.Size = new System.Drawing.Size(500, 150);
            this.configGridView.TabIndex = 1;
            // 
            // ext
            // 
            this.ext.HeaderText = "設定檔案格式";
            this.ext.Name = "ext";
            this.ext.ReadOnly = true;
            this.ext.Width = 72;
            // 
            // location
            // 
            this.location.HeaderText = "設定要備份檔案的目錄";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // subDirectory
            // 
            this.subDirectory.HeaderText = "是否處理子目錄";
            this.subDirectory.Name = "subDirectory";
            // 
            // unit
            // 
            this.unit.HeaderText = "設定備份單位";
            this.unit.Name = "unit";
            // 
            // remove
            // 
            this.remove.HeaderText = "處理完是否刪除檔案";
            this.remove.Name = "remove";
            // 
            // handler
            // 
            this.handler.HeaderText = "處理方式";
            this.handler.Name = "handler";
            // 
            // destination
            // 
            this.destination.HeaderText = "處理後要儲存到什麼地方";
            this.destination.Name = "destination";
            // 
            // dir
            // 
            this.dir.HeaderText = "處理後的目錄";
            this.dir.Name = "dir";
            // 
            // connectionString
            // 
            this.connectionString.HeaderText = "設定資料庫連接字串";
            this.connectionString.Name = "connectionString";
            // 
            // scheduleGridView
            // 
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleExt,
            this.time,
            this.interval});
            this.scheduleGridView.Location = new System.Drawing.Point(8, 230);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.RowTemplate.Height = 24;
            this.scheduleGridView.Size = new System.Drawing.Size(500, 150);
            this.scheduleGridView.TabIndex = 2;
            // 
            // scheduleExt
            // 
            this.scheduleExt.HeaderText = "設定此排程所處理的檔案格式";
            this.scheduleExt.Name = "scheduleExt";
            this.scheduleExt.ReadOnly = true;
            this.scheduleExt.Width = 72;
            // 
            // time
            // 
            this.time.HeaderText = "設定此排程所處理的時間";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // interval
            // 
            this.interval.HeaderText = "設定此排程執行的間隔";
            this.interval.Name = "interval";
            // 
            // configNumber
            // 
            this.configNumber.AutoSize = true;
            this.configNumber.Location = new System.Drawing.Point(8, 15);
            this.configNumber.Name = "configNumber";
            this.configNumber.Size = new System.Drawing.Size(119, 12);
            this.configNumber.TabIndex = 3;
            this.configNumber.Text = "Config參數共 $num 筆";
            // 
            // scheduleNumber
            // 
            this.scheduleNumber.AutoSize = true;
            this.scheduleNumber.Location = new System.Drawing.Point(8, 205);
            this.scheduleNumber.Name = "scheduleNumber";
            this.scheduleNumber.Size = new System.Drawing.Size(128, 12);
            this.scheduleNumber.TabIndex = 4;
            this.scheduleNumber.Text = "Schedule參數共 $num 筆";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.scheduleNumber);
            this.Controls.Add(this.configNumber);
            this.Controls.Add(this.scheduleGridView);
            this.Controls.Add(this.configGridView);
            this.Name = "MainForm";
            this.Text = "檔案備份工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView configGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDirectory;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn handler;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionString;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn interval;
        private System.Windows.Forms.Label configNumber;
        private System.Windows.Forms.Label scheduleNumber;
    }
}


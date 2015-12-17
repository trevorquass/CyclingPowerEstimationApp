namespace CyclingPowerEstimation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabTCX = new MetroFramework.Controls.MetroTabPage();
            this.buttonUpload = new MetroFramework.Controls.MetroButton();
            this.filename = new MetroFramework.Controls.MetroTextBox();
            this.logText = new MetroFramework.Controls.MetroTextBox();
            this.buttonProcess = new MetroFramework.Controls.MetroButton();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.createCSV = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.temperature = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.riderWeight = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.bikeWeight = new MetroFramework.Controls.MetroTextBox();
            this.frontalArea = new MetroFramework.Controls.MetroTextBox();
            this.dragCoefficient = new MetroFramework.Controls.MetroTextBox();
            this.coefficientOfRollingResistance = new MetroFramework.Controls.MetroTextBox();
            this.tabMap = new MetroFramework.Controls.MetroTabPage();
            this.buttonRoute = new MetroFramework.Controls.MetroButton();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.tabStrava = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.fileParserThread = new System.ComponentModel.BackgroundWorker();
            this.powerCalculationThread = new System.ComponentModel.BackgroundWorker();
            this.metroTabControl1.SuspendLayout();
            this.tabTCX.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabStrava.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabTCX);
            this.metroTabControl1.Controls.Add(this.tabSettings);
            this.metroTabControl1.Controls.Add(this.tabMap);
            this.metroTabControl1.Controls.Add(this.tabStrava);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(545, 327);
            this.metroTabControl1.TabIndex = 0;
            // 
            // tabTCX
            // 
            this.tabTCX.Controls.Add(this.buttonUpload);
            this.tabTCX.Controls.Add(this.filename);
            this.tabTCX.Controls.Add(this.logText);
            this.tabTCX.Controls.Add(this.buttonProcess);
            this.tabTCX.HorizontalScrollbarBarColor = true;
            this.tabTCX.Location = new System.Drawing.Point(4, 35);
            this.tabTCX.Name = "tabTCX";
            this.tabTCX.Size = new System.Drawing.Size(537, 288);
            this.tabTCX.TabIndex = 0;
            this.tabTCX.Text = "TCX";
            this.tabTCX.VerticalScrollbarBarColor = true;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(429, 17);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(103, 20);
            this.buttonUpload.TabIndex = 5;
            this.buttonUpload.Text = "Upload TCX";
            this.buttonUpload.Click += new System.EventHandler(this.ButtonUploadClick);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(3, 17);
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            this.filename.Size = new System.Drawing.Size(420, 20);
            this.filename.TabIndex = 4;
            // 
            // logText
            // 
            this.logText.BackColor = System.Drawing.SystemColors.Control;
            this.logText.Location = new System.Drawing.Point(3, 43);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logText.Size = new System.Drawing.Size(531, 206);
            this.logText.TabIndex = 3;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Location = new System.Drawing.Point(434, 255);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(100, 30);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Estimate Power";
            this.buttonProcess.Click += new System.EventHandler(this.ButtonEstimatePowerClick);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox4);
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Controls.Add(this.groupBox2);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.Location = new System.Drawing.Point(4, 35);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(537, 288);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.createCSV);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(274, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 90);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // createCSV
            // 
            this.createCSV.AutoSize = true;
            this.createCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCSV.Location = new System.Drawing.Point(21, 29);
            this.createCSV.Name = "createCSV";
            this.createCSV.Size = new System.Drawing.Size(135, 15);
            this.createCSV.TabIndex = 0;
            this.createCSV.Text = "Create CSV For Route";
            this.createCSV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.temperature);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(274, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 90);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conditions";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(232, 41);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(23, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "°C";
            // 
            // temperature
            // 
            this.temperature.Location = new System.Drawing.Point(98, 40);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(126, 20);
            this.temperature.TabIndex = 3;
            this.temperature.Text = "15";
            this.temperature.TextChanged += new System.EventHandler(this.TemperatureTextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Temperature:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.riderWeight);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(274, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rider";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Rider Weight:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(230, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Kg";
            // 
            // riderWeight
            // 
            this.riderWeight.Location = new System.Drawing.Point(98, 34);
            this.riderWeight.Name = "riderWeight";
            this.riderWeight.Size = new System.Drawing.Size(126, 20);
            this.riderWeight.TabIndex = 0;
            this.riderWeight.Text = "75";
            this.riderWeight.TextChanged += new System.EventHandler(this.RiderWeightTextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLink1);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.bikeWeight);
            this.groupBox1.Controls.Add(this.frontalArea);
            this.groupBox1.Controls.Add(this.dragCoefficient);
            this.groupBox1.Controls.Add(this.coefficientOfRollingResistance);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bike";
            // 
            // metroLink1
            // 
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.Location = new System.Drawing.Point(6, 256);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(45, 20);
            this.metroLink1.TabIndex = 10;
            this.metroLink1.Text = "Help?";
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 217);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Bike Weight:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 158);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Frontal Area:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 99);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(107, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Drag Coefficient:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 34);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(197, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Coefficient of Rolling Resistance:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(221, 237);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(24, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Kg";
            // 
            // bikeWeight
            // 
            this.bikeWeight.Location = new System.Drawing.Point(89, 236);
            this.bikeWeight.Name = "bikeWeight";
            this.bikeWeight.Size = new System.Drawing.Size(126, 20);
            this.bikeWeight.TabIndex = 6;
            this.bikeWeight.Text = "6.8";
            this.bikeWeight.TextChanged += new System.EventHandler(this.BikeWeightTextChanged);
            // 
            // frontalArea
            // 
            this.frontalArea.Location = new System.Drawing.Point(89, 180);
            this.frontalArea.Name = "frontalArea";
            this.frontalArea.Size = new System.Drawing.Size(156, 20);
            this.frontalArea.TabIndex = 5;
            this.frontalArea.Text = "0.39";
            this.frontalArea.TextChanged += new System.EventHandler(this.FrontalAreaTextChanged);
            // 
            // dragCoefficient
            // 
            this.dragCoefficient.Location = new System.Drawing.Point(89, 121);
            this.dragCoefficient.Name = "dragCoefficient";
            this.dragCoefficient.Size = new System.Drawing.Size(156, 20);
            this.dragCoefficient.TabIndex = 4;
            this.dragCoefficient.Text = "0.88";
            this.dragCoefficient.TextChanged += new System.EventHandler(this.DragCoefficientTextChanged);
            // 
            // coefficientOfRollingResistance
            // 
            this.coefficientOfRollingResistance.Location = new System.Drawing.Point(89, 56);
            this.coefficientOfRollingResistance.Name = "coefficientOfRollingResistance";
            this.coefficientOfRollingResistance.Size = new System.Drawing.Size(156, 20);
            this.coefficientOfRollingResistance.TabIndex = 3;
            this.coefficientOfRollingResistance.Text = "0.003";
            this.coefficientOfRollingResistance.TextChanged += new System.EventHandler(this.CoefficientOfRollingResistanceTextChanged);
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.buttonRoute);
            this.tabMap.Controls.Add(this.map);
            this.tabMap.HorizontalScrollbarBarColor = true;
            this.tabMap.Location = new System.Drawing.Point(4, 35);
            this.tabMap.Name = "tabMap";
            this.tabMap.Size = new System.Drawing.Size(537, 288);
            this.tabMap.TabIndex = 3;
            this.tabMap.Text = "Map";
            this.tabMap.VerticalScrollbarBarColor = true;
            // 
            // buttonRoute
            // 
            this.buttonRoute.Enabled = false;
            this.buttonRoute.Location = new System.Drawing.Point(449, 268);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(85, 20);
            this.buttonRoute.TabIndex = 3;
            this.buttonRoute.Text = "Show Route";
            this.buttonRoute.Click += new System.EventHandler(this.buttonChooseRoute);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(3, 3);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(531, 259);
            this.map.TabIndex = 2;
            this.map.Zoom = 10D;
            // 
            // tabStrava
            // 
            this.tabStrava.Controls.Add(this.webBrowser1);
            this.tabStrava.HorizontalScrollbarBarColor = true;
            this.tabStrava.Location = new System.Drawing.Point(4, 35);
            this.tabStrava.Name = "tabStrava";
            this.tabStrava.Size = new System.Drawing.Size(537, 288);
            this.tabStrava.TabIndex = 2;
            this.tabStrava.Text = "Strava";
            this.tabStrava.VerticalScrollbarBarColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(531, 282);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1DocumentCompleted);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "tcx";
            this.openFile.Filter = "TCX|*.tcx";
            this.openFile.RestoreDirectory = true;
            this.openFile.SupportMultiDottedExtensions = true;
            this.openFile.Title = "Upload Ride";
            // 
            // fileParserThread
            // 
            this.fileParserThread.WorkerReportsProgress = true;
            this.fileParserThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FileParserThreadDoWork);
            this.fileParserThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FileParserThreadRunWorkerCompleted);
            // 
            // powerCalculationThread
            // 
            this.powerCalculationThread.WorkerReportsProgress = true;
            this.powerCalculationThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PowerCalculationThreadDoWork);
            this.powerCalculationThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PowerCalculationThreadRunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 413);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Cycling Power Estimation";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.metroTabControl1.ResumeLayout(false);
            this.tabTCX.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabMap.ResumeLayout(false);
            this.tabStrava.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabTCX;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox riderWeight;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox temperature;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox bikeWeight;
        private MetroFramework.Controls.MetroTextBox frontalArea;
        private MetroFramework.Controls.MetroTextBox dragCoefficient;
        private MetroFramework.Controls.MetroTextBox coefficientOfRollingResistance;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton buttonUpload;
        private MetroFramework.Controls.MetroTextBox filename;
        private MetroFramework.Controls.MetroTextBox logText;
        private MetroFramework.Controls.MetroButton buttonProcess;
        private MetroFramework.Controls.MetroTabPage tabStrava;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroCheckBox createCSV;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.ComponentModel.BackgroundWorker fileParserThread;
        private System.ComponentModel.BackgroundWorker powerCalculationThread;
        private MetroFramework.Controls.MetroTabPage tabMap;
        private GMap.NET.WindowsForms.GMapControl map;
        private MetroFramework.Controls.MetroButton buttonRoute;
    }
}


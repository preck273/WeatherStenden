
namespace WeatherStenden
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.weatherstation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.current = new System.Windows.Forms.TabPage();
            this.convention = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cloudImage = new System.Windows.Forms.PictureBox();
            this.temperature = new System.Windows.Forms.Label();
            this.windDirection = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.humidty = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cloud = new System.Windows.Forms.Label();
            this.lastUpdate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.trend = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.title2 = new System.Windows.Forms.Label();
            this.temperatureGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.option = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.location = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optionOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.celcius = new System.Windows.Forms.RadioButton();
            this.fahrenheit = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPages.SuspendLayout();
            this.weatherstation.SuspendLayout();
            this.current.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudImage)).BeginInit();
            this.trend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureGraph)).BeginInit();
            this.option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.ContextMenuStrip = this.weatherstation;
            this.tabPages.Controls.Add(this.current);
            this.tabPages.Controls.Add(this.trend);
            this.tabPages.Controls.Add(this.option);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Location = new System.Drawing.Point(0, 0);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(680, 543);
            this.tabPages.TabIndex = 0;
            // 
            // weatherstation
            // 
            this.weatherstation.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.weatherstation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.weatherstation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentTempToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.weatherstation.Name = "contextMenuStrip1";
            this.weatherstation.Size = new System.Drawing.Size(175, 148);
            // 
            // currentTempToolStripMenuItem
            // 
            this.currentTempToolStripMenuItem.Name = "currentTempToolStripMenuItem";
            this.currentTempToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.currentTempToolStripMenuItem.Text = "Current Temp: ";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // current
            // 
            this.current.ContextMenuStrip = this.weatherstation;
            this.current.Controls.Add(this.convention);
            this.current.Controls.Add(this.pictureBox1);
            this.current.Controls.Add(this.cloudImage);
            this.current.Controls.Add(this.temperature);
            this.current.Controls.Add(this.windDirection);
            this.current.Controls.Add(this.windSpeed);
            this.current.Controls.Add(this.humidty);
            this.current.Controls.Add(this.label11);
            this.current.Controls.Add(this.cloud);
            this.current.Controls.Add(this.lastUpdate);
            this.current.Controls.Add(this.label9);
            this.current.Controls.Add(this.label8);
            this.current.Controls.Add(this.label7);
            this.current.Controls.Add(this.label6);
            this.current.Controls.Add(this.label5);
            this.current.Controls.Add(this.textLocation);
            this.current.Controls.Add(this.title);
            this.current.Location = new System.Drawing.Point(4, 25);
            this.current.Name = "current";
            this.current.Padding = new System.Windows.Forms.Padding(3);
            this.current.Size = new System.Drawing.Size(672, 514);
            this.current.TabIndex = 0;
            this.current.Text = "Current";
            this.current.UseVisualStyleBackColor = true;
            // 
            // convention
            // 
            this.convention.AutoSize = true;
            this.convention.Location = new System.Drawing.Point(395, 194);
            this.convention.Name = "convention";
            this.convention.Size = new System.Drawing.Size(16, 17);
            this.convention.TabIndex = 16;
            this.convention.Text = "F";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 126);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cloudImage
            // 
            this.cloudImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("cloudImage.InitialImage")));
            this.cloudImage.Location = new System.Drawing.Point(460, 130);
            this.cloudImage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cloudImage.Name = "cloudImage";
            this.cloudImage.Size = new System.Drawing.Size(173, 81);
            this.cloudImage.TabIndex = 14;
            this.cloudImage.TabStop = false;
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(345, 194);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(54, 17);
            this.temperature.TabIndex = 13;
            this.temperature.Text = "label12";
            // 
            // windDirection
            // 
            this.windDirection.AutoSize = true;
            this.windDirection.Location = new System.Drawing.Point(260, 281);
            this.windDirection.Name = "windDirection";
            this.windDirection.Size = new System.Drawing.Size(54, 17);
            this.windDirection.TabIndex = 12;
            this.windDirection.Text = "label12";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.Location = new System.Drawing.Point(257, 254);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(54, 17);
            this.windSpeed.TabIndex = 11;
            this.windSpeed.Text = "label12";
            // 
            // humidty
            // 
            this.humidty.AutoSize = true;
            this.humidty.Location = new System.Drawing.Point(257, 227);
            this.humidty.Name = "humidty";
            this.humidty.Size = new System.Drawing.Size(54, 17);
            this.humidty.TabIndex = 10;
            this.humidty.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Current temp:";
            // 
            // cloud
            // 
            this.cloud.AutoSize = true;
            this.cloud.Location = new System.Drawing.Point(508, 227);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(54, 17);
            this.cloud.TabIndex = 8;
            this.cloud.Text = "label11";
            // 
            // lastUpdate
            // 
            this.lastUpdate.AutoSize = true;
            this.lastUpdate.Location = new System.Drawing.Point(457, 333);
            this.lastUpdate.Name = "lastUpdate";
            this.lastUpdate.Size = new System.Drawing.Size(54, 17);
            this.lastUpdate.TabIndex = 7;
            this.lastUpdate.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Last Update:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Wind Direction:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Wind Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Humidty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Temperature:";
            // 
            // textLocation
            // 
            this.textLocation.AutoSize = true;
            this.textLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocation.Location = new System.Drawing.Point(125, 152);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(123, 25);
            this.textLocation.TabIndex = 1;
            this.textLocation.Text = "Emmen, NL";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(211, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Weatherstation";
            // 
            // trend
            // 
            this.trend.Controls.Add(this.pictureBox2);
            this.trend.Controls.Add(this.title2);
            this.trend.Controls.Add(this.temperatureGraph);
            this.trend.Location = new System.Drawing.Point(4, 25);
            this.trend.Name = "trend";
            this.trend.Padding = new System.Windows.Forms.Padding(3);
            this.trend.Size = new System.Drawing.Size(672, 514);
            this.trend.TabIndex = 1;
            this.trend.Text = "Trend";
            this.trend.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 173);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(289, 49);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(211, 31);
            this.title2.TabIndex = 0;
            this.title2.Text = "Weatherstation";
            // 
            // temperatureGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.temperatureGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Temperature";
            this.temperatureGraph.Legends.Add(legend1);
            this.temperatureGraph.Location = new System.Drawing.Point(177, 103);
            this.temperatureGraph.Name = "temperatureGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Temperature";
            series1.Name = "Temperature (C)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Temperature";
            series2.Name = "Temperature (F)";
            this.temperatureGraph.Series.Add(series1);
            this.temperatureGraph.Series.Add(series2);
            this.temperatureGraph.Size = new System.Drawing.Size(633, 403);
            this.temperatureGraph.TabIndex = 2;
            this.temperatureGraph.Text = "chart1";
            // 
            // option
            // 
            this.option.ContextMenuStrip = this.weatherstation;
            this.option.Controls.Add(this.pictureBox3);
            this.option.Controls.Add(this.interval);
            this.option.Controls.Add(this.location);
            this.option.Controls.Add(this.label4);
            this.option.Controls.Add(this.optionOk);
            this.option.Controls.Add(this.label3);
            this.option.Controls.Add(this.celcius);
            this.option.Controls.Add(this.fahrenheit);
            this.option.Controls.Add(this.label2);
            this.option.Controls.Add(this.label1);
            this.option.Controls.Add(this.title3);
            this.option.Location = new System.Drawing.Point(4, 25);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(672, 514);
            this.option.TabIndex = 2;
            this.option.Text = "Options";
            this.option.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 168);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(284, 171);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(120, 22);
            this.interval.TabIndex = 10;
            this.interval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(284, 122);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(215, 22);
            this.location.TabIndex = 9;
            this.location.Text = "Emmen, NL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "(in sec.)";
            // 
            // optionOk
            // 
            this.optionOk.Location = new System.Drawing.Point(424, 279);
            this.optionOk.Name = "optionOk";
            this.optionOk.Size = new System.Drawing.Size(75, 23);
            this.optionOk.TabIndex = 6;
            this.optionOk.Text = "Ok";
            this.optionOk.UseVisualStyleBackColor = true;
            this.optionOk.Click += new System.EventHandler(this.optionOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Display:";
            // 
            // celcius
            // 
            this.celcius.AutoSize = true;
            this.celcius.Location = new System.Drawing.Point(327, 228);
            this.celcius.Name = "celcius";
            this.celcius.Size = new System.Drawing.Size(38, 21);
            this.celcius.TabIndex = 4;
            this.celcius.Text = "C";
            this.celcius.UseVisualStyleBackColor = true;
            // 
            // fahrenheit
            // 
            this.fahrenheit.AutoSize = true;
            this.fahrenheit.Checked = true;
            this.fahrenheit.Location = new System.Drawing.Point(284, 228);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(37, 21);
            this.fahrenheit.TabIndex = 3;
            this.fahrenheit.TabStop = true;
            this.fahrenheit.Text = "F";
            this.fahrenheit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interval: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location: ";
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.Location = new System.Drawing.Point(195, 35);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(211, 31);
            this.title3.TabIndex = 0;
            this.title3.Text = "Weatherstation";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.weatherstation;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WeatherStation";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 543);
            this.Controls.Add(this.tabPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NHL Stenden weatherstation";
            this.tabPages.ResumeLayout(false);
            this.weatherstation.ResumeLayout(false);
            this.current.ResumeLayout(false);
            this.current.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudImage)).EndInit();
            this.trend.ResumeLayout(false);
            this.trend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureGraph)).EndInit();
            this.option.ResumeLayout(false);
            this.option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage current;
        private System.Windows.Forms.TabPage trend;
        private System.Windows.Forms.TabPage option;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton celcius;
        private System.Windows.Forms.RadioButton fahrenheit;
        private System.Windows.Forms.Button optionOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label textLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lastUpdate;
        private System.Windows.Forms.Label cloud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label humidty;
        private System.Windows.Forms.Label windDirection;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.ContextMenuStrip weatherstation;
        private System.Windows.Forms.ToolStripMenuItem currentTempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureGraph;
        private System.Windows.Forms.Label convention;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cloudImage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


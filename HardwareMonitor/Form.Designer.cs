namespace HardwareMonitor
{
    partial class Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///     Clean up any resources being used.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelCpuShowMax = new System.Windows.Forms.Label();
            this.labelCpuShow = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelHddShowMax = new System.Windows.Forms.Label();
            this.labelHddShow = new System.Windows.Forms.Label();
            this.progressBarHDD = new System.Windows.Forms.ProgressBar();
            this.labelHDD = new System.Windows.Forms.Label();
            this.labelRamShowMax = new System.Windows.Forms.Label();
            this.labelRamShow = new System.Windows.Forms.Label();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.labelRAM = new System.Windows.Forms.Label();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pHDD = new System.Diagnostics.PerformanceCounter();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPU.Location = new System.Drawing.Point(50, 27);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(53, 20);
            this.labelCPU.TabIndex = 8;
            this.labelCPU.Text = "CPU:";
            // 
            // labelCpuShow
            // 
            this.labelCpuShow.AutoSize = true;
            this.labelCpuShow.Location = new System.Drawing.Point(354, 30);
            this.labelCpuShow.Name = "labelCpuShow";
            this.labelCpuShow.Size = new System.Drawing.Size(28, 17);
            this.labelCpuShow.TabIndex = 10;
            this.labelCpuShow.Text = "0%";
            // 
            // labelCpuShowMax
            // 
            this.labelCpuShowMax.AutoSize = true;
            this.labelCpuShowMax.Location = new System.Drawing.Point(462, 30);
            this.labelCpuShowMax.Name = "labelCpuShowMax";
            this.labelCpuShowMax.Size = new System.Drawing.Size(28, 17);
            this.labelCpuShowMax.TabIndex = 11;
            this.labelCpuShowMax.Text = "0%";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(134, 22);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(200, 25);
            this.progressBarCPU.TabIndex = 9;
            // 
            // labelHDD
            // 
            this.labelHDD.AutoSize = true;
            this.labelHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHDD.Location = new System.Drawing.Point(50, 127);
            this.labelHDD.Name = "labelHDD";
            this.labelHDD.Size = new System.Drawing.Size(57, 20);
            this.labelHDD.TabIndex = 17;
            this.labelHDD.Text = "HDD:";
            // 
            // labelHddShow
            // 
            this.labelHddShow.AutoSize = true;
            this.labelHddShow.Location = new System.Drawing.Point(354, 130);
            this.labelHddShow.Name = "labelHddShow";
            this.labelHddShow.Size = new System.Drawing.Size(28, 17);
            this.labelHddShow.TabIndex = 19;
            this.labelHddShow.Text = "0%";
            // 
            // labelHddShowMax
            // 
            this.labelHddShowMax.AutoSize = true;
            this.labelHddShowMax.Location = new System.Drawing.Point(462, 130);
            this.labelHddShowMax.Name = "labelHddShowMax";
            this.labelHddShowMax.Size = new System.Drawing.Size(28, 17);
            this.labelHddShowMax.TabIndex = 20;
            this.labelHddShowMax.Text = "0%";
            // 
            // progressBarHDD
            // 
            this.progressBarHDD.Location = new System.Drawing.Point(134, 122);
            this.progressBarHDD.Name = "progressBarHDD";
            this.progressBarHDD.Size = new System.Drawing.Size(200, 25);
            this.progressBarHDD.TabIndex = 18;
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRAM.Location = new System.Drawing.Point(50, 77);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(55, 20);
            this.labelRAM.TabIndex = 13;
            this.labelRAM.Text = "RAM:";
            // 
            // labelRamShow
            // 
            this.labelRamShow.AutoSize = true;
            this.labelRamShow.Location = new System.Drawing.Point(354, 80);
            this.labelRamShow.Name = "labelRamShow";
            this.labelRamShow.Size = new System.Drawing.Size(28, 17);
            this.labelRamShow.TabIndex = 15;
            this.labelRamShow.Text = "0%";
            // 
            // labelRamShowMax
            // 
            this.labelRamShowMax.AutoSize = true;
            this.labelRamShowMax.Location = new System.Drawing.Point(462, 80);
            this.labelRamShowMax.Name = "labelRamShowMax";
            this.labelRamShowMax.Size = new System.Drawing.Size(28, 17);
            this.labelRamShowMax.TabIndex = 16;
            this.labelRamShowMax.Text = "0%";
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(134, 72);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(200, 25);
            this.progressBarRAM.TabIndex = 14;
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Процессор";
            this.pCPU.CounterName = "% загруженности процессора";
            this.pCPU.InstanceName = "_Total";
            // 
            // pHDD
            // 
            this.pHDD.CategoryName = "Логический диск";
            this.pHDD.CounterName = "% активности диска";
            this.pHDD.InstanceName = "C:";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Память";
            this.pRAM.CounterName = "% использования выделенной памяти";
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(20, 200);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.Name = "CPU";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Blue;
            series8.Legend = "Legend1";
            series8.Name = "RAM";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Red;
            series9.Legend = "Legend1";
            series9.Name = "HDD";
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Series.Add(series9);
            this.chart.Size = new System.Drawing.Size(600, 300);
            this.chart.TabIndex = 21;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.labelHddShowMax);
            this.Controls.Add(this.labelHddShow);
            this.Controls.Add(this.progressBarHDD);
            this.Controls.Add(this.labelHDD);
            this.Controls.Add(this.labelRamShowMax);
            this.Controls.Add(this.labelRamShow);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCpuShowMax);
            this.Controls.Add(this.labelCpuShow);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.labelCPU);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "Form";
            this.Text = "Resource monitoring.";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelCpuShowMax;
        private System.Windows.Forms.Label labelCpuShow;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelHddShowMax;
        private System.Windows.Forms.Label labelHddShow;
        private System.Windows.Forms.ProgressBar progressBarHDD;
        private System.Windows.Forms.Label labelHDD;
        private System.Windows.Forms.Label labelRamShowMax;
        private System.Windows.Forms.Label labelRamShow;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.Label labelRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pHDD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timer;
    }
}


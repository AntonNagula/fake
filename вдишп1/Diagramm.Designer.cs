namespace вдишп1
{
    partial class Diagramm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Trains = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timetableButton = new System.Windows.Forms.Button();
            this.Bus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Trains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).BeginInit();
            this.SuspendLayout();
            // 
            // Trains
            // 
            chartArea1.Name = "ChartArea1";
            this.Trains.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Trains.Legends.Add(legend1);
            this.Trains.Location = new System.Drawing.Point(99, 32);
            this.Trains.Name = "Trains";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Trains.Series.Add(series1);
            this.Trains.Size = new System.Drawing.Size(300, 300);
            this.Trains.TabIndex = 0;
            this.Trains.Text = "Соотношение времени поездов";
            // 
            // timetableButton
            // 
            this.timetableButton.Location = new System.Drawing.Point(6, 32);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(87, 31);
            this.timetableButton.TabIndex = 16;
            this.timetableButton.Text = "Расписания";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.TimeTable_Click);
            // 
            // Bus
            // 
            chartArea2.Name = "ChartArea1";
            this.Bus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Bus.Legends.Add(legend2);
            this.Bus.Location = new System.Drawing.Point(417, 32);
            this.Bus.Name = "Bus";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Bus.Series.Add(series2);
            this.Bus.Size = new System.Drawing.Size(300, 300);
            this.Bus.TabIndex = 17;
            this.Bus.Text = "Соотношение времени автобусов";
            // 
            // Diagramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 344);
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.timetableButton);
            this.Controls.Add(this.Trains);
            this.Name = "Diagramm";
            this.Text = "Diagramm";
            ((System.ComponentModel.ISupportInitialize)(this.Trains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Trains;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Bus;
    }
}
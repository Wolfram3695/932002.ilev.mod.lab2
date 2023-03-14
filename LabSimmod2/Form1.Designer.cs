namespace gogo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Eurovalue = new System.Windows.Forms.NumericUpDown();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.Calcbutton = new System.Windows.Forms.Button();
            this.Dollarlabel = new System.Windows.Forms.Label();
            this.Dollarvalue = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Eurolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eurovalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dollarvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(16, 97);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsValueShownAsLabel = true;
            series3.LabelBorderWidth = 10;
            series3.LabelFormat = "f4";
            series3.Legend = "Legend1";
            series3.Name = "Euro";
            series3.SmartLabelStyle.MaxMovingDistance = 1D;
            series3.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Green;
            series4.IsValueShownAsLabel = true;
            series4.LabelBorderWidth = 10;
            series4.LabelFormat = "f4";
            series4.Legend = "Legend1";
            series4.Name = "Dollar";
            series4.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series4.SmartLabelStyle.MaxMovingDistance = 3D;
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1035, 473);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Eurovalue
            // 
            this.Eurovalue.DecimalPlaces = 3;
            this.Eurovalue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Eurovalue.Location = new System.Drawing.Point(131, 34);
            this.Eurovalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Eurovalue.Name = "Eurovalue";
            this.Eurovalue.Size = new System.Drawing.Size(160, 22);
            this.Eurovalue.TabIndex = 1;
            this.Eurovalue.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(43, 37);
            this.Pricelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(73, 16);
            this.Pricelabel.TabIndex = 2;
            this.Pricelabel.Text = "Initial price:";
            // 
            // Calcbutton
            // 
            this.Calcbutton.Location = new System.Drawing.Point(895, 37);
            this.Calcbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calcbutton.Name = "Calcbutton";
            this.Calcbutton.Size = new System.Drawing.Size(156, 28);
            this.Calcbutton.TabIndex = 3;
            this.Calcbutton.Text = "Start/Stop";
            this.Calcbutton.UseVisualStyleBackColor = true;
            this.Calcbutton.Click += new System.EventHandler(this.Calcbutton_Click);
            // 
            // Dollarlabel
            // 
            this.Dollarlabel.AutoSize = true;
            this.Dollarlabel.Location = new System.Drawing.Point(295, 11);
            this.Dollarlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dollarlabel.Name = "Dollarlabel";
            this.Dollarlabel.Size = new System.Drawing.Size(43, 16);
            this.Dollarlabel.TabIndex = 4;
            this.Dollarlabel.Text = "Dollar";
            // 
            // Dollarvalue
            // 
            this.Dollarvalue.DecimalPlaces = 3;
            this.Dollarvalue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Dollarvalue.Location = new System.Drawing.Point(299, 34);
            this.Dollarvalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dollarvalue.Name = "Dollarvalue";
            this.Dollarvalue.Size = new System.Drawing.Size(160, 22);
            this.Dollarvalue.TabIndex = 5;
            this.Dollarvalue.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Eurolabel
            // 
            this.Eurolabel.AutoSize = true;
            this.Eurolabel.Location = new System.Drawing.Point(127, 11);
            this.Eurolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Eurolabel.Name = "Eurolabel";
            this.Eurolabel.Size = new System.Drawing.Size(35, 16);
            this.Eurolabel.TabIndex = 6;
            this.Eurolabel.Text = "Euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 585);
            this.Controls.Add(this.Eurolabel);
            this.Controls.Add(this.Dollarvalue);
            this.Controls.Add(this.Dollarlabel);
            this.Controls.Add(this.Calcbutton);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.Eurovalue);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eurovalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dollarvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown Eurovalue;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Button Calcbutton;
        private System.Windows.Forms.Label Dollarlabel;
        private System.Windows.Forms.NumericUpDown Dollarvalue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Eurolabel;
    }
}


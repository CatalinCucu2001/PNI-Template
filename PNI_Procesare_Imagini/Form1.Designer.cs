namespace PNI_Procesare_Imagini
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartSource = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDestination = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.pictureBoxDestination = new System.Windows.Forms.PictureBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxStretchSource = new System.Windows.Forms.CheckBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxStretchDestination = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.comboBoxGraph = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSource
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSource.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSource.Legends.Add(legend1);
            this.chartSource.Location = new System.Drawing.Point(12, 404);
            this.chartSource.Name = "chartSource";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.chartSource.Series.Add(series1);
            this.chartSource.Series.Add(series2);
            this.chartSource.Series.Add(series3);
            this.chartSource.Size = new System.Drawing.Size(464, 150);
            this.chartSource.TabIndex = 0;
            this.chartSource.Text = "chart1";
            // 
            // chartDestination
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDestination.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDestination.Legends.Add(legend2);
            this.chartDestination.Location = new System.Drawing.Point(758, 404);
            this.chartDestination.Name = "chartDestination";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Red";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.Name = "Green";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Blue";
            this.chartDestination.Series.Add(series4);
            this.chartDestination.Series.Add(series5);
            this.chartDestination.Series.Add(series6);
            this.chartDestination.Size = new System.Drawing.Size(464, 150);
            this.chartDestination.TabIndex = 1;
            this.chartDestination.Text = "chart2";
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSource.Image")));
            this.pictureBoxSource.Location = new System.Drawing.Point(12, 60);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(464, 329);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
            this.pictureBoxSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSource_MouseDown);
            // 
            // pictureBoxDestination
            // 
            this.pictureBoxDestination.Location = new System.Drawing.Point(758, 60);
            this.pictureBoxDestination.Name = "pictureBoxDestination";
            this.pictureBoxDestination.Size = new System.Drawing.Size(464, 329);
            this.pictureBoxDestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDestination.TabIndex = 3;
            this.pictureBoxDestination.TabStop = false;
            this.pictureBoxDestination.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDestination_MouseDown);
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Location = new System.Drawing.Point(12, 22);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(89, 23);
            this.buttonLoadPicture.TabIndex = 4;
            this.buttonLoadPicture.Text = "Load Picture";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(758, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save Picture";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxStretchSource
            // 
            this.checkBoxStretchSource.AutoSize = true;
            this.checkBoxStretchSource.Checked = true;
            this.checkBoxStretchSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStretchSource.Location = new System.Drawing.Point(117, 26);
            this.checkBoxStretchSource.Name = "checkBoxStretchSource";
            this.checkBoxStretchSource.Size = new System.Drawing.Size(57, 17);
            this.checkBoxStretchSource.TabIndex = 6;
            this.checkBoxStretchSource.Text = "Strech";
            this.checkBoxStretchSource.UseVisualStyleBackColor = true;
            this.checkBoxStretchSource.CheckedChanged += new System.EventHandler(this.checkBoxStretchSource_CheckedChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(510, 60);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // checkBoxStretchDestination
            // 
            this.checkBoxStretchDestination.AutoSize = true;
            this.checkBoxStretchDestination.Checked = true;
            this.checkBoxStretchDestination.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStretchDestination.Location = new System.Drawing.Point(863, 26);
            this.checkBoxStretchDestination.Name = "checkBoxStretchDestination";
            this.checkBoxStretchDestination.Size = new System.Drawing.Size(57, 17);
            this.checkBoxStretchDestination.TabIndex = 8;
            this.checkBoxStretchDestination.Text = "Strech";
            this.checkBoxStretchDestination.UseVisualStyleBackColor = true;
            this.checkBoxStretchDestination.CheckedChanged += new System.EventHandler(this.checkBoxStretchDestination_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Actions:";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(624, 60);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAction.TabIndex = 10;
            this.comboBoxAction.Text = "-";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(624, 87);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(121, 23);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBoxGraph.Location = new System.Drawing.Point(489, 298);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxGraph.TabIndex = 12;
            this.pictureBoxGraph.TabStop = false;
            // 
            // comboBoxGraph
            // 
            this.comboBoxGraph.FormattingEnabled = true;
            this.comboBoxGraph.Items.AddRange(new object[] {
            "Liniar",
            "Invers",
            "Logaritm"});
            this.comboBoxGraph.Location = new System.Drawing.Point(489, 271);
            this.comboBoxGraph.Name = "comboBoxGraph";
            this.comboBoxGraph.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGraph.TabIndex = 13;
            this.comboBoxGraph.Text = "-";
            this.comboBoxGraph.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraph_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 566);
            this.Controls.Add(this.comboBoxGraph);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxStretchDestination);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.checkBoxStretchSource);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoadPicture);
            this.Controls.Add(this.pictureBoxDestination);
            this.Controls.Add(this.pictureBoxSource);
            this.Controls.Add(this.chartDestination);
            this.Controls.Add(this.chartSource);
            this.Name = "Form1";
            this.Text = "PNI";
            ((System.ComponentModel.ISupportInitialize)(this.chartSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDestination;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxDestination;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxStretchSource;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxStretchDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.ComboBox comboBoxGraph;
    }
}


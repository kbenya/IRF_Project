namespace BmiCalculator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.loadButton = new System.Windows.Forms.Button();
            this.weightDataGridView = new System.Windows.Forms.DataGridView();
            this.chartMeasurments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelBmiValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.buttonAddAndSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.advice1 = new BmiCalculator.Advice();
            ((System.ComponentModel.ISupportInitialize)(this.weightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurments)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(12, 173);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(141, 92);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Adatok betöltése";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // weightDataGridView
            // 
            this.weightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weightDataGridView.Location = new System.Drawing.Point(12, 271);
            this.weightDataGridView.Name = "weightDataGridView";
            this.weightDataGridView.RowHeadersWidth = 62;
            this.weightDataGridView.RowTemplate.Height = 28;
            this.weightDataGridView.Size = new System.Drawing.Size(523, 369);
            this.weightDataGridView.TabIndex = 1;
            // 
            // chartMeasurments
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMeasurments.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMeasurments.Legends.Add(legend2);
            this.chartMeasurments.Location = new System.Drawing.Point(826, 134);
            this.chartMeasurments.Name = "chartMeasurments";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMeasurments.Series.Add(series2);
            this.chartMeasurments.Size = new System.Drawing.Size(459, 506);
            this.chartMeasurments.TabIndex = 2;
            this.chartMeasurments.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "BMI kalkulátor és a testsúly alakulásának követése";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelenlegi súly:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "BMI:";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(226, 83);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 26);
            this.textBoxWeight.TabIndex = 7;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            // 
            // labelBmiValue
            // 
            this.labelBmiValue.AutoSize = true;
            this.labelBmiValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBmiValue.Location = new System.Drawing.Point(570, 81);
            this.labelBmiValue.Name = "labelBmiValue";
            this.labelBmiValue.Size = new System.Drawing.Size(28, 27);
            this.labelBmiValue.TabIndex = 8;
            this.labelBmiValue.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jelenlegi magasság:";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(226, 134);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 26);
            this.textBoxHeight.TabIndex = 10;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // buttonAddAndSave
            // 
            this.buttonAddAndSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAndSave.Location = new System.Drawing.Point(204, 173);
            this.buttonAddAndSave.Name = "buttonAddAndSave";
            this.buttonAddAndSave.Size = new System.Drawing.Size(246, 92);
            this.buttonAddAndSave.TabIndex = 12;
            this.buttonAddAndSave.Text = "Új adatok hozzáadása és mentése";
            this.buttonAddAndSave.UseVisualStyleBackColor = true;
            this.buttonAddAndSave.Click += new System.EventHandler(this.buttonAddAndSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Állapot:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(570, 134);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(28, 27);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "--";
            // 
            // advice1
            // 
            this.advice1.BackColor = System.Drawing.Color.White;
            this.advice1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advice1.Location = new System.Drawing.Point(556, 271);
            this.advice1.Name = "advice1";
            this.advice1.Size = new System.Drawing.Size(251, 202);
            this.advice1.TabIndex = 15;
            this.advice1.Text = "Kattints ide tanácsokért!";
            this.advice1.UseVisualStyleBackColor = false;
            this.advice1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 652);
            this.Controls.Add(this.advice1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddAndSave);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBmiValue);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartMeasurments);
            this.Controls.Add(this.weightDataGridView);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.weightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView weightDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeasurments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelBmiValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button buttonAddAndSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStatus;
        private Advice advice1;
    }
}


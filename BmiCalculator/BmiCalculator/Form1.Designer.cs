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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reaction21 = new BmiCalculator.Reaction();
            this.reaction22 = new BmiCalculator.Reaction();
            this.reaction23 = new BmiCalculator.Reaction();
            this.reaction24 = new BmiCalculator.Reaction();
            this.reaction25 = new BmiCalculator.Reaction();
            this.reaction16 = new BmiCalculator.Reaction();
            this.reaction17 = new BmiCalculator.Reaction();
            this.reaction18 = new BmiCalculator.Reaction();
            this.reaction19 = new BmiCalculator.Reaction();
            this.reaction20 = new BmiCalculator.Reaction();
            this.reaction11 = new BmiCalculator.Reaction();
            this.reaction12 = new BmiCalculator.Reaction();
            this.reaction13 = new BmiCalculator.Reaction();
            this.reaction14 = new BmiCalculator.Reaction();
            this.reaction15 = new BmiCalculator.Reaction();
            this.reaction6 = new BmiCalculator.Reaction();
            this.reaction7 = new BmiCalculator.Reaction();
            this.reaction8 = new BmiCalculator.Reaction();
            this.reaction9 = new BmiCalculator.Reaction();
            this.reaction10 = new BmiCalculator.Reaction();
            this.reaction5 = new BmiCalculator.Reaction();
            this.reaction4 = new BmiCalculator.Reaction();
            this.reaction3 = new BmiCalculator.Reaction();
            this.reaction2 = new BmiCalculator.Reaction();
            this.reaction1 = new BmiCalculator.Reaction();
            this.advice1 = new BmiCalculator.Advice();
            this.labelStatus = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(305, 9);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "kg/m^2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "cm";
            // 
            // reaction21
            // 
            this.reaction21.BackColor = System.Drawing.Color.White;
            this.reaction21.Location = new System.Drawing.Point(734, 278);
            this.reaction21.Name = "reaction21";
            this.reaction21.Size = new System.Drawing.Size(20, 20);
            this.reaction21.TabIndex = 43;
            this.reaction21.Text = "reaction21";
            this.reaction21.UseVisualStyleBackColor = false;
            // 
            // reaction22
            // 
            this.reaction22.BackColor = System.Drawing.Color.White;
            this.reaction22.Location = new System.Drawing.Point(734, 252);
            this.reaction22.Name = "reaction22";
            this.reaction22.Size = new System.Drawing.Size(20, 20);
            this.reaction22.TabIndex = 42;
            this.reaction22.Text = "reaction22";
            this.reaction22.UseVisualStyleBackColor = false;
            // 
            // reaction23
            // 
            this.reaction23.BackColor = System.Drawing.Color.White;
            this.reaction23.Location = new System.Drawing.Point(734, 225);
            this.reaction23.Name = "reaction23";
            this.reaction23.Size = new System.Drawing.Size(20, 20);
            this.reaction23.TabIndex = 41;
            this.reaction23.Text = "reaction23";
            this.reaction23.UseVisualStyleBackColor = false;
            // 
            // reaction24
            // 
            this.reaction24.BackColor = System.Drawing.Color.White;
            this.reaction24.Location = new System.Drawing.Point(734, 199);
            this.reaction24.Name = "reaction24";
            this.reaction24.Size = new System.Drawing.Size(20, 20);
            this.reaction24.TabIndex = 40;
            this.reaction24.Text = "reaction24";
            this.reaction24.UseVisualStyleBackColor = false;
            // 
            // reaction25
            // 
            this.reaction25.BackColor = System.Drawing.Color.White;
            this.reaction25.Location = new System.Drawing.Point(734, 173);
            this.reaction25.Name = "reaction25";
            this.reaction25.Size = new System.Drawing.Size(20, 20);
            this.reaction25.TabIndex = 39;
            this.reaction25.Text = "reaction25";
            this.reaction25.UseVisualStyleBackColor = false;
            // 
            // reaction16
            // 
            this.reaction16.BackColor = System.Drawing.Color.White;
            this.reaction16.Location = new System.Drawing.Point(708, 278);
            this.reaction16.Name = "reaction16";
            this.reaction16.Size = new System.Drawing.Size(20, 20);
            this.reaction16.TabIndex = 38;
            this.reaction16.Text = "reaction16";
            this.reaction16.UseVisualStyleBackColor = false;
            // 
            // reaction17
            // 
            this.reaction17.BackColor = System.Drawing.Color.White;
            this.reaction17.Location = new System.Drawing.Point(708, 252);
            this.reaction17.Name = "reaction17";
            this.reaction17.Size = new System.Drawing.Size(20, 20);
            this.reaction17.TabIndex = 37;
            this.reaction17.Text = "reaction17";
            this.reaction17.UseVisualStyleBackColor = false;
            // 
            // reaction18
            // 
            this.reaction18.BackColor = System.Drawing.Color.White;
            this.reaction18.Location = new System.Drawing.Point(708, 225);
            this.reaction18.Name = "reaction18";
            this.reaction18.Size = new System.Drawing.Size(20, 20);
            this.reaction18.TabIndex = 36;
            this.reaction18.Text = "reaction18";
            this.reaction18.UseVisualStyleBackColor = false;
            // 
            // reaction19
            // 
            this.reaction19.BackColor = System.Drawing.Color.White;
            this.reaction19.Location = new System.Drawing.Point(708, 199);
            this.reaction19.Name = "reaction19";
            this.reaction19.Size = new System.Drawing.Size(20, 20);
            this.reaction19.TabIndex = 35;
            this.reaction19.Text = "reaction19";
            this.reaction19.UseVisualStyleBackColor = false;
            // 
            // reaction20
            // 
            this.reaction20.BackColor = System.Drawing.Color.White;
            this.reaction20.Location = new System.Drawing.Point(708, 173);
            this.reaction20.Name = "reaction20";
            this.reaction20.Size = new System.Drawing.Size(20, 20);
            this.reaction20.TabIndex = 34;
            this.reaction20.Text = "reaction20";
            this.reaction20.UseVisualStyleBackColor = false;
            // 
            // reaction11
            // 
            this.reaction11.BackColor = System.Drawing.Color.White;
            this.reaction11.Location = new System.Drawing.Point(682, 278);
            this.reaction11.Name = "reaction11";
            this.reaction11.Size = new System.Drawing.Size(20, 20);
            this.reaction11.TabIndex = 33;
            this.reaction11.Text = "reaction11";
            this.reaction11.UseVisualStyleBackColor = false;
            // 
            // reaction12
            // 
            this.reaction12.BackColor = System.Drawing.Color.White;
            this.reaction12.Location = new System.Drawing.Point(682, 252);
            this.reaction12.Name = "reaction12";
            this.reaction12.Size = new System.Drawing.Size(20, 20);
            this.reaction12.TabIndex = 32;
            this.reaction12.Text = "reaction12";
            this.reaction12.UseVisualStyleBackColor = false;
            // 
            // reaction13
            // 
            this.reaction13.BackColor = System.Drawing.Color.White;
            this.reaction13.Location = new System.Drawing.Point(682, 225);
            this.reaction13.Name = "reaction13";
            this.reaction13.Size = new System.Drawing.Size(20, 20);
            this.reaction13.TabIndex = 31;
            this.reaction13.Text = "reaction13";
            this.reaction13.UseVisualStyleBackColor = false;
            // 
            // reaction14
            // 
            this.reaction14.BackColor = System.Drawing.Color.White;
            this.reaction14.Location = new System.Drawing.Point(682, 199);
            this.reaction14.Name = "reaction14";
            this.reaction14.Size = new System.Drawing.Size(20, 20);
            this.reaction14.TabIndex = 30;
            this.reaction14.Text = "reaction14";
            this.reaction14.UseVisualStyleBackColor = false;
            // 
            // reaction15
            // 
            this.reaction15.BackColor = System.Drawing.Color.White;
            this.reaction15.Location = new System.Drawing.Point(682, 173);
            this.reaction15.Name = "reaction15";
            this.reaction15.Size = new System.Drawing.Size(20, 20);
            this.reaction15.TabIndex = 29;
            this.reaction15.Text = "reaction15";
            this.reaction15.UseVisualStyleBackColor = false;
            // 
            // reaction6
            // 
            this.reaction6.BackColor = System.Drawing.Color.White;
            this.reaction6.Location = new System.Drawing.Point(656, 278);
            this.reaction6.Name = "reaction6";
            this.reaction6.Size = new System.Drawing.Size(20, 20);
            this.reaction6.TabIndex = 28;
            this.reaction6.Text = "reaction6";
            this.reaction6.UseVisualStyleBackColor = false;
            // 
            // reaction7
            // 
            this.reaction7.BackColor = System.Drawing.Color.White;
            this.reaction7.Location = new System.Drawing.Point(656, 252);
            this.reaction7.Name = "reaction7";
            this.reaction7.Size = new System.Drawing.Size(20, 20);
            this.reaction7.TabIndex = 27;
            this.reaction7.Text = "reaction7";
            this.reaction7.UseVisualStyleBackColor = false;
            // 
            // reaction8
            // 
            this.reaction8.BackColor = System.Drawing.Color.White;
            this.reaction8.Location = new System.Drawing.Point(656, 225);
            this.reaction8.Name = "reaction8";
            this.reaction8.Size = new System.Drawing.Size(20, 20);
            this.reaction8.TabIndex = 26;
            this.reaction8.Text = "reaction8";
            this.reaction8.UseVisualStyleBackColor = false;
            // 
            // reaction9
            // 
            this.reaction9.BackColor = System.Drawing.Color.White;
            this.reaction9.Location = new System.Drawing.Point(656, 199);
            this.reaction9.Name = "reaction9";
            this.reaction9.Size = new System.Drawing.Size(20, 20);
            this.reaction9.TabIndex = 25;
            this.reaction9.Text = "reaction9";
            this.reaction9.UseVisualStyleBackColor = false;
            // 
            // reaction10
            // 
            this.reaction10.BackColor = System.Drawing.Color.White;
            this.reaction10.Location = new System.Drawing.Point(656, 173);
            this.reaction10.Name = "reaction10";
            this.reaction10.Size = new System.Drawing.Size(20, 20);
            this.reaction10.TabIndex = 24;
            this.reaction10.Text = "reaction10";
            this.reaction10.UseVisualStyleBackColor = false;
            // 
            // reaction5
            // 
            this.reaction5.BackColor = System.Drawing.Color.White;
            this.reaction5.Location = new System.Drawing.Point(630, 278);
            this.reaction5.Name = "reaction5";
            this.reaction5.Size = new System.Drawing.Size(20, 20);
            this.reaction5.TabIndex = 23;
            this.reaction5.Text = "reaction5";
            this.reaction5.UseVisualStyleBackColor = false;
            // 
            // reaction4
            // 
            this.reaction4.BackColor = System.Drawing.Color.White;
            this.reaction4.Location = new System.Drawing.Point(630, 252);
            this.reaction4.Name = "reaction4";
            this.reaction4.Size = new System.Drawing.Size(20, 20);
            this.reaction4.TabIndex = 22;
            this.reaction4.Text = "reaction4";
            this.reaction4.UseVisualStyleBackColor = false;
            // 
            // reaction3
            // 
            this.reaction3.BackColor = System.Drawing.Color.White;
            this.reaction3.Location = new System.Drawing.Point(630, 225);
            this.reaction3.Name = "reaction3";
            this.reaction3.Size = new System.Drawing.Size(20, 20);
            this.reaction3.TabIndex = 21;
            this.reaction3.Text = "reaction3";
            this.reaction3.UseVisualStyleBackColor = false;
            // 
            // reaction2
            // 
            this.reaction2.BackColor = System.Drawing.Color.White;
            this.reaction2.Location = new System.Drawing.Point(630, 199);
            this.reaction2.Name = "reaction2";
            this.reaction2.Size = new System.Drawing.Size(20, 20);
            this.reaction2.TabIndex = 20;
            this.reaction2.Text = "reaction2";
            this.reaction2.UseVisualStyleBackColor = false;
            // 
            // reaction1
            // 
            this.reaction1.BackColor = System.Drawing.Color.White;
            this.reaction1.Location = new System.Drawing.Point(630, 173);
            this.reaction1.Name = "reaction1";
            this.reaction1.Size = new System.Drawing.Size(20, 20);
            this.reaction1.TabIndex = 19;
            this.reaction1.Text = "reaction1";
            this.reaction1.UseVisualStyleBackColor = false;
            // 
            // advice1
            // 
            this.advice1.BackColor = System.Drawing.Color.White;
            this.advice1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advice1.Location = new System.Drawing.Point(559, 322);
            this.advice1.Name = "advice1";
            this.advice1.Size = new System.Drawing.Size(251, 202);
            this.advice1.TabIndex = 15;
            this.advice1.Text = "Kattints ide tanácsokért!";
            this.advice1.UseVisualStyleBackColor = false;
            this.advice1.Value = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(570, 132);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(28, 27);
            this.labelStatus.TabIndex = 44;
            this.labelStatus.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 652);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.reaction21);
            this.Controls.Add(this.reaction22);
            this.Controls.Add(this.reaction23);
            this.Controls.Add(this.reaction24);
            this.Controls.Add(this.reaction25);
            this.Controls.Add(this.reaction16);
            this.Controls.Add(this.reaction17);
            this.Controls.Add(this.reaction18);
            this.Controls.Add(this.reaction19);
            this.Controls.Add(this.reaction20);
            this.Controls.Add(this.reaction11);
            this.Controls.Add(this.reaction12);
            this.Controls.Add(this.reaction13);
            this.Controls.Add(this.reaction14);
            this.Controls.Add(this.reaction15);
            this.Controls.Add(this.reaction6);
            this.Controls.Add(this.reaction7);
            this.Controls.Add(this.reaction8);
            this.Controls.Add(this.reaction9);
            this.Controls.Add(this.reaction10);
            this.Controls.Add(this.reaction5);
            this.Controls.Add(this.reaction4);
            this.Controls.Add(this.reaction3);
            this.Controls.Add(this.reaction2);
            this.Controls.Add(this.reaction1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.advice1);
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
        private Advice advice1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Reaction reaction1;
        private Reaction reaction2;
        private Reaction reaction3;
        private Reaction reaction4;
        private Reaction reaction5;
        private Reaction reaction6;
        private Reaction reaction7;
        private Reaction reaction8;
        private Reaction reaction9;
        private Reaction reaction10;
        private Reaction reaction11;
        private Reaction reaction12;
        private Reaction reaction13;
        private Reaction reaction14;
        private Reaction reaction15;
        private Reaction reaction16;
        private Reaction reaction17;
        private Reaction reaction18;
        private Reaction reaction19;
        private Reaction reaction20;
        private Reaction reaction21;
        private Reaction reaction22;
        private Reaction reaction23;
        private Reaction reaction24;
        private Reaction reaction25;
        private System.Windows.Forms.Label labelStatus;
    }
}


namespace Buffon_Needle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startSimulation = new Button();
            chart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputLength = new TextBox();
            inputGap = new TextBox();
            inputCount = new TextBox();
            label4 = new Label();
            piValue = new Label();
            stopSimulation = new Button();
            SuspendLayout();
            // 
            // startSimulation
            // 
            startSimulation.Location = new Point(1590, 25);
            startSimulation.Margin = new Padding(4, 5, 4, 5);
            startSimulation.Name = "startSimulation";
            startSimulation.Size = new Size(166, 60);
            startSimulation.TabIndex = 0;
            startSimulation.Text = "Start";
            startSimulation.UseVisualStyleBackColor = true;
            startSimulation.Click += startSimulation_Click;
            // 
            // chart
            // 
            chart.Location = new Point(33, 212);
            chart.Margin = new Padding(4, 5, 4, 5);
            chart.Name = "chart";
            chart.Size = new Size(1737, 645);
            chart.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 2;
            label1.Text = "Lengtf on Needle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 3;
            label2.Text = "Gap Between Lines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 4;
            label3.Text = "Number Of Attempts";
            // 
            // inputLength
            // 
            inputLength.Location = new Point(223, 38);
            inputLength.Margin = new Padding(4, 5, 4, 5);
            inputLength.Name = "inputLength";
            inputLength.Size = new Size(141, 31);
            inputLength.TabIndex = 5;
            // 
            // inputGap
            // 
            inputGap.Location = new Point(223, 98);
            inputGap.Margin = new Padding(4, 5, 4, 5);
            inputGap.Name = "inputGap";
            inputGap.Size = new Size(141, 31);
            inputGap.TabIndex = 6;
            // 
            // inputCount
            // 
            inputCount.Location = new Point(223, 163);
            inputCount.Margin = new Padding(4, 5, 4, 5);
            inputCount.Name = "inputCount";
            inputCount.Size = new Size(141, 31);
            inputCount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(674, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 67);
            label4.TabIndex = 8;
            label4.Text = "PI:";
            // 
            // piValue
            // 
            piValue.AutoSize = true;
            piValue.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            piValue.Location = new Point(761, 103);
            piValue.Margin = new Padding(4, 0, 4, 0);
            piValue.Name = "piValue";
            piValue.Size = new Size(73, 67);
            piValue.TabIndex = 9;
            piValue.Text = "??";
            // 
            // stopSimulation
            // 
            stopSimulation.Location = new Point(1590, 98);
            stopSimulation.Margin = new Padding(4, 5, 4, 5);
            stopSimulation.Name = "stopSimulation";
            stopSimulation.Size = new Size(166, 60);
            stopSimulation.TabIndex = 10;
            stopSimulation.Text = "Stop";
            stopSimulation.UseVisualStyleBackColor = true;
            stopSimulation.Click += stopSimulation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1787, 872);
            Controls.Add(stopSimulation);
            Controls.Add(piValue);
            Controls.Add(label4);
            Controls.Add(inputCount);
            Controls.Add(inputGap);
            Controls.Add(inputLength);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chart);
            Controls.Add(startSimulation);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startSimulation;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chart;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputLength;
        private TextBox inputGap;
        private TextBox inputCount;
        private Label label4;
        private Label piValue;
        private Button stopSimulation;
    }
}
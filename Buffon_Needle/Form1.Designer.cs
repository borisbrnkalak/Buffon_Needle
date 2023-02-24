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
            SuspendLayout();
            // 
            // startSimulation
            // 
            startSimulation.Location = new Point(1113, 15);
            startSimulation.Name = "startSimulation";
            startSimulation.Size = new Size(116, 36);
            startSimulation.TabIndex = 0;
            startSimulation.Text = "Start";
            startSimulation.UseVisualStyleBackColor = true;
            startSimulation.Click += startSimulation_Click;
            // 
            // chart
            // 
            chart.Location = new Point(23, 127);
            chart.Name = "chart";
            chart.Size = new Size(1216, 387);
            chart.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Lengtf on Needle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Gap Between Lines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 101);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 4;
            label3.Text = "Number Of Attempts";
            // 
            // inputLength
            // 
            inputLength.Location = new Point(156, 23);
            inputLength.Name = "inputLength";
            inputLength.Size = new Size(100, 23);
            inputLength.TabIndex = 5;
            // 
            // inputGap
            // 
            inputGap.Location = new Point(156, 59);
            inputGap.Name = "inputGap";
            inputGap.Size = new Size(100, 23);
            inputGap.TabIndex = 6;
            // 
            // inputCount
            // 
            inputCount.Location = new Point(156, 98);
            inputCount.Name = "inputCount";
            inputCount.Size = new Size(100, 23);
            inputCount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(472, 62);
            label4.Name = "label4";
            label4.Size = new Size(55, 46);
            label4.TabIndex = 8;
            label4.Text = "PI:";
            // 
            // piValue
            // 
            piValue.AutoSize = true;
            piValue.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            piValue.Location = new Point(533, 62);
            piValue.Name = "piValue";
            piValue.Size = new Size(50, 46);
            piValue.TabIndex = 9;
            piValue.Text = "??";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 523);
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
    }
}
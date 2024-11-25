namespace WinFormsAppArray
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            button1.Location = new Point(44, 118);
            button1.Name = "button1";
            button1.Size = new Size(159, 94);
            button1.TabIndex = 0;
            button1.Text = "Array1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            button2.Location = new Point(44, 254);
            button2.Name = "button2";
            button2.Size = new Size(159, 99);
            button2.TabIndex = 1;
            button2.Text = "ผลไม้";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            textBox1.Location = new Point(281, 165);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 404);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            label1.Location = new Point(783, 165);
            label1.Name = "label1";
            label1.Size = new Size(321, 425);
            label1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            button3.Location = new Point(620, 193);
            button3.Name = "button3";
            button3.Size = new Size(114, 101);
            button3.TabIndex = 4;
            button3.Text = "getData";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            label2.Location = new Point(281, 118);
            label2.Name = "label2";
            label2.Size = new Size(121, 40);
            label2.TabIndex = 5;
            label2.Text = "พิมพ์รายชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold);
            label3.Location = new Point(783, 118);
            label3.Name = "label3";
            label3.Size = new Size(184, 40);
            label3.TabIndex = 6;
            label3.Text = "รายชื่อที่บันทึกแล้ว";
            // 
            // button4
            // 
            button4.Font = new Font("TH Sarabun New", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(611, 341);
            button4.Name = "button4";
            button4.Size = new Size(137, 94);
            button4.TabIndex = 7;
            button4.Text = "getNumber";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(48, 392);
            button5.Name = "button5";
            button5.Size = new Size(165, 115);
            button5.TabIndex = 8;
            button5.Text = "array 2มิติ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1140, 662);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
    }
}

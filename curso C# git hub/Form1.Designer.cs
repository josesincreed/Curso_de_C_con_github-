namespace curso_C__git_hub
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 95);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Primer nùmero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 124);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Segundo nùmero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 153);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Tercer nùmero";
            // 
            // button1
            // 
            button1.Location = new Point(262, 99);
            button1.Name = "button1";
            button1.Size = new Size(136, 64);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 31);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Mayor y Menor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 223);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}
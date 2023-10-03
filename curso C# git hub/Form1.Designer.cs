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
            button1 = new Button();
            lblResultado = new Label();
            txtPeso = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAltura = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(135, 113);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 0;
            button1.Text = "Calcular IMC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(122, 154);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(133, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Indice de masa corporal";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(135, 53);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 2;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 61);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Peso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 87);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Altura";
            label1.Click += label1_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(135, 84);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 223);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtPeso);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblResultado;
        private TextBox txtPeso;
        private Label label2;
        private Label label1;
        private TextBox txtAltura;
    }
}
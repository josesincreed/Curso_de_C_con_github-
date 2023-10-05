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
            listCarritoDeCompras = new ListBox();
            btnAgregar = new Button();
            btnCalcular = new Button();
            cboProductos = new ComboBox();
            label1 = new Label();
            txtCodigoDescuento = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listCarritoDeCompras
            // 
            listCarritoDeCompras.FormattingEnabled = true;
            listCarritoDeCompras.ItemHeight = 15;
            listCarritoDeCompras.Location = new Point(12, 12);
            listCarritoDeCompras.Name = "listCarritoDeCompras";
            listCarritoDeCompras.Size = new Size(195, 244);
            listCarritoDeCompras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(213, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 32);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Añadir al carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(213, 79);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(124, 46);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Precio ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(213, 12);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(124, 23);
            cboProductos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 241);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 4;
            label1.Text = "Codigo de descuento";
            // 
            // txtCodigoDescuento
            // 
            txtCodigoDescuento.Location = new Point(362, 215);
            txtCodigoDescuento.Name = "txtCodigoDescuento";
            txtCodigoDescuento.Size = new Size(124, 23);
            txtCodigoDescuento.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download1;
            pictureBox1.Location = new Point(362, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 90);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.alvaro_uribe_velez_11;
            pictureBox2.Location = new Point(223, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 270);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtCodigoDescuento);
            Controls.Add(label1);
            Controls.Add(cboProductos);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(listCarritoDeCompras);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCarritoDeCompras;
        private Button btnAgregar;
        private Button btnCalcular;
        private ComboBox cboProductos;
        private Label label1;
        private TextBox txtCodigoDescuento;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
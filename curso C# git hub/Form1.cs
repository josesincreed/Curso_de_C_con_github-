namespace curso_C__git_hub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Motocierra $20");
            cboProductos.Items.Add("Botas al reves $35");
            cboProductos.Items.Add("Minas antipersona $37");
            cboProductos.Items.Add("Falsos positivos $40");
            cboProductos.Items.Add("Sombrero de gente de bien $15");
            cboProductos.Items.Add("Fusil $50");
            cboProductos.Items.Add("Poncho $18");
            cboProductos.Items.Add("Carriel $25");
            cboProductos.Items.Add("Kl cocaina $80");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listCarritoDeCompras.Items.Add(productoSeleccionado);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;

            int totalProductosCargados = listCarritoDeCompras.Items.Count;

            for (int i = 0; i < totalProductosCargados; i++)
            {
                string productoElegido = listCarritoDeCompras.Items[i].ToString();
                if (productoElegido == "Motocierra $20")
                {
                    precioFinal += 20;
                }
                else if (productoElegido == "Botas al reves $35")
                {
                    precioFinal += 35;
                }
                if (productoElegido == "Minas antipersona $37")
                {
                    precioFinal += 24;
                }
                if (productoElegido == "Falsos positivos $40")
                {
                    precioFinal += 40;
                }
                if (productoElegido == "Sombrero de gente de bien $15")
                {
                    precioFinal += 15;
                }
                if (productoElegido == "Fusil $50")
                {
                    precioFinal += 50;
                }
                if (productoElegido == "Poncho $18")
                {
                    precioFinal += 18;
                }
                if (productoElegido == "Carriel $25")
                {
                    precioFinal += 25;
                }
                if (productoElegido == "Kl cocaina $80")
                {
                    precioFinal += 80;
                }
            }
            if (txtCodigoDescuento.Text == "uribe paraco")
            {
                precioFinal = precioFinal * 0.9; //codigo 10% de descuento
            }
            if (txtCodigoDescuento.Text == "centro demoniaco")
            {
                precioFinal = precioFinal * 0.5; //codigo de 50% de descuento
            }
            MessageBox.Show("El precio final es: $" + precioFinal);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
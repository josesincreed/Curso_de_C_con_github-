namespace curso_C__git_hub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double peso = Double.Parse(textoPeso); //convertimos el texto a un numero klg

            string textoAltura = txtAltura.Text;
            double altura = Double.Parse(textoAltura); // metros

            double imc = peso / (altura * altura); //imc es peso dividido la altura al cuadrado

            MessageBox.Show("El IMC es: " + imc);
            

              
        }

















        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
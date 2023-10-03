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
            int numero1 = Int32.Parse(textBox1.Text);
            int numero2 = Int32.Parse(textBox2.Text);
            int numero3 = Int32.Parse(textBox3.Text);

            int mayor = numero1;

            if (numero2 > mayor) 
            {
                mayor = numero2; 
            }
            
            if (numero3 > mayor)
            {
                mayor = numero3; 
            }

            MessageBox.Show("El numero mayor es: " + mayor);
        
            int menor  = numero1;

            if (numero2 < menor) 
            {
                menor = numero2; 
            }
            
            if (numero3 < menor)
            {
                menor = numero3; 
            }

             MessageBox.Show("El numero menor es: " + menor);
    }
        }
}
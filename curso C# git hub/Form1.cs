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
            int edad = 15;
            bool esMayorDeEdad = edad >= 18;

           
            if (esMayorDeEdad)
            {
                label1.Text = "el usuario es mayor de edad";
            }
            else
            {
                label1.Text = "el usuario es menor de edad";
            }

        }
    }
}
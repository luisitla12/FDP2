namespace lot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar los números ingresados por el usuario
            if (int.TryParse(textBox1.Text, out int numero1) && int.TryParse(textBox2.Text, out int numero2))
            {
                Random random = new Random();
                int numeroAleatorio1 = random.Next(0, 41); // Genera un número aleatorio entre 0 y 40
                int numeroAleatorio2 = random.Next(0, 41);

                // Obtener la cantidad apostada
                decimal cantidadApostada = numericUpDown1.Value;

                // Verificar si el usuario adivinó los números
                bool acierto1 = numero1 == numeroAleatorio1;
                bool acierto2 = numero2 == numeroAleatorio2;

                // Calcular las ganancias
                decimal ganancias = 0;
                if (acierto1 && acierto2)
                {
                    ganancias = cantidadApostada * 10;
                    MessageBox.Show($"¡Felicidades, has adivinado ambos números! Ganaste {ganancias} unidades.");
                }
                else if (acierto1 || acierto2)
                {
                    ganancias = cantidadApostada * 5;
                    MessageBox.Show($"¡Felicidades, has adivinado un número! Ganaste {ganancias} unidades.");
                }
                else
                {
                    MessageBox.Show($"Número(s) incorrecto(s). Los números correctos eran {numeroAleatorio1} y {numeroAleatorio2}.");
                }

                // Guardar en la base de datos
               
            }
           
        }

    }
}


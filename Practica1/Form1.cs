namespace Practica1
{
    public partial class frmTemporizador : Form
    {
        private int horas, minutos, segundos;
        private bool enEjecucion = false;
        public frmTemporizador()
        {
            InitializeComponent();
            this.ResumeLayout(false);
        }

        private void Temporizador_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmrCronometro.Stop();
            enEjecucion = false;
            horas = minutos = segundos = 0;
            lblCronometro.Text = "00:00:00"; enEjecucion = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Iniciar_Click(object sender, EventArgs e)
        {
            enEjecucion = false;
            tmrCronometro.Start();
        }

        private void button2Detener_Click(object sender, EventArgs e)
        {
            tmrCronometro.Stop();
            enEjecucion = false;
        }

        private void tmrCronometro_Tick(object sender, EventArgs e)
        {
            lblCronometro.Text = DateTime.Now.ToString("hh:mm:ss");

            if (enEjecucion)
            {
                segundos++;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                    if (minutos == 60)
                    {
                        minutos = 0;
                        horas++;
                    }
                }
                lblCronometro.Text = DateTime.Now.ToString("hh:mm:ss");
            }
        }
    } 
}

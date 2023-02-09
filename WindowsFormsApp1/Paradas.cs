using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Paradas : Form
    {
        double parada_total1 = 0;
        double parada_total2 = 0;
        double parada_acumulada1 = 0;
        double total_parada = 0;
    

        public Paradas()
        {
            List<String> horarios = new List<String>();
            horarios.Add("00:00 AM");
            horarios.Add("00:05 AM");
            horarios.Add("00:10 AM");
            horarios.Add("00:15 AM");
            horarios.Add("00:20 AM");
            horarios.Add("00:25 AM");
            horarios.Add("00:30 AM");
            horarios.Add("00:35 AM");
            horarios.Add("00:40 AM");
            horarios.Add("00:45 AM");
            horarios.Add("00:50 AM");
            horarios.Add("00:55 AM");
            horarios.Add("01:00 AM");
            horarios.Add("01:05 AM");
            horarios.Add("01:10 AM");
            horarios.Add("01:15 AM");
            horarios.Add("01:20 AM");
            horarios.Add("01:25 AM");
            horarios.Add("01:30 AM");
            horarios.Add("01:35 AM");
            horarios.Add("01:40 AM");
            horarios.Add("01:45 AM");
            horarios.Add("01:50 AM");
            horarios.Add("01:55 AM");
            horarios.Add("02:00 AM");
            horarios.Add("02:05 AM");
            horarios.Add("02:10 AM");
            horarios.Add("02:15 AM");
            horarios.Add("02:20 AM");
            horarios.Add("02:25 AM");
            horarios.Add("02:30 AM");
            horarios.Add("02:35 AM");
            horarios.Add("02:40 AM");
            horarios.Add("02:45 AM");
            horarios.Add("02:50 AM");
            horarios.Add("02:55 AM");
            horarios.Add("03:00 AM");
            horarios.Add("03:05 AM");
            horarios.Add("03:10 AM");
            horarios.Add("03:15 AM");
            horarios.Add("03:20 AM");
            horarios.Add("03:25 AM");
            horarios.Add("03:30 AM");
            horarios.Add("03:35 AM");
            horarios.Add("03:40 AM");
            horarios.Add("03:45 AM");
            horarios.Add("03:50 AM");
            horarios.Add("03:55 AM");
            horarios.Add("04:00 AM");
            horarios.Add("04:05 AM");
            horarios.Add("04:10 AM");
            horarios.Add("04:15 AM");
            horarios.Add("04:20 AM");
            horarios.Add("04:25 AM");
            horarios.Add("04:30 AM");
            horarios.Add("04:35 AM");
            horarios.Add("04:40 AM");
            horarios.Add("04:45 AM");
            horarios.Add("04:50 AM");
            horarios.Add("04:55 AM");
            horarios.Add("05:00 AM");
            horarios.Add("05:05 AM");
            horarios.Add("05:10 AM");
            horarios.Add("05:15 AM");
            horarios.Add("05:20 AM");
            horarios.Add("05:25 AM");
            horarios.Add("05:30 AM");
            horarios.Add("05:35 AM");
            horarios.Add("05:40 AM");
            horarios.Add("05:45 AM");
            horarios.Add("05:50 AM");
            horarios.Add("05:55 AM");
            horarios.Add("06:00 AM");
            horarios.Add("06:05 AM");
            horarios.Add("06:10 AM");
            horarios.Add("06:15 AM");
            horarios.Add("06:20 AM");
            horarios.Add("06:25 AM");
            horarios.Add("06:30 AM");
            horarios.Add("06:35 AM");
            horarios.Add("06:40 AM");
            horarios.Add("06:45 AM");
            horarios.Add("06:50 AM");
            horarios.Add("06:55 AM");
            horarios.Add("07:00 AM");
            horarios.Add("07:05 AM");
            horarios.Add("07:10 AM");
            horarios.Add("07:15 AM");
            horarios.Add("07:20 AM");
            horarios.Add("07:25 AM");
            horarios.Add("07:30 AM");
            horarios.Add("07:35 AM");
            horarios.Add("07:40 AM");
            horarios.Add("07:45 AM");
            horarios.Add("07:50 AM");
            horarios.Add("07:55 AM");
            horarios.Add("08:00 AM");
            horarios.Add("08:05 AM");
            horarios.Add("08:10 AM");
            horarios.Add("08:15 AM");
            horarios.Add("08:20 AM");
            horarios.Add("08:25 AM");
            horarios.Add("08:30 AM");
            horarios.Add("08:35 AM");
            horarios.Add("08:40 AM");
            horarios.Add("08:45 AM");
            horarios.Add("08:50 AM");
            horarios.Add("08:55 AM");
            horarios.Add("09:00 AM");
            horarios.Add("09:05 AM");
            horarios.Add("09:10 AM");
            horarios.Add("09:15 AM");
            horarios.Add("09:20 AM");
            horarios.Add("09:25 AM");
            horarios.Add("09:30 AM");
            horarios.Add("09:35 AM");
            horarios.Add("09:40 AM");
            horarios.Add("09:45 AM");
            horarios.Add("09:50 AM");
            horarios.Add("09:55 AM");
            horarios.Add("10:00 AM");
            horarios.Add("10:05 AM");
            horarios.Add("10:10 AM");
            horarios.Add("10:15 AM");
            horarios.Add("10:20 AM");
            horarios.Add("10:25 AM");
            horarios.Add("10:30 AM");
            horarios.Add("10:35 AM");
            horarios.Add("10:40 AM");
            horarios.Add("10:45 AM");
            horarios.Add("10:50 AM");
            horarios.Add("10:55 AM");
            horarios.Add("11:00 AM");
            horarios.Add("11:05 AM");
            horarios.Add("11:10 AM");
            horarios.Add("11:15 AM");
            horarios.Add("11:20 AM");
            horarios.Add("11:25 AM");
            horarios.Add("11:30 AM");
            horarios.Add("11:35 AM");
            horarios.Add("11:40 AM");
            horarios.Add("11:45 AM");
            horarios.Add("11:50 AM");
            horarios.Add("11:55 AM");
            horarios.Add("12:00 AM");
            horarios.Add("12:05 AM");
            horarios.Add("12:10 AM");
            horarios.Add("12:15 AM");
            horarios.Add("12:20 AM");
            horarios.Add("12:25 AM");
            horarios.Add("12:30 AM");
            horarios.Add("12:35 AM");
            horarios.Add("12:40 AM");
            horarios.Add("12:45 AM");
            horarios.Add("12:50 AM");
            horarios.Add("12:55 AM");
            horarios.Add("13:00 PM");
            horarios.Add("13:05 PM");
            horarios.Add("13:10 PM");
            horarios.Add("13:15 PM");
            horarios.Add("13:20 PM");
            horarios.Add("13:25 PM");
            horarios.Add("13:30 PM");
            horarios.Add("13:35 PM");
            horarios.Add("13:40 PM");
            horarios.Add("13:45 PM");
            horarios.Add("13:50 PM");
            horarios.Add("13:55 PM");
            horarios.Add("14:00 PM");
            horarios.Add("14:05 PM");
            horarios.Add("14:10 PM");
            horarios.Add("14:15 PM");
            horarios.Add("14:20 PM");
            horarios.Add("14:25 PM");
            horarios.Add("14:30 PM");
            horarios.Add("14:35 PM");
            horarios.Add("14:40 PM");
            horarios.Add("14:45 PM");
            horarios.Add("14:50 PM");
            horarios.Add("14:55 PM");
            horarios.Add("15:00 PM");
            horarios.Add("15:05 PM");
            horarios.Add("15:10 PM");
            horarios.Add("15:15 PM");
            horarios.Add("15:20 PM");
            horarios.Add("15:25 PM");
            horarios.Add("15:30 PM");
            horarios.Add("15:35 PM");
            horarios.Add("15:40 PM");
            horarios.Add("15:45 PM");
            horarios.Add("15:50 PM");
            horarios.Add("15:55 PM");
            horarios.Add("16:00 PM");
            horarios.Add("16:05 PM");
            horarios.Add("16:10 PM");
            horarios.Add("16:15 PM");
            horarios.Add("16:20 PM");
            horarios.Add("16:25 PM");
            horarios.Add("16:30 PM");
            horarios.Add("16:35 PM");
            horarios.Add("16:40 PM");
            horarios.Add("16:45 PM");
            horarios.Add("16:50 PM");
            horarios.Add("16:55 PM");
            horarios.Add("17:00 PM");
            horarios.Add("17:05 PM");
            horarios.Add("17:10 PM");
            horarios.Add("17:15 PM");
            horarios.Add("17:20 PM");
            horarios.Add("17:25 PM");
            horarios.Add("17:30 PM");
            horarios.Add("17:35 PM");
            horarios.Add("17:40 PM");
            horarios.Add("17:45 PM");
            horarios.Add("17:50 PM");
            horarios.Add("17:55 PM");
            horarios.Add("18:00 PM");
            horarios.Add("18:05 PM");
            horarios.Add("18:10 PM");
            horarios.Add("18:15 PM");
            horarios.Add("18:20 PM");
            horarios.Add("18:25 PM");
            horarios.Add("18:30 PM");
            horarios.Add("18:35 PM");
            horarios.Add("18:40 PM");
            horarios.Add("18:45 PM");
            horarios.Add("18:50 PM");
            horarios.Add("18:55 PM");
            horarios.Add("19:00 PM");
            horarios.Add("19:05 PM");
            horarios.Add("19:10 PM");
            horarios.Add("19:15 PM");
            horarios.Add("19:20 PM");
            horarios.Add("19:25 PM");
            horarios.Add("19:30 PM");
            horarios.Add("19:35 PM");
            horarios.Add("19:40 PM");
            horarios.Add("19:45 PM");
            horarios.Add("19:50 PM");
            horarios.Add("19:55 PM");
            horarios.Add("20:00 PM");
            horarios.Add("20:05 PM");
            horarios.Add("20:10 PM");
            horarios.Add("20:15 PM");
            horarios.Add("20:20 PM");
            horarios.Add("20:25 PM");
            horarios.Add("20:30 PM");
            horarios.Add("20:35 PM");
            horarios.Add("20:40 PM");
            horarios.Add("20:45 PM");
            horarios.Add("20:50 PM");
            horarios.Add("20:55 PM");
            horarios.Add("21:00 PM");
            horarios.Add("21:05 PM");
            horarios.Add("21:10 PM");
            horarios.Add("21:15 PM");
            horarios.Add("21:20 PM");
            horarios.Add("21:25 PM");
            horarios.Add("21:30 PM");
            horarios.Add("21:35 PM");
            horarios.Add("21:40 PM");
            horarios.Add("21:45 PM");
            horarios.Add("21:50 PM");
            horarios.Add("21:55 PM");
            horarios.Add("22:00 PM");
            horarios.Add("22:05 PM");
            horarios.Add("22:10 PM");
            horarios.Add("22:15 PM");
            horarios.Add("22:20 PM");
            horarios.Add("22:25 PM");
            horarios.Add("22:30 PM");
            horarios.Add("22:35 PM");
            horarios.Add("22:40 PM");
            horarios.Add("22:45 PM");
            horarios.Add("22:50 PM");
            horarios.Add("22:55 PM");
            horarios.Add("23:00 PM");
            horarios.Add("23:05 PM");
            horarios.Add("23:10 PM");
            horarios.Add("23:15 PM");
            horarios.Add("23:20 PM");
            horarios.Add("23:25 PM");
            horarios.Add("23:30 PM");
            horarios.Add("23:35 PM");
            horarios.Add("23:40 PM");
            horarios.Add("23:45 PM");
            horarios.Add("23:50 PM");
            horarios.Add("23:55 PM");


            List<String> parada1 = new List<String>();
            List<String> parada2 = new List<String>();
            List<String> paradafin1 = new List<String>();
            List<String> paradafin2 = new List<String>();

           
            parada1.AddRange(horarios);
            parada2.AddRange(horarios);
            paradafin1.AddRange(horarios);
            paradafin2.AddRange(horarios);




            InitializeComponent();

           
            cb_parada1.DataSource = parada1;
            cb_parada2.DataSource = parada2;
            cb_paradafin1.DataSource = paradafin1;
            cb_paradafin2.DataSource = paradafin2;

           




        }




        private void Paradas_Load(object sender, EventArgs e)
        {

        }

        private void cb_paradafin1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan diferenciaHoras = new TimeSpan();
            DateTime fechaInicio = new DateTime();
            fechaInicio = DateTime.Parse(cb_parada1.Text);

            DateTime fechaLlegada = new DateTime();
            fechaLlegada = DateTime.Parse(cb_paradafin1.Text);

            diferenciaHoras = fechaLlegada - fechaInicio;
            int horas = diferenciaHoras.Hours;
            parada_total1 = diferenciaHoras.TotalHours;


            Console.WriteLine(parada_total1);
            total_parada1.Text = parada_total1.ToString();

        }

        private void cb_paradafin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan diferenciaHoras = new TimeSpan();
            DateTime fechaInicio = new DateTime();
            fechaInicio = DateTime.Parse(cb_parada2.Text);

            DateTime fechaLlegada = new DateTime();
            fechaLlegada = DateTime.Parse(cb_paradafin2.Text);

            diferenciaHoras = fechaLlegada - fechaInicio;
            int horas = diferenciaHoras.Hours;
            parada_total2 = diferenciaHoras.TotalHours;


            Console.WriteLine(parada_total2);
            total_parada2.Text = parada_total2.ToString();
            
        }

        private void cb_parada1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_parada2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void total_parada1_TextChanged(object sender, EventArgs e)
        {
            
            // paradas_acumuladas.Text = (parada_total1 + parada_total2).ToString();

        }

        private void total_parada2_TextChanged(object sender, EventArgs e)
        {
            
            // paradas_acumuladas.Text = (parada_total1 + parada_total2).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void nueva_Click(object sender, EventArgs e)
        {
            double acumulador;

            if (tex_paradas.Text != "")
            {
                acumulador = Convert.ToDouble(tex_paradas.Text);

                parada_acumulada1 = acumulador + parada_total1 + parada_total2;
            }
            else
  

            parada_acumulada1 =  parada_total1 + parada_total2;

            tex_paradas.Text = parada_acumulada1 .ToString();

            Form1 form1= new Form1();
            form1.cargar_paradas(1);
            
             // form1.Show();
             //form1.textBox1.Text = tex_paradas.Text;
            // form1.paradas_acumulado(tex_paradas.Text);
             total_parada = total_parada + Convert.ToDouble(tex_paradas.Text);

           //  this.Hide();
            
        }

        private void paradas_acumuladas_TextChanged(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.ActualizarParadas(this.tex_paradas.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void andres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Paradas_Load_1(object sender, EventArgs e)
        {

        }
    }
}

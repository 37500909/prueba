using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int total;
        double total_general = 0;
        double total_general1 = 0;
        double total_general2 = 0;
        double horasTotales1 = 0;
        double horasTotales2 = 0;
        double comidatotal1 = 0;
        String paradas_netas;
        double comidatotal2 = 0;
        public String paradasNetas;
        double total_parada = 0;
        public decimal formulario1;
   



        public Form1()
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

            List<string> sector = new List<string>();

            

            sector.Add("Preseleccion");
            sector.Add("Empaque");

            List<String> horarios2 = new List<String>();
            List<String> horariosf1 = new List<String>();
            List<String> horariosf2 = new List<String>();
            List<String> comida1 = new List<String>();
            List<String> comida2 = new List<String>();
            List<String> comidafin1 = new List<String>();
            List<String> comidafin2 = new List<String>();
            
  

            horarios2.AddRange(horarios);
            horariosf1.AddRange(horarios);
            horariosf2.AddRange(horarios);
            comida1.AddRange(horarios);
            comida2.AddRange(horarios);
            comidafin1.AddRange(horarios);
            comidafin2.AddRange(horarios);
           

            InitializeComponent();
            cb_sector.DataSource=sector;

            cb_turno1.DataSource = horarios;
            cb_turno2.DataSource = horarios2;
            cb_turno_fin1.DataSource = horariosf1;
            cb_turno_fin2.DataSource = horariosf2;
            cb_comida1.DataSource = comida1;
            cb_comida2.DataSource= comida2;
            cb_comidafin1.DataSource = comidafin1;
            cb_comidafin2.DataSource = comidafin2;

           





        }
        public void cargar_paradas(decimal _valor) {
            formulario1 = _valor ;
            paradas_acumuladas.Text = formulario1.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarParadas(String _valor)
        {
            cb_total_hr_netas.Text = _valor;
           
        }

        public void paradas_acumulado(String _valor)
        {
           paradas_netas = _valor;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_turno2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cb_turno_fin1_SelectedIndexChanged(object sender, EventArgs e)
        {
                 
            TimeSpan diferenciaHoras = new TimeSpan();
            DateTime fechaInicio = new DateTime();
            fechaInicio = DateTime.Parse(cb_turno1.Text);

            DateTime fechaLlegada = new DateTime();
            fechaLlegada = DateTime.Parse(cb_turno_fin1.Text);

            diferenciaHoras = fechaLlegada - fechaInicio;
            int horas = diferenciaHoras.Hours;
            horasTotales1 = diferenciaHoras.TotalHours;

            Console.WriteLine(horasTotales1);
            total_horas1.Text = horasTotales1.ToString();
            total_general = 0 ;
            total_general =  (horasTotales1  - comidatotal1)  ;
            cb_total_hr_netas.Text = total_general.ToString();

            total_general1 = 0;
            total_general1 = (horasTotales1 + comidatotal1);

            cb_total_hr_netas.Text = total_general.ToString();
            cb_total_hr_totales.Text = total_general1.ToString();
            
                             
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void total_horas_TextChanged(object sender, EventArgs e)
        {
            

           cb_total_hr_netas.Text = total_general.ToString();
           cb_total_hr_totales.Text = total_general1.ToString();

        }

        private void cb_turno_fin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan diferenciaHoras = new TimeSpan();
            DateTime fechaInicio = new DateTime();
            fechaInicio = DateTime.Parse(cb_turno2.Text);

            DateTime fechaLlegada = new DateTime();
            fechaLlegada = DateTime.Parse(cb_turno_fin2.Text);

            diferenciaHoras = fechaLlegada - fechaInicio;
            int horas = diferenciaHoras.Hours;
             horasTotales2 = diferenciaHoras.TotalHours;

            Console.WriteLine(horasTotales2);
            total_horas2.Text = horasTotales2.ToString();
            total_general = 0;
            total_general = horasTotales2 - comidatotal2 ;
            cb_total_hr_netas2.Text = total_general.ToString();

            total_general2 = 0;
            cb_total_hr_totales2.Text = (horasTotales2 + comidatotal2).ToString();

        }


        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comida1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cb_comidafin1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan diferenciaHoras = new TimeSpan();
            DateTime fechaInicio = new DateTime();
            fechaInicio = DateTime.Parse(cb_comida1.Text);

            DateTime fechaLlegada = new DateTime();
            fechaLlegada = DateTime.Parse(cb_comidafin1.Text);

            diferenciaHoras = fechaLlegada - fechaInicio;
            int horas = diferenciaHoras.Hours;
             comidatotal1 = diferenciaHoras.TotalHours;


            Console.WriteLine(comidatotal1);
            total_comida1.Text = comidatotal1.ToString();

            total_general = 0;
            cb_total_hr_netas.Text = (- comidatotal1 + horasTotales1 ).ToString();

            total_general1 = 0;
            cb_total_hr_totales.Text = ( horasTotales1 + comidatotal1 ).ToString();




        }

        private void cb_comidafin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan diferenciaHoras = new TimeSpan();
            DateTime fechaInicio = new DateTime();
            fechaInicio = DateTime.Parse(cb_comida2.Text);

            DateTime fechaLlegada = new DateTime();
            fechaLlegada = DateTime.Parse(cb_comidafin2.Text);

            diferenciaHoras = fechaLlegada - fechaInicio;
            int horas = diferenciaHoras.Hours;
            comidatotal2 = diferenciaHoras.TotalHours;


            Console.WriteLine(comidatotal2);
            total_comida2.Text = comidatotal2.ToString();
            total_general = 0;
            cb_total_hr_netas2.Text = (- comidatotal2 + horasTotales2 ).ToString();
            total_general2= 0;
            cb_total_hr_totales2.Text = (horasTotales2 + comidatotal2).ToString();

        }
      
         private void cb_total_hr_netas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void total_horas2_TextChanged(object sender, EventArgs e)
        {
          
            cb_total_hr_netas2.Text = total_general.ToString();
            cb_total_hr_totales2.Text = total_general2.ToString();
        }

        private void total_comida1_TextChanged(object sender, EventArgs e)
        {
           
        }

  
        private void total_comida2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Paradas paradas = new Paradas();
           paradas.Show();

          
           

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            cb_total_hr_netas.Text = paradasNetas;
            


        }

        private void cb_total_hr_totales_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cb_total_hr_totales2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_sector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

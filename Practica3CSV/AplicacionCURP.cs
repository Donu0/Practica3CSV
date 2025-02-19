using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3CSV
{
    public partial class AplicacionCURP : Form
    {
        public AplicacionCURP()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string fecha = txtCurp.Text.Substring(4, 6);
            if(Convert.ToInt32(fecha.Substring(0, 2)) > 25)
            {
                fecha = "19" + fecha;
            }
            else
            {
                fecha = "20" + fecha;
            }

            fecha = fecha.Substring(0, 4) + "/" + fecha.Substring(4, 2) + "/" + fecha.Substring(6, 2);  

            string sexo = txtCurp.Text.Substring(10, 1);
            string estado = txtCurp.Text.Substring(11, 2);
            Dictionary<string, string> estadosMexico = new Dictionary<string, string>
            {
                { "AS", "Aguascalientes" },
                { "BC", "Baja California" },
                { "BS", "Baja California Sur" },
                { "CC", "Campeche" },
                { "CS", "Chiapas" },
                { "CH", "Chihuahua" },
                { "CL", "Coahuila" },
                { "CM", "Colima" },
                { "DF", "Ciudad de México" },
                { "DG", "Durango" },
                { "GT", "Guanajuato" },
                { "GR", "Guerrero" },
                { "HG", "Hidalgo" },
                { "JC", "Jalisco" },
                { "MC", "Estado de México" },
                { "MN", "Michoacán" },
                { "MS", "Morelos" },
                { "NT", "Nayarit" },
                { "NL", "Nuevo León" },
                { "OC", "Oaxaca" },
                { "PL", "Puebla" },
                { "QT", "Querétaro" },
                { "QR", "Quintana Roo" },
                { "SP", "San Luis Potosí" },
                { "SL", "Sinaloa" },
                { "SR", "Sonora" },
                { "TC", "Tabasco" },
                { "TS", "Tamaulipas" },
                { "TL", "Tlaxcala" },
                { "VZ", "Veracruz" },
                { "YN", "Yucatán" },
                { "ZS", "Zacatecas" }
             };

            if (sexo == "H")
            {
                sexo = "Hombre";
            }
            else
            {
                sexo = "Mujer";
            }

            MessageBox.Show("Fecha de nacimiento: " + fecha + ". " + " Estado: " + estadosMexico[estado] + " Sexo: " + sexo, "Datos de la CURP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaCalculo.Enabled = true;
            btnCalcular.Enabled = true;
            dtpFechaCalculo.MinDate = dtpFechaNacimiento.MinDate;
        }

        private void dtpFechaCalculo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcEdad_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpFechaNacimiento.Value;
            DateTime calculo = dtpFechaCalculo.Value;
            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;

            if(calculo.Month < nacimiento.Month)
            {
                edad--;
                meses += 12;
            }

            if(calculo.Day < nacimiento.Day)
            {
                meses--;
                dias += DateTime.DaysInMonth(calculo.Year, calculo.Month - 1);
            }

            MessageBox.Show("Años: " + edad + " Meses: " + meses + " Días: " + dias, " Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

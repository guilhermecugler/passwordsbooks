using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace PL
{
    public partial class FrmTopografiaCalculos : Form
    {
        public Calculo calculo = new Calculo();

        public FrmTopografiaCalculos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
 

            calculo.latitude1 =  Convert.ToDouble(txtEstacaoLat.Text);
            calculo.longitude1 = Convert.ToDouble(txtEstacaoLong.Text);
            calculo.latitude2 = Convert.ToDouble(txtLatitude.Text);
            calculo.longitude2 = Convert.ToDouble(txtLongitude.Text);

            var azimuth = calculo.calculateAzimuth(calculo.latitude1, calculo.longitude1, calculo.latitude2, calculo.longitude2);
            var distance = calculo.calculateDistanceBetween2Points(calculo.latitude1, calculo.longitude1, calculo.latitude2, calculo.longitude2).ToString("N0");


            string[] gridLine = { distance, ConvertDecimalToDegreesMinutesAndSecondsReturnsString(azimuth), calculo.latitude2.ToString("N0"), calculo.longitude2.ToString("N0") };
            Grid.Rows.Add(gridLine);

            calculo.latitude1 = 0;
            calculo.longitude1 = 0;
            calculo.latitude2 = 0;
            calculo.longitude2 = 0;

            
        }


        //Converter decimais para graus, minutos e segundos
        string ConvertDecimalToDegreesMinutesAndSecondsReturnsString(double Decimal)
        {
            double seconds = Decimal * 3600;
            double degrees = seconds / 3600;
            seconds = Math.Abs(seconds % 3600);
            double minutes = seconds / 60;
            seconds %= 60;

            string stringDegreesMinutesAndSeconds = (
                Math.Round(degrees)+"°",
                Math.Round(minutes).ToString("00")+"'",
                Math.Round(seconds).ToString()+"\""
                ).ToString().Replace("(", "").Replace(")", "");

            return stringDegreesMinutesAndSeconds;
        }

    }
}

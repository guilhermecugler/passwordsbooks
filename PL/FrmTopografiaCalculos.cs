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
 

            calculo.x1 =  Convert.ToDouble(txtEstacaoLat.Text);
            calculo.y1 = Convert.ToDouble(txtEstacaoLong.Text);
            calculo.x2 = Convert.ToDouble(txtLatitude.Text);
            calculo.y2 = Convert.ToDouble(txtLongitude.Text);

            var azimute = calculo.calcularAzimute(calculo.x1, calculo.y1, calculo.x2, calculo.y2);
            var distancia = calculo.calcularDistancia(calculo.x1, calculo.y1, calculo.x2, calculo.y2).ToString("N0");


            string[] linhaCalculo = { distancia, ConvertDecimal(azimute), calculo.x2.ToString("N0"), calculo.y2.ToString("N0") };
            Grid.Rows.Add(linhaCalculo);

            calculo.x1 = 0;
            calculo.y1 = 0;
            calculo.x2 = 0;
            calculo.y2 = 0;

            
        }


        //Converter decimais para graus, minutos e segundos
        string ConvertDecimal(double azimute)
        {
            double segundos = azimute * 3600;
            double graus = segundos / 3600;
            segundos = Math.Abs(segundos % 3600);
            double minutos = segundos / 60;
            segundos %= 60;

            string convetido = (
                Math.Round(graus)+"°",
                Math.Round(minutos).ToString("00")+"'",
                segundos.ToString("F")+"\""
                ).ToString().Replace("(", "").Replace(")", "");

            return convetido;
        }

    }
}

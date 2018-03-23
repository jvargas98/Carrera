using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera2
{
    public partial class Form1 : Form
    {
        Liebre liebre = new Liebre();
        Tortuga tortuga = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;
            while (numero1 < 81 && numero2 < 81)
            {
                numero1 = liebre.comenzar();
                numero2 = tortuga.comenzar();
                lstbPista.Items.Add("liebre     " + liebre.mostrar());       
                lstbPista.Items.Add("tortuga  " + tortuga.mostrar());
            }
            if (numero1 >= 80 && numero2 >= 80)
            {
                lstbPista.Items.Add("Empate");
            }
            else if (numero1 >= 80)
            {
                lstbPista.Items.Add("Ganador : liebre");
            }
            else if (numero2 >= 80)
            {
                lstbPista.Items.Add("Ganador : tortuga");
            }
        }

        private void lstbPista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

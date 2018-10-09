using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibAutos;

namespace Listas
{
    public partial class Form1 : Form
    {
        List<Auto> miLista = new List<Auto>();

        Auto deportivo1 = new Auto("TOYOTA Supra", "2014", 96000, "S", 849000);
        Auto deportivo2 = new Auto("MITSUBISHI Lancer Evo IX", "2017", 15000, "S", 779000);
        Auto atv1 = new Auto("LAN ROVER Discovery Sport", "2018", 1000, "A", 1256000);
        Auto atv2 = new Auto("BMW X6","2017",0,"S",1576000);
        Auto superlujo1 = new Auto("MERCEDES BENZ Clase S", "2016", 0, "A", 2412000);
        Auto superlujo2 = new Auto("MCLAREN 720S","2019",0,"S",5552000);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvAutos.Visible = true;
            label2.Visible = true;
            btnComprar.Visible = true;
        }
    }
}

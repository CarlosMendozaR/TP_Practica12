﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibAutos;

namespace Listas
{
    public partial class Form1 : Form
    {
        List<Auto> miLista = new List<Auto>();

        public Form1()
        {
            Auto deportivo1 = new Auto("TOYOTA Supra", "2014", 96000, "S", 849000);
            Auto deportivo2 = new Auto("MITSUBISHI Lancer Evo IX", "2017", 15000, "S", 779000);
            Auto atv1 = new Auto("LAN ROVER Discovery Sport", "2018", 1000, "A", 1256000);
            Auto atv2 = new Auto("BMW X6", "2017", 0, "S", 1576000);
            Auto superlujo2 = new Auto("FERRARI F12", "2018", 0, "S", 3798660);

            miLista.Add(deportivo1);
            miLista.Add(deportivo2);
            miLista.Add(atv1);
            miLista.Add(atv2);
            miLista.Add(superlujo1);
            miLista.Add(superlujo2);

            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvAutos.Visible = true;
            label2.Visible = true;
            btnComprar.Visible = true;
            int count = miLista.Count;
            for (int i = 0; i < count; i++)
            {
                dgvAutos.Rows.Add(miLista[i].Nombre, miLista[i].Modelo, miLista[i].Kilometraje, miLista[i].Transmision, miLista[i].Precio);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auto comprado");
            int referencia = 0; //dgvAutos.Rows.IndexOf(dgvAutos.SelectedRows);
            miLista.RemoveAt(referencia);
            dgvAutos.Rows.RemoveAt(referencia);
        }
    }
}

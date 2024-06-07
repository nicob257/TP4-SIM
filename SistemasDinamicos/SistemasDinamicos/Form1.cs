using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RelojeriaSimulacion
{
    public partial class Form1 : Form
    {
        private Simulator simulator;

        public Form1()
        {
            InitializeComponent();
            simulator = new Simulator();
            simulator.InicializarSistema();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            // Ejecutar la simulación
            simulator.Simular(1000, 100, 100, 0); // Ajusta los parámetros según sea necesario

            // Obtener los estados resultantes
            List<StateRow> estados = simulator.Estados;

            // Mostrar resultados en el DataGridView
            dataGridViewResultados.DataSource = estados;
        }
    }
}

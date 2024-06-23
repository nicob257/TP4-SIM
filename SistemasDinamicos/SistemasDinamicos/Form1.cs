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
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            btnSimular.Hide();
            simulator.InicializarSistema();
            dataGridViewResultados.DataSource = null;
            dgvRK.DataSource = null;
            // Ejecutar la simulación

            List<RkRow> tablaRk = simulator.CalcularRK(3, 0.5, 2, 0.1);
            dgvRK.DataSource = tablaRk;


            List<StateRow> estados = simulator.Simular(Convert.ToInt32(tiempo.Text), Convert.ToInt32(iteraciones.Text), Convert.ToInt32(i.Text), Convert.ToInt32(j.Text),
                Convert.ToDouble(txtProbCompra.Text), Convert.ToDouble(txtProbEntrega.Text), Convert.ToDouble(txtProbRetiro.Text),
                Convert.ToInt32(txtLiLleg.Text), Convert.ToInt32(txtLsLleg.Text), Convert.ToInt32(txtLiCp.Text), Convert.ToInt32(txtLsCp.Text), Convert.ToInt32(txtLiRep.Text), Convert.ToInt32(txtLsRep.Text));

            

            // Mostrar resultados en el DataGridView
            dataGridViewResultados.DataSource = estados;
            lblPNoReparado.Text = simulator.ObtenerPNoReparado().ToString();
            ocupAy.Text = simulator.ObtenerPorcOcupacionAyudante().ToString();
            ocupRel.Text = simulator.ObtenerPorcOcupacionRelojero().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void i_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

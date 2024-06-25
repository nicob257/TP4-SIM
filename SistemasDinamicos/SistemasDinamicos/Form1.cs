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
            simulator.InicializarProbabilidades(Convert.ToDouble(txtProbCompra.Text), Convert.ToDouble(txtProbEntrega.Text),
                Convert.ToInt32(txtLiLleg.Text), Convert.ToInt32(txtLsLleg.Text), 
                Convert.ToInt32(txtLiCp.Text), Convert.ToInt32(txtLsCp.Text), Convert.ToInt32(txtLiRep.Text), 
                Convert.ToInt32(txtLsRep.Text), Convert.ToInt32(txtTmpOrden.Text),
                Convert.ToInt32(txtLiInsp.Text), Convert.ToInt32(txtLsInsp.Text));


            List<RkRow> tablaRk = simulator.CalcularRK(Convert.ToInt32(txtRk1.Text), Convert.ToDouble(txtRk2.Text), Convert.ToInt32(txtRk3.Text), Convert.ToDouble(txtHRK.Text), Convert.ToInt32(txtLsInsp.Text));
            dgvRK.DataSource = tablaRk;
            List<object> vectores = simulator.Simular(Convert.ToInt32(tiempo.Text), Convert.ToInt32(iteraciones.Text), 
                Convert.ToInt32(i.Text), Convert.ToInt32(j.Text));
                
            dataGridViewResultados.DataSource = vectores;
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtProbCompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

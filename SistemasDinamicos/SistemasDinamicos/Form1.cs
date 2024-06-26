using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

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
            try
            {
                if (
                Convert.ToDouble(txtProbCompra.Text, CultureInfo.InvariantCulture) >= 0 &&
                Convert.ToDouble(txtProbEntrega.Text, CultureInfo.InvariantCulture) >= 0 &&
                Convert.ToDouble(txtProbRetiro.Text, CultureInfo.InvariantCulture) >= 0 &&
                (Convert.ToDouble(txtProbRetiro.Text, CultureInfo.InvariantCulture) + Convert.ToDouble(txtProbEntrega.Text, CultureInfo.InvariantCulture) + Convert.ToDouble(txtProbCompra.Text, CultureInfo.InvariantCulture) == 1) &&
                Convert.ToInt32(txtLiLleg.Text) >= 0 &&
                Convert.ToInt32(txtLsLleg.Text) >= 0 &&
                (Convert.ToInt32(txtLiLleg.Text) <= Convert.ToInt32(txtLsLleg.Text)) &&
                Convert.ToInt32(txtLiCp.Text) >= 0 &&
                Convert.ToInt32(txtLsCp.Text) >= 0 &&
                (Convert.ToInt32(txtLiCp.Text) <= Convert.ToInt32(txtLsCp.Text)) &&
                Convert.ToInt32(txtLiRep.Text) >= 0 &&
                Convert.ToInt32(txtLsRep.Text) >= 0 &&
                (Convert.ToInt32(txtLiRep.Text) <= Convert.ToInt32(txtLsRep.Text)) &&
                Convert.ToInt32(txtTmpOrden.Text) >= 0 &&
                Convert.ToInt32(txtLiInsp.Text) >= 0 &&
                Convert.ToInt32(txtLsInsp.Text) >= 0 &&
                (Convert.ToInt32(txtLiInsp.Text) <= Convert.ToInt32(txtLsInsp.Text)) &&
                Convert.ToInt32(txtRk1.Text) >= 0 &&
                Convert.ToDouble(txtRk2.Text) >= 0 &&
                Convert.ToInt32(txtRk3.Text) >= 0 &&
                Convert.ToDouble(txtHRK.Text, CultureInfo.InvariantCulture) >= 0 &&
                Convert.ToInt32(tiempo.Text) >= 0 &&
                Convert.ToInt32(iteraciones.Text) >= 0 &&
                Convert.ToInt32(i.Text) >= 0 &&
                Convert.ToInt32(j.Text) >= 0
                )
                {
                    simulator.InicializarProbabilidades(Convert.ToDouble(txtProbCompra.Text, CultureInfo.InvariantCulture), Convert.ToDouble(txtProbEntrega.Text, CultureInfo.InvariantCulture),
                    Convert.ToInt32(txtLiLleg.Text), Convert.ToInt32(txtLsLleg.Text),
                    Convert.ToInt32(txtLiCp.Text), Convert.ToInt32(txtLsCp.Text), Convert.ToInt32(txtLiRep.Text),
                    Convert.ToInt32(txtLsRep.Text), Convert.ToInt32(txtTmpOrden.Text),
                    Convert.ToInt32(txtLiInsp.Text), Convert.ToInt32(txtLsInsp.Text));


                    List<RkRow> tablaRk = simulator.CalcularRK(Convert.ToInt32(txtRk1.Text), Convert.ToDouble(txtRk2.Text), Convert.ToInt32(txtRk3.Text), Convert.ToDouble(txtHRK.Text, CultureInfo.InvariantCulture), Convert.ToInt32(txtLsInsp.Text));
                    dgvRK.DataSource = tablaRk;
                    List<object> vectores = simulator.Simular(Convert.ToInt32(tiempo.Text), Convert.ToInt32(iteraciones.Text),
                        Convert.ToInt32(i.Text), Convert.ToInt32(j.Text));

                    dataGridViewResultados.DataSource = vectores;
                    lblPNoReparado.Text = simulator.ObtenerPNoReparado().ToString();
                    ocupAy.Text = simulator.ObtenerPorcOcupacionAyudante().ToString();
                    ocupRel.Text = simulator.ObtenerPorcOcupacionRelojero().ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese valores correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Ingrese datos del tipo adecuado en los campos (int o float según corresponda)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            





            
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

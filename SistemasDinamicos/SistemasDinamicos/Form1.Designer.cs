namespace RelojeriaSimulacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnSimular = new System.Windows.Forms.Button();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(12, 12);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(760, 407);
            this.dataGridViewResultados.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.btnSimular);
            this.Name = "Form1";
            this.Text = "Simulación de Relojería";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
    }
}

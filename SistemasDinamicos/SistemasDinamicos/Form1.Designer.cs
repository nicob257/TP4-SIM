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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSimular = new System.Windows.Forms.Button();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iteraciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.j = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProbCompra = new System.Windows.Forms.TextBox();
            this.txtProbEntrega = new System.Windows.Forms.TextBox();
            this.txtProbRetiro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPNoReparado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.AutoSize = true;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(43, 11);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(102, 40);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dataGridViewResultados
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewResultados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowHeadersWidth = 51;
            this.dataGridViewResultados.Size = new System.Drawing.Size(1358, 491);
            this.dataGridViewResultados.TabIndex = 1;
            this.dataGridViewResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad Tiempo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tiempo
            // 
            this.tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(340, 12);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(116, 26);
            this.tiempo.TabIndex = 3;
            this.tiempo.Text = "1000";
            this.tiempo.TextChanged += new System.EventHandler(this.tiempo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(484, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(187, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad Iteraciones:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iteraciones
            // 
            this.iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteraciones.Location = new System.Drawing.Point(677, 18);
            this.iteraciones.Name = "iteraciones";
            this.iteraciones.Size = new System.Drawing.Size(116, 26);
            this.iteraciones.TabIndex = 5;
            this.iteraciones.Text = "100";
            this.iteraciones.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(821, 9);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(38, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "i:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // i
            // 
            this.i.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.Location = new System.Drawing.Point(865, 19);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(116, 26);
            this.i.TabIndex = 7;
            this.i.Text = "100";
            this.i.TextChanged += new System.EventHandler(this.i_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1005, 9);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(38, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "j:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // j
            // 
            this.j.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j.Location = new System.Drawing.Point(1049, 12);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(116, 26);
            this.j.TabIndex = 9;
            this.j.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(174, 64);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(111, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "P(Compra)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(430, 64);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(110, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "P(Entrega)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(709, 64);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(97, 40);
            this.label7.TabIndex = 12;
            this.label7.Text = "P(Retiro)";
            // 
            // txtProbCompra
            // 
            this.txtProbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProbCompra.Location = new System.Drawing.Point(291, 67);
            this.txtProbCompra.Name = "txtProbCompra";
            this.txtProbCompra.Size = new System.Drawing.Size(116, 26);
            this.txtProbCompra.TabIndex = 13;
            this.txtProbCompra.Text = "0,45";
            // 
            // txtProbEntrega
            // 
            this.txtProbEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProbEntrega.Location = new System.Drawing.Point(546, 67);
            this.txtProbEntrega.Name = "txtProbEntrega";
            this.txtProbEntrega.Size = new System.Drawing.Size(125, 26);
            this.txtProbEntrega.TabIndex = 14;
            this.txtProbEntrega.Text = "0,25";
            // 
            // txtProbRetiro
            // 
            this.txtProbRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProbRetiro.Location = new System.Drawing.Point(812, 67);
            this.txtProbRetiro.Name = "txtProbRetiro";
            this.txtProbRetiro.Size = new System.Drawing.Size(116, 26);
            this.txtProbRetiro.TabIndex = 15;
            this.txtProbRetiro.Text = "0,30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(614, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Probabilidad de que un cliente llegue a retirar un reloj y que el mismo no esté r" +
    "eparado:";
            // 
            // lblPNoReparado
            // 
            this.lblPNoReparado.AutoSize = true;
            this.lblPNoReparado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNoReparado.ForeColor = System.Drawing.Color.Red;
            this.lblPNoReparado.Location = new System.Drawing.Point(525, 627);
            this.lblPNoReparado.Name = "lblPNoReparado";
            this.lblPNoReparado.Size = new System.Drawing.Size(15, 16);
            this.lblPNoReparado.TabIndex = 17;
            this.lblPNoReparado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1382, 669);
            this.ControlBox = false;
            this.Controls.Add(this.lblPNoReparado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProbRetiro);
            this.Controls.Add(this.txtProbEntrega);
            this.Controls.Add(this.txtProbCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.j);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.i);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iteraciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.btnSimular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación de Relojería";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iteraciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox i;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox j;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProbCompra;
        private System.Windows.Forms.TextBox txtProbEntrega;
        private System.Windows.Forms.TextBox txtProbRetiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPNoReparado;
    }
}

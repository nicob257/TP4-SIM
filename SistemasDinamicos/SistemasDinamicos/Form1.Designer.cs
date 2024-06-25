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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLiLleg = new System.Windows.Forms.TextBox();
            this.txtLiRep = new System.Windows.Forms.TextBox();
            this.txtLiCp = new System.Windows.Forms.TextBox();
            this.txtLsCp = new System.Windows.Forms.TextBox();
            this.txtLsRep = new System.Windows.Forms.TextBox();
            this.txtLsLleg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ocupAy = new System.Windows.Forms.Label();
            this.ocupRel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTmpOrden = new System.Windows.Forms.TextBox();
            this.txtLsInsp = new System.Windows.Forms.TextBox();
            this.txtLiInsp = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtHRK = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRk3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRk2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRk1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.dgvRK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.AutoSize = true;
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(12, 44);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(102, 40);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dataGridViewResultados
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewResultados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(15, 177);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowHeadersWidth = 51;
            this.dataGridViewResultados.Size = new System.Drawing.Size(969, 496);
            this.dataGridViewResultados.TabIndex = 1;
            this.dataGridViewResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(123, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad Tiempo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tiempo
            // 
            this.tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(273, 11);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(123, 47);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(166, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad Iteraciones:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iteraciones
            // 
            this.iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteraciones.Location = new System.Drawing.Point(316, 55);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(123, 88);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(35, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "i:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // i
            // 
            this.i.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.Location = new System.Drawing.Point(167, 98);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(307, 88);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(35, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "j:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // j
            // 
            this.j.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j.Location = new System.Drawing.Point(351, 97);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(116, 26);
            this.j.TabIndex = 9;
            this.j.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(485, 3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(102, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "P(Compra)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(486, 47);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(99, 38);
            this.label6.TabIndex = 11;
            this.label6.Text = "P(Entrega)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(485, 90);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(88, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "P(Retiro)";
            // 
            // txtProbCompra
            // 
            this.txtProbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProbCompra.Location = new System.Drawing.Point(602, 9);
            this.txtProbCompra.Name = "txtProbCompra";
            this.txtProbCompra.Size = new System.Drawing.Size(116, 26);
            this.txtProbCompra.TabIndex = 13;
            this.txtProbCompra.Text = "0,45";
            // 
            // txtProbEntrega
            // 
            this.txtProbEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProbEntrega.Location = new System.Drawing.Point(602, 54);
            this.txtProbEntrega.Name = "txtProbEntrega";
            this.txtProbEntrega.Size = new System.Drawing.Size(125, 26);
            this.txtProbEntrega.TabIndex = 14;
            this.txtProbEntrega.Text = "0,25";
            // 
            // txtProbRetiro
            // 
            this.txtProbRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProbRetiro.Location = new System.Drawing.Point(602, 97);
            this.txtProbRetiro.Name = "txtProbRetiro";
            this.txtProbRetiro.Size = new System.Drawing.Size(116, 26);
            this.txtProbRetiro.TabIndex = 15;
            this.txtProbRetiro.Text = "0,30";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 130);
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
            this.lblPNoReparado.Location = new System.Drawing.Point(523, 130);
            this.lblPNoReparado.Name = "lblPNoReparado";
            this.lblPNoReparado.Size = new System.Drawing.Size(15, 16);
            this.lblPNoReparado.TabIndex = 17;
            this.lblPNoReparado.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(773, 3);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10);
            this.label9.Size = new System.Drawing.Size(89, 38);
            this.label9.TabIndex = 18;
            this.label9.Text = "LI llegada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1022, 3);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10);
            this.label10.Size = new System.Drawing.Size(96, 38);
            this.label10.TabIndex = 19;
            this.label10.Text = "LS llegada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(772, 90);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10);
            this.label11.Size = new System.Drawing.Size(119, 38);
            this.label11.TabIndex = 20;
            this.label11.Text = "LI Reparacion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(773, 46);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10);
            this.label12.Size = new System.Drawing.Size(97, 38);
            this.label12.TabIndex = 21;
            this.label12.Text = "LI Compra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(1022, 46);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10);
            this.label13.Size = new System.Drawing.Size(104, 38);
            this.label13.TabIndex = 22;
            this.label13.Text = "LS Compra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(1021, 90);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(10);
            this.label14.Size = new System.Drawing.Size(126, 38);
            this.label14.TabIndex = 23;
            this.label14.Text = "LS Reparacion";
            // 
            // txtLiLleg
            // 
            this.txtLiLleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiLleg.Location = new System.Drawing.Point(868, 9);
            this.txtLiLleg.Name = "txtLiLleg";
            this.txtLiLleg.Size = new System.Drawing.Size(116, 26);
            this.txtLiLleg.TabIndex = 24;
            this.txtLiLleg.Text = "13";
            // 
            // txtLiRep
            // 
            this.txtLiRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiRep.Location = new System.Drawing.Point(897, 95);
            this.txtLiRep.Name = "txtLiRep";
            this.txtLiRep.Size = new System.Drawing.Size(116, 26);
            this.txtLiRep.TabIndex = 25;
            this.txtLiRep.Text = "18";
            // 
            // txtLiCp
            // 
            this.txtLiCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiCp.Location = new System.Drawing.Point(879, 54);
            this.txtLiCp.Name = "txtLiCp";
            this.txtLiCp.Size = new System.Drawing.Size(116, 26);
            this.txtLiCp.TabIndex = 26;
            this.txtLiCp.Text = "6";
            // 
            // txtLsCp
            // 
            this.txtLsCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLsCp.Location = new System.Drawing.Point(1135, 50);
            this.txtLsCp.Name = "txtLsCp";
            this.txtLsCp.Size = new System.Drawing.Size(64, 26);
            this.txtLsCp.TabIndex = 29;
            this.txtLsCp.Text = "10";
            // 
            // txtLsRep
            // 
            this.txtLsRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLsRep.Location = new System.Drawing.Point(1153, 94);
            this.txtLsRep.Name = "txtLsRep";
            this.txtLsRep.Size = new System.Drawing.Size(57, 26);
            this.txtLsRep.TabIndex = 28;
            this.txtLsRep.Text = "22";
            // 
            // txtLsLleg
            // 
            this.txtLsLleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLsLleg.Location = new System.Drawing.Point(1124, 7);
            this.txtLsLleg.Name = "txtLsLleg";
            this.txtLsLleg.Size = new System.Drawing.Size(48, 26);
            this.txtLsLleg.TabIndex = 27;
            this.txtLsLleg.Text = "17";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "% Ocup. Ayudante: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(368, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "% Ocup. Relojero:";
            // 
            // ocupAy
            // 
            this.ocupAy.AutoSize = true;
            this.ocupAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocupAy.ForeColor = System.Drawing.Color.Red;
            this.ocupAy.Location = new System.Drawing.Point(168, 153);
            this.ocupAy.Name = "ocupAy";
            this.ocupAy.Size = new System.Drawing.Size(15, 16);
            this.ocupAy.TabIndex = 32;
            this.ocupAy.Text = "0";
            // 
            // ocupRel
            // 
            this.ocupRel.AutoSize = true;
            this.ocupRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocupRel.ForeColor = System.Drawing.Color.Red;
            this.ocupRel.Location = new System.Drawing.Point(524, 153);
            this.ocupRel.Name = "ocupRel";
            this.ocupRel.Size = new System.Drawing.Size(15, 16);
            this.ocupRel.TabIndex = 33;
            this.ocupRel.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(1245, 17);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(109, 24);
            this.label17.TabIndex = 34;
            this.label17.Text = "Tiempo Orden";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtTmpOrden
            // 
            this.txtTmpOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTmpOrden.Location = new System.Drawing.Point(1246, 42);
            this.txtTmpOrden.Name = "txtTmpOrden";
            this.txtTmpOrden.Size = new System.Drawing.Size(108, 26);
            this.txtTmpOrden.TabIndex = 35;
            this.txtTmpOrden.Text = "5";
            // 
            // txtLsInsp
            // 
            this.txtLsInsp.Location = new System.Drawing.Point(1244, 152);
            this.txtLsInsp.Name = "txtLsInsp";
            this.txtLsInsp.Size = new System.Drawing.Size(69, 22);
            this.txtLsInsp.TabIndex = 65;
            this.txtLsInsp.Text = "100";
            // 
            // txtLiInsp
            // 
            this.txtLiInsp.Location = new System.Drawing.Point(1122, 152);
            this.txtLiInsp.Name = "txtLiInsp";
            this.txtLiInsp.Size = new System.Drawing.Size(69, 22);
            this.txtLiInsp.TabIndex = 64;
            this.txtLiInsp.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.DarkBlue;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(1209, 151);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(3);
            this.label25.Size = new System.Drawing.Size(32, 24);
            this.label25.TabIndex = 63;
            this.label25.Text = "LS";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.DarkBlue;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(1091, 150);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(3);
            this.label23.Size = new System.Drawing.Size(25, 24);
            this.label23.TabIndex = 62;
            this.label23.Text = "LI";
            // 
            // txtHRK
            // 
            this.txtHRK.Location = new System.Drawing.Point(777, 151);
            this.txtHRK.Name = "txtHRK";
            this.txtHRK.Size = new System.Drawing.Size(30, 22);
            this.txtHRK.TabIndex = 61;
            this.txtHRK.Text = "0,1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Green;
            this.label24.Location = new System.Drawing.Point(752, 153);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 16);
            this.label24.TabIndex = 60;
            this.label24.Text = "h:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(1091, 132);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(222, 16);
            this.label22.TabIndex = 59;
            this.label22.Text = "Distribución Prof. Inspección (I)";
            // 
            // txtRk3
            // 
            this.txtRk3.Location = new System.Drawing.Point(998, 130);
            this.txtRk3.Name = "txtRk3";
            this.txtRk3.Size = new System.Drawing.Size(22, 22);
            this.txtRk3.TabIndex = 58;
            this.txtRk3.Text = "2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(961, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 20);
            this.label21.TabIndex = 57;
            this.label21.Text = "+ ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(941, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 15);
            this.label20.TabIndex = 56;
            this.label20.Text = "2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(929, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 20);
            this.label19.TabIndex = 55;
            this.label19.Text = ")";
            // 
            // txtRk2
            // 
            this.txtRk2.Location = new System.Drawing.Point(893, 130);
            this.txtRk2.Name = "txtRk2";
            this.txtRk2.Size = new System.Drawing.Size(30, 22);
            this.txtRk2.TabIndex = 54;
            this.txtRk2.Text = "0,5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(858, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "(t + ";
            // 
            // txtRk1
            // 
            this.txtRk1.Location = new System.Drawing.Point(845, 130);
            this.txtRk1.Name = "txtRk1";
            this.txtRk1.Size = new System.Drawing.Size(22, 22);
            this.txtRk1.TabIndex = 52;
            this.txtRk1.Text = "3";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(676, 130);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(152, 16);
            this.label26.TabIndex = 51;
            this.label26.Text = "Función Runge Kutta:";
            // 
            // dgvRK
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRK.Location = new System.Drawing.Point(990, 178);
            this.dgvRK.Name = "dgvRK";
            this.dgvRK.RowHeadersWidth = 51;
            this.dgvRK.Size = new System.Drawing.Size(388, 495);
            this.dgvRK.TabIndex = 66;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1382, 669);
            this.Controls.Add(this.dgvRK);
            this.Controls.Add(this.txtLsInsp);
            this.Controls.Add(this.txtLiInsp);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtHRK);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtRk3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtRk2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtRk1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtTmpOrden);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ocupRel);
            this.Controls.Add(this.ocupAy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLsCp);
            this.Controls.Add(this.txtLsRep);
            this.Controls.Add(this.txtLsLleg);
            this.Controls.Add(this.txtLiCp);
            this.Controls.Add(this.txtLiRep);
            this.Controls.Add(this.txtLiLleg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLiLleg;
        private System.Windows.Forms.TextBox txtLiRep;
        private System.Windows.Forms.TextBox txtLiCp;
        private System.Windows.Forms.TextBox txtLsCp;
        private System.Windows.Forms.TextBox txtLsRep;
        private System.Windows.Forms.TextBox txtLsLleg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label ocupAy;
        private System.Windows.Forms.Label ocupRel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTmpOrden;
        private System.Windows.Forms.TextBox txtLsInsp;
        private System.Windows.Forms.TextBox txtLiInsp;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtHRK;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtRk3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtRk2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRk1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dgvRK;
    }
}

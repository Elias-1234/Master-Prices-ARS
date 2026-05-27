namespace POS_PROYECT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvVentas = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            tableLayoutPanel7 = new TableLayoutPanel();
            button25 = new Button();
            button24 = new Button();
            lblTotal = new Button();
            button20 = new Button();
            lblUnidades = new Button();
            button18 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtMultiplicador = new TextBox();
            txtVCodigoBarra = new TextBox();
            pictureBox2 = new PictureBox();
            tabPage4 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            pcbImagenProducto = new PictureBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button22 = new Button();
            button23 = new Button();
            button26 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label7 = new Label();
            txtReferencia = new TextBox();
            label8 = new Label();
            txtCodigoBarra = new TextBox();
            label9 = new Label();
            txtNombre = new TextBox();
            label10 = new Label();
            txtCosto = new TextBox();
            label11 = new Label();
            txtPrecio = new TextBox();
            label12 = new Label();
            txtStock = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            dgvTablaProductos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            tableLayoutPanel11 = new TableLayoutPanel();
            label5 = new Label();
            txtBuscarProducto = new TextBox();
            txtFiltrarProducto = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            tableLayoutPanel12 = new TableLayoutPanel();
            tableLayoutPanel13 = new TableLayoutPanel();
            button1 = new Button();
            button28 = new Button();
            button21 = new Button();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            button27 = new Button();
            tcReportes = new TabControl();
            tabPage5 = new TabPage();
            tabPage2 = new TabPage();
            dgvTablaProductosMasVendido = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImagenProducto).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaProductos).BeginInit();
            tableLayoutPanel11.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tcReportes.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaProductosMasVendido).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1220, 774);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PaleTurquoise;
            tabPage1.Controls.Add(tableLayoutPanel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1212, 746);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ventas";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 392F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1206, 740);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(dgvVentas, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 83.016304F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.983696F));
            tableLayoutPanel4.Size = new Size(808, 734);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.BackgroundColor = SystemColors.InactiveBorder;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column1 });
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(3, 3);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 30;
            dgvVentas.RowTemplate.Height = 50;
            dgvVentas.Size = new Size(802, 603);
            dgvVentas.TabIndex = 0;
            // 
            // Column7
            // 
            Column7.HeaderText = "Cantidad";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Producto";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Precio";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "productoId";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.DarkCyan;
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel7.Controls.Add(button25, 3, 1);
            tableLayoutPanel7.Controls.Add(button24, 2, 1);
            tableLayoutPanel7.Controls.Add(lblTotal, 3, 0);
            tableLayoutPanel7.Controls.Add(button20, 2, 0);
            tableLayoutPanel7.Controls.Add(lblUnidades, 1, 0);
            tableLayoutPanel7.Controls.Add(button18, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 612);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(802, 119);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // button25
            // 
            button25.BackColor = Color.White;
            button25.Dock = DockStyle.Fill;
            button25.Enabled = false;
            button25.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            button25.ForeColor = Color.Black;
            button25.Location = new Point(605, 62);
            button25.Name = "button25";
            button25.Size = new Size(194, 54);
            button25.TabIndex = 7;
            button25.Text = "$";
            button25.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = Color.White;
            button24.Dock = DockStyle.Fill;
            button24.Enabled = false;
            button24.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            button24.ForeColor = Color.Black;
            button24.Location = new Point(405, 62);
            button24.Name = "button24";
            button24.Size = new Size(194, 54);
            button24.TabIndex = 6;
            button24.Text = "Cambio:";
            button24.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Enabled = false;
            lblTotal.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(605, 3);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(194, 53);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "$";
            lblTotal.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.White;
            button20.Dock = DockStyle.Fill;
            button20.Enabled = false;
            button20.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            button20.ForeColor = Color.Black;
            button20.Location = new Point(405, 3);
            button20.Name = "button20";
            button20.Size = new Size(194, 53);
            button20.TabIndex = 2;
            button20.Text = "Total:";
            button20.UseVisualStyleBackColor = false;
            // 
            // lblUnidades
            // 
            lblUnidades.BackColor = Color.White;
            lblUnidades.Dock = DockStyle.Fill;
            lblUnidades.Enabled = false;
            lblUnidades.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblUnidades.ForeColor = Color.Black;
            lblUnidades.Location = new Point(205, 3);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(194, 53);
            lblUnidades.TabIndex = 1;
            lblUnidades.Text = "0";
            lblUnidades.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = Color.White;
            button18.Dock = DockStyle.Right;
            button18.Enabled = false;
            button18.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button18.ForeColor = Color.Black;
            button18.Location = new Point(56, 3);
            button18.Name = "button18";
            button18.Size = new Size(143, 53);
            button18.TabIndex = 0;
            button18.Text = "Unidades:";
            button18.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.DarkCyan;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(817, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 43.3518F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 56.6482F));
            tableLayoutPanel5.Size = new Size(386, 734);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(button4);
            flowLayoutPanel3.Controls.Add(button5);
            flowLayoutPanel3.Controls.Add(button6);
            flowLayoutPanel3.Controls.Add(button7);
            flowLayoutPanel3.Controls.Add(button8);
            flowLayoutPanel3.Controls.Add(button9);
            flowLayoutPanel3.Controls.Add(button10);
            flowLayoutPanel3.Controls.Add(button11);
            flowLayoutPanel3.Controls.Add(button12);
            flowLayoutPanel3.Controls.Add(button13);
            flowLayoutPanel3.Controls.Add(button14);
            flowLayoutPanel3.Controls.Add(button15);
            flowLayoutPanel3.Controls.Add(button16);
            flowLayoutPanel3.Controls.Add(button17);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 321);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(380, 410);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = Properties.Resources._3807871__1_;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(120, 61);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnEliminarProducto;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(129, 3);
            button5.Name = "button5";
            button5.Size = new Size(246, 61);
            button5.TabIndex = 1;
            button5.Text = "CE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += CEClick;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(3, 70);
            button6.MaximumSize = new Size(120, 80);
            button6.MinimumSize = new Size(60, 40);
            button6.Name = "button6";
            button6.Size = new Size(120, 80);
            button6.TabIndex = 2;
            button6.Text = "7";
            button6.UseVisualStyleBackColor = false;
            button6.Click += BotonNumerico_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(129, 70);
            button7.MaximumSize = new Size(120, 80);
            button7.MinimumSize = new Size(60, 40);
            button7.Name = "button7";
            button7.Size = new Size(120, 80);
            button7.TabIndex = 3;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = false;
            button7.Click += BotonNumerico_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(255, 70);
            button8.MaximumSize = new Size(120, 80);
            button8.MinimumSize = new Size(60, 40);
            button8.Name = "button8";
            button8.Size = new Size(120, 80);
            button8.TabIndex = 4;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = false;
            button8.Click += BotonNumerico_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(3, 156);
            button9.MaximumSize = new Size(120, 80);
            button9.MinimumSize = new Size(60, 40);
            button9.Name = "button9";
            button9.Size = new Size(120, 80);
            button9.TabIndex = 5;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = false;
            button9.Click += BotonNumerico_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(129, 156);
            button10.MaximumSize = new Size(120, 80);
            button10.MinimumSize = new Size(60, 40);
            button10.Name = "button10";
            button10.Size = new Size(120, 80);
            button10.TabIndex = 6;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += BotonNumerico_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(255, 156);
            button11.MaximumSize = new Size(120, 80);
            button11.MinimumSize = new Size(60, 40);
            button11.Name = "button11";
            button11.Size = new Size(120, 80);
            button11.TabIndex = 7;
            button11.Text = "6";
            button11.UseVisualStyleBackColor = false;
            button11.Click += BotonNumerico_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(3, 242);
            button12.MaximumSize = new Size(120, 80);
            button12.MinimumSize = new Size(60, 40);
            button12.Name = "button12";
            button12.Size = new Size(120, 80);
            button12.TabIndex = 8;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = false;
            button12.Click += BotonNumerico_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.White;
            button13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(129, 242);
            button13.MaximumSize = new Size(120, 80);
            button13.MinimumSize = new Size(60, 40);
            button13.Name = "button13";
            button13.Size = new Size(120, 80);
            button13.TabIndex = 9;
            button13.Text = "2";
            button13.UseVisualStyleBackColor = false;
            button13.Click += BotonNumerico_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.White;
            button14.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button14.ForeColor = Color.Black;
            button14.Location = new Point(255, 242);
            button14.MaximumSize = new Size(120, 80);
            button14.MinimumSize = new Size(60, 40);
            button14.Name = "button14";
            button14.Size = new Size(120, 80);
            button14.TabIndex = 10;
            button14.Text = "3";
            button14.UseVisualStyleBackColor = false;
            button14.Click += BotonNumerico_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button15.ForeColor = Color.Black;
            button15.Location = new Point(3, 328);
            button15.Name = "button15";
            button15.Size = new Size(120, 60);
            button15.TabIndex = 11;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = false;
            button15.Click += BotonNumerico_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.White;
            button16.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button16.ForeColor = Color.Black;
            button16.Location = new Point(129, 328);
            button16.Name = "button16";
            button16.Size = new Size(120, 60);
            button16.TabIndex = 12;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = false;
            button16.Click += MultiplicarClick;
            // 
            // button17
            // 
            button17.BackColor = Color.White;
            button17.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            button17.ForeColor = Color.Black;
            button17.Location = new Point(255, 328);
            button17.Name = "button17";
            button17.Size = new Size(120, 60);
            button17.TabIndex = 13;
            button17.Text = "=";
            button17.TextAlign = ContentAlignment.TopCenter;
            button17.UseVisualStyleBackColor = false;
            button17.Click += btnIgualOTraerProducto;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8453617F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.15464F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel6.Controls.Add(txtMultiplicador, 2, 0);
            tableLayoutPanel6.Controls.Add(txtVCodigoBarra, 1, 0);
            tableLayoutPanel6.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Bottom;
            tableLayoutPanel6.Location = new Point(3, 263);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(380, 52);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // txtMultiplicador
            // 
            txtMultiplicador.Dock = DockStyle.Fill;
            txtMultiplicador.Font = new Font("Segoe UI", 21F);
            txtMultiplicador.Location = new Point(326, 3);
            txtMultiplicador.Name = "txtMultiplicador";
            txtMultiplicador.Size = new Size(51, 45);
            txtMultiplicador.TabIndex = 3;
            // 
            // txtVCodigoBarra
            // 
            txtVCodigoBarra.Dock = DockStyle.Fill;
            txtVCodigoBarra.Font = new Font("Segoe UI", 21F);
            txtVCodigoBarra.Location = new Point(67, 3);
            txtVCodigoBarra.Name = "txtVCodigoBarra";
            txtVCodigoBarra.Size = new Size(253, 45);
            txtVCodigoBarra.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MintCream;
            pictureBox2.BackgroundImage = Properties.Resources._726558;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 46);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel8);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1212, 746);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Productos";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1206, 740);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.BackColor = Color.LightSeaGreen;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(pcbImagenProducto, 0, 0);
            tableLayoutPanel9.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanel9.Controls.Add(flowLayoutPanel5, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8738575F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 73.1261444F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel9.Size = new Size(254, 734);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // pcbImagenProducto
            // 
            pcbImagenProducto.BackColor = Color.Teal;
            pcbImagenProducto.BackgroundImage = Properties.Resources.photo_1103594_1280;
            pcbImagenProducto.BackgroundImageLayout = ImageLayout.Zoom;
            pcbImagenProducto.Dock = DockStyle.Fill;
            pcbImagenProducto.Location = new Point(3, 3);
            pcbImagenProducto.Name = "pcbImagenProducto";
            pcbImagenProducto.Size = new Size(248, 170);
            pcbImagenProducto.TabIndex = 0;
            pcbImagenProducto.TabStop = false;
            pcbImagenProducto.Click += pictureBox3_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button22);
            flowLayoutPanel4.Controls.Add(button23);
            flowLayoutPanel4.Controls.Add(button26);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 660);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(248, 71);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // button22
            // 
            button22.BackColor = Color.White;
            button22.BackgroundImage = Properties.Resources._5610959;
            button22.BackgroundImageLayout = ImageLayout.Zoom;
            button22.Location = new Point(3, 3);
            button22.Name = "button22";
            button22.Size = new Size(75, 68);
            button22.TabIndex = 0;
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.Transparent;
            button23.BackgroundImage = Properties.Resources._5935145;
            button23.BackgroundImageLayout = ImageLayout.Zoom;
            button23.Location = new Point(84, 3);
            button23.Name = "button23";
            button23.Size = new Size(75, 68);
            button23.TabIndex = 1;
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.Transparent;
            button26.BackgroundImage = Properties.Resources._3807871;
            button26.BackgroundImageLayout = ImageLayout.Zoom;
            button26.Location = new Point(165, 3);
            button26.Name = "button26";
            button26.Size = new Size(75, 68);
            button26.TabIndex = 2;
            button26.UseVisualStyleBackColor = false;
            button26.Click += button26_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.Teal;
            flowLayoutPanel5.Controls.Add(label7);
            flowLayoutPanel5.Controls.Add(txtReferencia);
            flowLayoutPanel5.Controls.Add(label8);
            flowLayoutPanel5.Controls.Add(txtCodigoBarra);
            flowLayoutPanel5.Controls.Add(label9);
            flowLayoutPanel5.Controls.Add(txtNombre);
            flowLayoutPanel5.Controls.Add(label10);
            flowLayoutPanel5.Controls.Add(txtCosto);
            flowLayoutPanel5.Controls.Add(label11);
            flowLayoutPanel5.Controls.Add(txtPrecio);
            flowLayoutPanel5.Controls.Add(label12);
            flowLayoutPanel5.Controls.Add(txtStock);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(3, 179);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(248, 475);
            flowLayoutPanel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(125, 32);
            label7.TabIndex = 0;
            label7.Text = "Referencia";
            // 
            // txtReferencia
            // 
            txtReferencia.Font = new Font("Segoe UI", 18F);
            txtReferencia.Location = new Point(3, 35);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(237, 39);
            txtReferencia.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(3, 77);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 2;
            label8.Text = "Codigo Barra";
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Font = new Font("Segoe UI", 18F);
            txtCodigoBarra.Location = new Point(3, 112);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(237, 39);
            txtCodigoBarra.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(3, 154);
            label9.Name = "label9";
            label9.Size = new Size(102, 32);
            label9.TabIndex = 4;
            label9.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 18F);
            txtNombre.Location = new Point(3, 189);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 39);
            txtNombre.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(3, 231);
            label10.Name = "label10";
            label10.Size = new Size(75, 32);
            label10.TabIndex = 6;
            label10.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Segoe UI", 18F);
            txtCosto.Location = new Point(3, 266);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(237, 39);
            txtCosto.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(3, 308);
            label11.Name = "label11";
            label11.Size = new Size(79, 32);
            label11.TabIndex = 8;
            label11.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 18F);
            txtPrecio.Location = new Point(3, 343);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(237, 39);
            txtPrecio.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(3, 385);
            label12.Name = "label12";
            label12.Size = new Size(71, 32);
            label12.TabIndex = 10;
            label12.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 18F);
            txtStock.Location = new Point(3, 420);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(237, 39);
            txtStock.TabIndex = 11;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(dgvTablaProductos, 0, 1);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(263, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4774532F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 89.5225449F));
            tableLayoutPanel10.Size = new Size(940, 734);
            tableLayoutPanel10.TabIndex = 2;
            // 
            // dgvTablaProductos
            // 
            dgvTablaProductos.AllowUserToAddRows = false;
            dgvTablaProductos.AllowUserToDeleteRows = false;
            dgvTablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaProductos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvTablaProductos.Dock = DockStyle.Fill;
            dgvTablaProductos.Location = new Point(3, 79);
            dgvTablaProductos.Name = "dgvTablaProductos";
            dgvTablaProductos.ReadOnly = true;
            dgvTablaProductos.Size = new Size(934, 652);
            dgvTablaProductos.TabIndex = 4;
            dgvTablaProductos.CellClick += dgvTablaProductos_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Referencia";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Codigo Barra";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Costo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Precio";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Stock";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2540016F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.7459946F));
            tableLayoutPanel11.Controls.Add(label5, 0, 1);
            tableLayoutPanel11.Controls.Add(txtBuscarProducto, 1, 0);
            tableLayoutPanel11.Controls.Add(txtFiltrarProducto, 1, 1);
            tableLayoutPanel11.Controls.Add(label4, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(934, 70);
            tableLayoutPanel11.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(40, 41);
            label5.Margin = new Padding(40, 6, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(172, 25);
            label5.TabIndex = 3;
            label5.Text = "Filtrar Por Nombre:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Dock = DockStyle.Fill;
            txtBuscarProducto.Font = new Font("Segoe UI", 14.25F);
            txtBuscarProducto.Location = new Point(248, 3);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(683, 33);
            txtBuscarProducto.TabIndex = 0;
            txtBuscarProducto.TextChanged += textBox2_TextChanged;
            // 
            // txtFiltrarProducto
            // 
            txtFiltrarProducto.Dock = DockStyle.Fill;
            txtFiltrarProducto.Font = new Font("Segoe UI", 14.25F);
            txtFiltrarProducto.Location = new Point(248, 38);
            txtFiltrarProducto.Name = "txtFiltrarProducto";
            txtFiltrarProducto.Size = new Size(683, 33);
            txtFiltrarProducto.TabIndex = 1;
            txtFiltrarProducto.TextChanged += txtFiltrarProducto_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(40, 6);
            label4.Margin = new Padding(40, 6, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Codigo Barra:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel12);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1212, 746);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Consultar Ventas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.BackColor = Color.Teal;
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel12.Controls.Add(tcReportes, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel12.Size = new Size(1206, 740);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 7;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 336F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(button1, 5, 0);
            tableLayoutPanel13.Controls.Add(button28, 2, 0);
            tableLayoutPanel13.Controls.Add(button21, 0, 0);
            tableLayoutPanel13.Controls.Add(dtpFechaInicio, 1, 0);
            tableLayoutPanel13.Controls.Add(dtpFechaFin, 3, 0);
            tableLayoutPanel13.Controls.Add(button27, 4, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(1200, 74);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1028, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 68);
            button1.TabIndex = 7;
            button1.Text = "Filtrar Productos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button28
            // 
            button28.BackColor = Color.White;
            button28.Dock = DockStyle.Fill;
            button28.Enabled = false;
            button28.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button28.Location = new Point(510, 3);
            button28.Name = "button28";
            button28.Size = new Size(107, 68);
            button28.TabIndex = 2;
            button28.Text = "FECHA FIN:";
            button28.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.White;
            button21.Dock = DockStyle.Fill;
            button21.Enabled = false;
            button21.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button21.Location = new Point(3, 3);
            button21.Name = "button21";
            button21.Size = new Size(165, 68);
            button21.TabIndex = 0;
            button21.Text = "FECHA INICIO:";
            button21.UseVisualStyleBackColor = false;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "YYYY/MM/DD HH:MM:SS";
            dtpFechaInicio.Dock = DockStyle.Fill;
            dtpFechaInicio.Location = new Point(174, 3);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(330, 23);
            dtpFechaInicio.TabIndex = 4;
            dtpFechaInicio.Value = new DateTime(2026, 5, 26, 3, 14, 31, 0);
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Dock = DockStyle.Fill;
            dtpFechaFin.Location = new Point(623, 3);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(275, 23);
            dtpFechaFin.TabIndex = 5;
            // 
            // button27
            // 
            button27.BackColor = Color.White;
            button27.Dock = DockStyle.Fill;
            button27.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button27.Location = new Point(904, 3);
            button27.Name = "button27";
            button27.Size = new Size(118, 68);
            button27.TabIndex = 6;
            button27.Text = "Filtrar Ventas";
            button27.UseVisualStyleBackColor = false;
            button27.Click += button27_Click;
            // 
            // tcReportes
            // 
            tcReportes.Controls.Add(tabPage5);
            tcReportes.Controls.Add(tabPage2);
            tcReportes.Dock = DockStyle.Fill;
            tcReportes.Location = new Point(3, 83);
            tcReportes.Name = "tcReportes";
            tcReportes.SelectedIndex = 0;
            tcReportes.Size = new Size(1200, 654);
            tcReportes.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.LightSeaGreen;
            tabPage5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1192, 626);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "INFORME DE VENTAS";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvTablaProductosMasVendido);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1192, 626);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "PRODUCTOS MAS VENDIDOS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTablaProductosMasVendido
            // 
            dgvTablaProductosMasVendido.AllowUserToAddRows = false;
            dgvTablaProductosMasVendido.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTablaProductosMasVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaProductosMasVendido.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3 });
            dgvTablaProductosMasVendido.Dock = DockStyle.Fill;
            dgvTablaProductosMasVendido.Location = new Point(3, 3);
            dgvTablaProductosMasVendido.Name = "dgvTablaProductosMasVendido";
            dgvTablaProductosMasVendido.ReadOnly = true;
            dgvTablaProductosMasVendido.Size = new Size(1186, 620);
            dgvTablaProductosMasVendido.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Productos";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1220, 774);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "MASTER PRICE";
            KeyDown += Form1_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage4.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImagenProducto).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTablaProductos).EndInit();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tcReportes.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTablaProductosMasVendido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private TableLayoutPanel tableLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtVCodigoBarra;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button24;
        private Button lblTotal;
        private Button button20;
        private Button lblUnidades;
        private Button button18;
        private Button button25;
        private TextBox txtMultiplicador;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private PictureBox pcbImagenProducto;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button22;
        private Button button23;
        private Button button26;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label7;
        private TextBox txtReferencia;
        private Label label8;
        private TextBox txtCodigoBarra;
        private Label label9;
        private TextBox txtNombre;
        private Label label10;
        private TextBox txtCosto;
        private Label label11;
        private TextBox txtPrecio;
        private Label label12;
        private TextBox txtStock;
        private TableLayoutPanel tableLayoutPanel10;
        private DataGridView dgvTablaProductos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label5;
        private TextBox txtBuscarProducto;
        private TextBox txtFiltrarProducto;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel13;
        private Button button21;
        private TabControl tcReportes;
        private TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button button28;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Button button27;
        private TabPage tabPage2;
        private DataGridView dgvTablaProductosMasVendido;
        private Button button1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}

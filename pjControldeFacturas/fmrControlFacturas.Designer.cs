namespace pjControldeFacturas
{
    partial class fmrControlFacturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtNumFac = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnNuevaFac = new System.Windows.Forms.Button();
            this.btnRegistarItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvReguistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMontos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de registro de facturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del vendedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(578, 95);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnidades);
            this.groupBox1.Controls.Add(this.txtNumFac);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.btnNuevaFac);
            this.groupBox1.Controls.Add(this.btnRegistarItem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(30, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de facturas";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(363, 49);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 23);
            this.txtUnidades.TabIndex = 7;
            // 
            // txtNumFac
            // 
            this.txtNumFac.Location = new System.Drawing.Point(37, 49);
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(100, 23);
            this.txtNumFac.TabIndex = 6;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Cobre",
            "Bronce",
            "Silver",
            "Gold"});
            this.cboTipo.Location = new System.Drawing.Point(181, 49);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(154, 23);
            this.cboTipo.TabIndex = 5;
            this.cboTipo.Text = "(Seleccione licencia)";
            // 
            // btnNuevaFac
            // 
            this.btnNuevaFac.Location = new System.Drawing.Point(575, 59);
            this.btnNuevaFac.Name = "btnNuevaFac";
            this.btnNuevaFac.Size = new System.Drawing.Size(121, 23);
            this.btnNuevaFac.TabIndex = 4;
            this.btnNuevaFac.Text = "Otra Factura";
            this.btnNuevaFac.UseVisualStyleBackColor = true;
            this.btnNuevaFac.Click += new System.EventHandler(this.btnNuevaFac_Click);
            // 
            // btnRegistarItem
            // 
            this.btnRegistarItem.Location = new System.Drawing.Point(575, 24);
            this.btnRegistarItem.Name = "btnRegistarItem";
            this.btnRegistarItem.Size = new System.Drawing.Size(121, 23);
            this.btnRegistarItem.TabIndex = 3;
            this.btnRegistarItem.Text = "Registrar Item";
            this.btnRegistarItem.UseVisualStyleBackColor = true;
            this.btnRegistarItem.Click += new System.EventHandler(this.btnRegistarItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Unidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo de licencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "N° de Factura";
            // 
            // lvReguistro
            // 
            this.lvReguistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvReguistro.GridLines = true;
            this.lvReguistro.Location = new System.Drawing.Point(30, 251);
            this.lvReguistro.Name = "lvReguistro";
            this.lvReguistro.Size = new System.Drawing.Size(744, 80);
            this.lvReguistro.TabIndex = 5;
            this.lvReguistro.UseCompatibleStateImageBehavior = false;
            this.lvReguistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° Fact.";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo de licencia";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidades";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subtotal";
            this.columnHeader4.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Listado de registros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Estadisticas de venta";
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.Location = new System.Drawing.Point(30, 364);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(483, 112);
            this.lvEstadisticas.TabIndex = 8;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo de licencia";
            this.columnHeader5.Width = 240;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total unidades";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Montos total";
            this.columnHeader7.Width = 120;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(30, 75);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(502, 23);
            this.txtVendedor.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Monto Total";
            // 
            // lblMontos
            // 
            this.lblMontos.AutoSize = true;
            this.lblMontos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontos.Location = new System.Drawing.Point(647, 364);
            this.lblMontos.Name = "lblMontos";
            this.lblMontos.Size = new System.Drawing.Size(52, 17);
            this.lblMontos.TabIndex = 11;
            this.lblMontos.Text = "label11";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(699, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fmrControlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 488);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMontos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvReguistro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmrControlFacturas";
            this.Text = "Control de registro de facturas";
            this.Load += new System.EventHandler(this.fmrControlFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblFecha;
        private GroupBox groupBox1;
        private Button btnNuevaFac;
        private Button btnRegistarItem;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtUnidades;
        private TextBox txtNumFac;
        private ComboBox cboTipo;
        private ListView lvReguistro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label8;
        private Label label9;
        private ListView lvEstadisticas;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TextBox txtVendedor;
        private Label label10;
        private Label lblMontos;
        private Button btnSalir;
    }
}
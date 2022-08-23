namespace pjControldeFacturas
{
    
    public partial class fmrControlFacturas : Form
    {
        int i;
        public fmrControlFacturas()
        {
            InitializeComponent();
        }

        private void fmrControlFacturas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblMontos.Text=(0).ToString("C");
        }

        private void btnRegistarItem_Click(object sender, EventArgs e)
        {
            //Capturar Datos
            int numFact=int.Parse(txtNumFac.Text);
            String licencia= cboTipo.Text;
            int unidades= int.Parse(txtUnidades.Text);

            //Determinar el precio de las lincencias
            double precio = 0;

            switch (licencia)
            {
                case "Cobre": precio = 700; break;
                case "Bronce": precio = 900; break;
                case "Silver": precio = 1400; break;
                case "Gold": precio = 2500; break;
            }

                    //Calculando el subtotal
                    double subtotal = unidades * precio;

                    //Enviando la inf. a la lista 
                    ListViewItem fila= new ListViewItem(numFact.ToString());
                    fila.SubItems.Add(licencia);
                    fila.SubItems.Add(unidades.ToString());
                    fila.SubItems.Add(subtotal.ToString("0.00"));
                    lvReguistro.Items.Add(fila);

                    //Calculando el monto totasl acomulado
                    double mAcomulado = 0;
                    i = 0;
                    while(i< lvReguistro.Items.Count)
                    {
                        mAcomulado += double.Parse(lvReguistro.Items[i].SubItems[3].Text);
                            i++;
                    }
                    lblMontos.Text = mAcomulado.ToString("C");
            //Claculando las estadisticas
            int cCobre = 0, cBronce = 0, cSilver = 0, cGold = 0;
            double tCobre = 0, tBronce = 0, tSilver = 0, tGold = 0;

            i = 0;
            do
            {
                if(lvReguistro.Items[i].SubItems[1].Text== "Cobre")
                {
                    cCobre+= int.Parse(lvReguistro.Items[i].SubItems[2].Text);
                    tCobre += int.Parse(lvReguistro.Items[i].SubItems[3].Text);
                }
                if (lvReguistro.Items[i].SubItems[1].Text == "Bronce")
                {
                    cBronce += int.Parse(lvReguistro.Items[i].SubItems[2].Text);
                    tBronce += int.Parse(lvReguistro.Items[i].SubItems[3].Text);
                }
                if (lvReguistro.Items[i].SubItems[1].Text == "Silver")
                {
                    cSilver += int.Parse(lvReguistro.Items[i].SubItems[2].Text);
                    tSilver += int.Parse(lvReguistro.Items[i].SubItems[3].Text);
                }
                if (lvReguistro.Items[i].SubItems[1].Text == "Gold")
                {
                    cGold += int.Parse(lvReguistro.Items[i].SubItems[2].Text);
                    tGold += int.Parse(lvReguistro.Items[i].SubItems[3].Text);
                }

                i++;
            }while(i< lvReguistro.Items.Count);

            //Imprimeindo estadisticas
            lvEstadisticas.Items.Clear();

            string[] elemtosfila = new string[3];
            ListViewItem row;

            elemtosfila[0] = "Total Bronce";
            elemtosfila[1] = cBronce.ToString();
            elemtosfila[2] = tBronce.ToString();
            row = new ListViewItem(elemtosfila);
            lvEstadisticas.Items.Add(row);

            //2
            elemtosfila[0] = "Total cobre";
            elemtosfila[1] = cCobre.ToString();
            elemtosfila[2] =tCobre.ToString();
            row = new ListViewItem(elemtosfila);
            lvEstadisticas.Items.Add(row);

            //3
            elemtosfila[0] = "Total Silver";
            elemtosfila[1] = cSilver.ToString();
            elemtosfila[2] =tSilver.ToString();
            row = new ListViewItem(elemtosfila);
            lvEstadisticas.Items.Add(row);

            //4
            elemtosfila[0] = "Total Gold";
            elemtosfila[1] =cGold.ToString();
            elemtosfila[2] = tGold.ToString();
            row = new ListViewItem(elemtosfila);
            lvEstadisticas.Items.Add(row);

        }

        private void btnNuevaFac_Click(object sender, EventArgs e)
        {
            txtNumFac.Clear();
            txtUnidades.Clear();
            txtVendedor.Clear();
            cboTipo.Text = "Seleccione licencia";
            txtNumFac.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r= MessageBox.Show("Estas seguro de salir?", "Control de facturas",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r==DialogResult.Yes)
                this.Close();
        }
    }
}
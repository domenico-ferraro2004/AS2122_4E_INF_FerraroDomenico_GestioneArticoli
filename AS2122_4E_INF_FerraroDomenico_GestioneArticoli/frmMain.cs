namespace AS2122_4E_INF_FerraroDomenico_GestioneArticoli
{
    public partial class Form1 : Form
    {
        Dictionary<string, Articolo> dicArticoli = new Dictionary<string, Articolo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Articolo articolo = new Articolo(txtCodice.Text, txtDescrizione.Text, cmbUnitaMisura.Text, Convert.ToDouble(txtPrezzo.Text));
            
            if(dicArticoli.ContainsKey(txtCodice.Text))
            {
                dicArticoli[txtCodice.Text] = articolo;
            }
            else
            {
                dicArticoli.Add(txtCodice.Text, articolo);
            }


        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string, Articolo> in dicArticoli)
            {
                lstVisualizza.Items.Add();
            }
        }
    }
}
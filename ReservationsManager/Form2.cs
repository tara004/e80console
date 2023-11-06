using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationsManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cittaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cittaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.regioni'. È possibile spostarla o rimuoverla se necessario.
            this.regioniTableAdapter.Fill(this.prenotazioniDataSet.regioni);
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.citta'. È possibile spostarla o rimuoverla se necessario.
            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);

        }
    }
}

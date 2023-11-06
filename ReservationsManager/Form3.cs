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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void prenotazioniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prenotazioniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'prenotazioniDataSet.prenotazioni'. È possibile spostarla o rimuoverla se necessario.
            this.prenotazioniTableAdapter.Fill(this.prenotazioniDataSet.prenotazioni);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

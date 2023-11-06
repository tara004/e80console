namespace ReservationsManager
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cognomeLabel;
            System.Windows.Forms.Label dataNascitaLabel;
            System.Windows.Forms.Label cittaLabel;
            System.Windows.Forms.Label cittaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label regioneLabel;
            this.prenotazioniDataSet = new ReservationsManager.prenotazioniDataSet();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.clientiTableAdapter();
            this.tableAdapterManager = new ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
            this.cittaTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.cittaTableAdapter();
            this.prenotazioniTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.prenotazioniTableAdapter();
            this.clientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cognomeTextBox = new System.Windows.Forms.TextBox();
            this.dataNascitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cittaTextBox = new System.Windows.Forms.TextBox();
            this.cittaComboBox = new System.Windows.Forms.ComboBox();
            this.cittaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKprenotazioniclientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regioniTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.regioniTableAdapter();
            this.regioneComboBox = new System.Windows.Forms.ComboBox();
            nomeLabel = new System.Windows.Forms.Label();
            cognomeLabel = new System.Windows.Forms.Label();
            dataNascitaLabel = new System.Windows.Forms.Label();
            cittaLabel = new System.Windows.Forms.Label();
            cittaLabel1 = new System.Windows.Forms.Label();
            regioneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).BeginInit();
            this.clientiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprenotazioniclientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(87, 122);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "nome:";
            // 
            // cognomeLabel
            // 
            cognomeLabel.AutoSize = true;
            cognomeLabel.Location = new System.Drawing.Point(261, 125);
            cognomeLabel.Name = "cognomeLabel";
            cognomeLabel.Size = new System.Drawing.Size(67, 16);
            cognomeLabel.TabIndex = 3;
            cognomeLabel.Text = "cognome:";
            // 
            // dataNascitaLabel
            // 
            dataNascitaLabel.AutoSize = true;
            dataNascitaLabel.Location = new System.Drawing.Point(476, 128);
            dataNascitaLabel.Name = "dataNascitaLabel";
            dataNascitaLabel.Size = new System.Drawing.Size(86, 16);
            dataNascitaLabel.TabIndex = 5;
            dataNascitaLabel.Text = "data Nascita:";
            // 
            // cittaLabel
            // 
            cittaLabel.AutoSize = true;
            cittaLabel.Location = new System.Drawing.Point(87, 184);
            cittaLabel.Name = "cittaLabel";
            cittaLabel.Size = new System.Drawing.Size(34, 16);
            cittaLabel.TabIndex = 7;
            cittaLabel.Text = "citta:";
            // 
            // cittaLabel1
            // 
            cittaLabel1.AutoSize = true;
            cittaLabel1.Location = new System.Drawing.Point(261, 181);
            cittaLabel1.Name = "cittaLabel1";
            cittaLabel1.Size = new System.Drawing.Size(34, 16);
            cittaLabel1.TabIndex = 9;
            cittaLabel1.Text = "citta:";
            // 
            // prenotazioniDataSet
            // 
            this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
            this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "clienti";
            this.clientiBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cittaTableAdapter = this.cittaTableAdapter;
            this.tableAdapterManager.clientiTableAdapter = this.clientiTableAdapter;
            this.tableAdapterManager.prenotazioniTableAdapter = this.prenotazioniTableAdapter;
            this.tableAdapterManager.regioniTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cittaTableAdapter
            // 
            this.cittaTableAdapter.ClearBeforeFill = true;
            // 
            // prenotazioniTableAdapter
            // 
            this.prenotazioniTableAdapter.ClearBeforeFill = true;
            // 
            // clientiBindingNavigator
            // 
            this.clientiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientiBindingNavigator.BindingSource = this.clientiBindingSource;
            this.clientiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientiBindingNavigatorSaveItem});
            this.clientiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientiBindingNavigator.Name = "clientiBindingNavigator";
            this.clientiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientiBindingNavigator.Size = new System.Drawing.Size(846, 27);
            this.clientiBindingNavigator.TabIndex = 0;
            this.clientiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 24);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // clientiBindingNavigatorSaveItem
            // 
            this.clientiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientiBindingNavigatorSaveItem.Image")));
            this.clientiBindingNavigatorSaveItem.Name = "clientiBindingNavigatorSaveItem";
            this.clientiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.clientiBindingNavigatorSaveItem.Text = "Salva dati";
            this.clientiBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientiBindingNavigatorSaveItem_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(137, 119);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeTextBox.TabIndex = 2;
            // 
            // cognomeTextBox
            // 
            this.cognomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "cognome", true));
            this.cognomeTextBox.Location = new System.Drawing.Point(334, 122);
            this.cognomeTextBox.Name = "cognomeTextBox";
            this.cognomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cognomeTextBox.TabIndex = 4;
            // 
            // dataNascitaDateTimePicker
            // 
            this.dataNascitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientiBindingSource, "dataNascita", true));
            this.dataNascitaDateTimePicker.Location = new System.Drawing.Point(568, 124);
            this.dataNascitaDateTimePicker.Name = "dataNascitaDateTimePicker";
            this.dataNascitaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataNascitaDateTimePicker.TabIndex = 6;
            // 
            // cittaTextBox
            // 
            this.cittaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "citta", true));
            this.cittaTextBox.Location = new System.Drawing.Point(127, 181);
            this.cittaTextBox.Name = "cittaTextBox";
            this.cittaTextBox.Size = new System.Drawing.Size(100, 22);
            this.cittaTextBox.TabIndex = 8;
            // 
            // cittaComboBox
            // 
            this.cittaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientiBindingSource, "citta", true));
            this.cittaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cittaBindingSource, "citta", true));
            this.cittaComboBox.DataSource = this.cittaBindingSource;
            this.cittaComboBox.DisplayMember = "citta";
            this.cittaComboBox.FormattingEnabled = true;
            this.cittaComboBox.Location = new System.Drawing.Point(301, 178);
            this.cittaComboBox.Name = "cittaComboBox";
            this.cittaComboBox.Size = new System.Drawing.Size(121, 24);
            this.cittaComboBox.TabIndex = 10;
            this.cittaComboBox.ValueMember = "ID_citta";
            // 
            // cittaBindingSource
            // 
            this.cittaBindingSource.DataMember = "citta";
            this.cittaBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // fKprenotazioniclientiBindingSource
            // 
            this.fKprenotazioniclientiBindingSource.DataMember = "FK_prenotazioni_clienti";
            this.fKprenotazioniclientiBindingSource.DataSource = this.clientiBindingSource;
            // 
            // regioniBindingSource
            // 
            this.regioniBindingSource.DataMember = "regioni";
            this.regioniBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // regioniTableAdapter
            // 
            this.regioniTableAdapter.ClearBeforeFill = true;
            // 
            // regioneLabel
            // 
            regioneLabel.AutoSize = true;
            regioneLabel.Location = new System.Drawing.Point(476, 184);
            regioneLabel.Name = "regioneLabel";
            regioneLabel.Size = new System.Drawing.Size(56, 16);
            regioneLabel.TabIndex = 11;
            regioneLabel.Text = "regione:";
            // 
            // regioneComboBox
            // 
            this.regioneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regioniBindingSource, "regione", true));
            this.regioneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.regioniBindingSource, "ID_regione", true));
            this.regioneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.regioniBindingSource, "regione", true));
            this.regioneComboBox.DataSource = this.regioniBindingSource;
            this.regioneComboBox.DisplayMember = "regione";
            this.regioneComboBox.FormattingEnabled = true;
            this.regioneComboBox.Location = new System.Drawing.Point(538, 181);
            this.regioneComboBox.Name = "regioneComboBox";
            this.regioneComboBox.Size = new System.Drawing.Size(121, 24);
            this.regioneComboBox.TabIndex = 12;
            this.regioneComboBox.ValueMember = "ID_regione";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(regioneLabel);
            this.Controls.Add(this.regioneComboBox);
            this.Controls.Add(cittaLabel1);
            this.Controls.Add(this.cittaComboBox);
            this.Controls.Add(cittaLabel);
            this.Controls.Add(this.cittaTextBox);
            this.Controls.Add(dataNascitaLabel);
            this.Controls.Add(this.dataNascitaDateTimePicker);
            this.Controls.Add(cognomeLabel);
            this.Controls.Add(this.cognomeTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.clientiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).EndInit();
            this.clientiBindingNavigator.ResumeLayout(false);
            this.clientiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprenotazioniclientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prenotazioniDataSet prenotazioniDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private prenotazioniDataSetTableAdapters.clientiTableAdapter clientiTableAdapter;
        private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cognomeTextBox;
        private System.Windows.Forms.DateTimePicker dataNascitaDateTimePicker;
        private System.Windows.Forms.TextBox cittaTextBox;
        private System.Windows.Forms.ComboBox cittaComboBox;
        private prenotazioniDataSetTableAdapters.prenotazioniTableAdapter prenotazioniTableAdapter;
        private System.Windows.Forms.BindingSource fKprenotazioniclientiBindingSource;
        private prenotazioniDataSetTableAdapters.cittaTableAdapter cittaTableAdapter;
        private System.Windows.Forms.BindingSource cittaBindingSource;
        private System.Windows.Forms.BindingSource regioniBindingSource;
        private prenotazioniDataSetTableAdapters.regioniTableAdapter regioniTableAdapter;
        private System.Windows.Forms.ComboBox regioneComboBox;
    }
}


﻿namespace ReservationsManager
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label cameraLabel;
            System.Windows.Forms.Label arrivoLabel;
            System.Windows.Forms.Label partenzaLabel;
            System.Windows.Forms.Label importoLabel;
            System.Windows.Forms.Label caparraLabel;
            System.Windows.Forms.Label tipo_strutturaLabel;
            System.Windows.Forms.Label giorni_permanenzaLabel;
            System.Windows.Forms.Label costo_giornalieroLabel;
            System.Windows.Forms.Label clienteLabel;
            this.prenotazioniDataSet = new ReservationsManager.prenotazioniDataSet();
            this.prenotazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prenotazioniTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.prenotazioniTableAdapter();
            this.tableAdapterManager = new ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
            this.prenotazioniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.prenotazioniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cameraTextBox = new System.Windows.Forms.TextBox();
            this.arrivoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.partenzaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importoTextBox = new System.Windows.Forms.TextBox();
            this.caparraTextBox = new System.Windows.Forms.TextBox();
            this.tipo_strutturaTextBox = new System.Windows.Forms.TextBox();
            this.giorni_permanenzaTextBox = new System.Windows.Forms.TextBox();
            this.costo_giornalieroTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.prenotazioniDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cameraLabel = new System.Windows.Forms.Label();
            arrivoLabel = new System.Windows.Forms.Label();
            partenzaLabel = new System.Windows.Forms.Label();
            importoLabel = new System.Windows.Forms.Label();
            caparraLabel = new System.Windows.Forms.Label();
            tipo_strutturaLabel = new System.Windows.Forms.Label();
            giorni_permanenzaLabel = new System.Windows.Forms.Label();
            costo_giornalieroLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingNavigator)).BeginInit();
            this.prenotazioniBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prenotazioniDataSet
            // 
            this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
            this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prenotazioniBindingSource
            // 
            this.prenotazioniBindingSource.DataMember = "prenotazioni";
            this.prenotazioniBindingSource.DataSource = this.prenotazioniDataSet;
            // 
            // prenotazioniTableAdapter
            // 
            this.prenotazioniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cittaTableAdapter = null;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.prenotazioniTableAdapter = this.prenotazioniTableAdapter;
            this.tableAdapterManager.regioniTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prenotazioniBindingNavigator
            // 
            this.prenotazioniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prenotazioniBindingNavigator.BindingSource = this.prenotazioniBindingSource;
            this.prenotazioniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prenotazioniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prenotazioniBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.prenotazioniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prenotazioniBindingNavigatorSaveItem});
            this.prenotazioniBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prenotazioniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prenotazioniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prenotazioniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prenotazioniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prenotazioniBindingNavigator.Name = "prenotazioniBindingNavigator";
            this.prenotazioniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prenotazioniBindingNavigator.Size = new System.Drawing.Size(1306, 27);
            this.prenotazioniBindingNavigator.TabIndex = 0;
            this.prenotazioniBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 20);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // prenotazioniBindingNavigatorSaveItem
            // 
            this.prenotazioniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prenotazioniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prenotazioniBindingNavigatorSaveItem.Image")));
            this.prenotazioniBindingNavigatorSaveItem.Name = "prenotazioniBindingNavigatorSaveItem";
            this.prenotazioniBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.prenotazioniBindingNavigatorSaveItem.Text = "Salva dati";
            this.prenotazioniBindingNavigatorSaveItem.Click += new System.EventHandler(this.prenotazioniBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "apri clienti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cameraLabel
            // 
            cameraLabel.AutoSize = true;
            cameraLabel.Location = new System.Drawing.Point(38, 118);
            cameraLabel.Name = "cameraLabel";
            cameraLabel.Size = new System.Drawing.Size(56, 16);
            cameraLabel.TabIndex = 2;
            cameraLabel.Text = "camera:";
            // 
            // cameraTextBox
            // 
            this.cameraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "camera", true));
            this.cameraTextBox.Location = new System.Drawing.Point(100, 115);
            this.cameraTextBox.Name = "cameraTextBox";
            this.cameraTextBox.Size = new System.Drawing.Size(100, 22);
            this.cameraTextBox.TabIndex = 3;
            // 
            // arrivoLabel
            // 
            arrivoLabel.AutoSize = true;
            arrivoLabel.Location = new System.Drawing.Point(219, 119);
            arrivoLabel.Name = "arrivoLabel";
            arrivoLabel.Size = new System.Drawing.Size(44, 16);
            arrivoLabel.TabIndex = 4;
            arrivoLabel.Text = "arrivo:";
            // 
            // arrivoDateTimePicker
            // 
            this.arrivoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "arrivo", true));
            this.arrivoDateTimePicker.Location = new System.Drawing.Point(269, 115);
            this.arrivoDateTimePicker.Name = "arrivoDateTimePicker";
            this.arrivoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.arrivoDateTimePicker.TabIndex = 5;
            // 
            // partenzaLabel
            // 
            partenzaLabel.AutoSize = true;
            partenzaLabel.Location = new System.Drawing.Point(498, 116);
            partenzaLabel.Name = "partenzaLabel";
            partenzaLabel.Size = new System.Drawing.Size(62, 16);
            partenzaLabel.TabIndex = 6;
            partenzaLabel.Text = "partenza:";
            // 
            // partenzaDateTimePicker
            // 
            this.partenzaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "partenza", true));
            this.partenzaDateTimePicker.Location = new System.Drawing.Point(566, 112);
            this.partenzaDateTimePicker.Name = "partenzaDateTimePicker";
            this.partenzaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.partenzaDateTimePicker.TabIndex = 7;
            // 
            // importoLabel
            // 
            importoLabel.AutoSize = true;
            importoLabel.Location = new System.Drawing.Point(786, 113);
            importoLabel.Name = "importoLabel";
            importoLabel.Size = new System.Drawing.Size(55, 16);
            importoLabel.TabIndex = 8;
            importoLabel.Text = "importo:";
            // 
            // importoTextBox
            // 
            this.importoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "importo", true));
            this.importoTextBox.Location = new System.Drawing.Point(847, 110);
            this.importoTextBox.Name = "importoTextBox";
            this.importoTextBox.Size = new System.Drawing.Size(100, 22);
            this.importoTextBox.TabIndex = 9;
            // 
            // caparraLabel
            // 
            caparraLabel.AutoSize = true;
            caparraLabel.Location = new System.Drawing.Point(958, 115);
            caparraLabel.Name = "caparraLabel";
            caparraLabel.Size = new System.Drawing.Size(57, 16);
            caparraLabel.TabIndex = 10;
            caparraLabel.Text = "caparra:";
            // 
            // caparraTextBox
            // 
            this.caparraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "caparra", true));
            this.caparraTextBox.Location = new System.Drawing.Point(1021, 112);
            this.caparraTextBox.Name = "caparraTextBox";
            this.caparraTextBox.Size = new System.Drawing.Size(100, 22);
            this.caparraTextBox.TabIndex = 11;
            // 
            // tipo_strutturaLabel
            // 
            tipo_strutturaLabel.AutoSize = true;
            tipo_strutturaLabel.Location = new System.Drawing.Point(97, 192);
            tipo_strutturaLabel.Name = "tipo_strutturaLabel";
            tipo_strutturaLabel.Size = new System.Drawing.Size(81, 16);
            tipo_strutturaLabel.TabIndex = 12;
            tipo_strutturaLabel.Text = "tipo struttura:";
            // 
            // tipo_strutturaTextBox
            // 
            this.tipo_strutturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "tipo_struttura", true));
            this.tipo_strutturaTextBox.Location = new System.Drawing.Point(184, 189);
            this.tipo_strutturaTextBox.Name = "tipo_strutturaTextBox";
            this.tipo_strutturaTextBox.Size = new System.Drawing.Size(100, 22);
            this.tipo_strutturaTextBox.TabIndex = 13;
            // 
            // giorni_permanenzaLabel
            // 
            giorni_permanenzaLabel.AutoSize = true;
            giorni_permanenzaLabel.Location = new System.Drawing.Point(382, 189);
            giorni_permanenzaLabel.Name = "giorni_permanenzaLabel";
            giorni_permanenzaLabel.Size = new System.Drawing.Size(121, 16);
            giorni_permanenzaLabel.TabIndex = 14;
            giorni_permanenzaLabel.Text = "giorni permanenza:";
            // 
            // giorni_permanenzaTextBox
            // 
            this.giorni_permanenzaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "giorni_permanenza", true));
            this.giorni_permanenzaTextBox.Location = new System.Drawing.Point(509, 186);
            this.giorni_permanenzaTextBox.Name = "giorni_permanenzaTextBox";
            this.giorni_permanenzaTextBox.Size = new System.Drawing.Size(100, 22);
            this.giorni_permanenzaTextBox.TabIndex = 15;
            // 
            // costo_giornalieroLabel
            // 
            costo_giornalieroLabel.AutoSize = true;
            costo_giornalieroLabel.Location = new System.Drawing.Point(664, 186);
            costo_giornalieroLabel.Name = "costo_giornalieroLabel";
            costo_giornalieroLabel.Size = new System.Drawing.Size(110, 16);
            costo_giornalieroLabel.TabIndex = 16;
            costo_giornalieroLabel.Text = "costo giornaliero:";
            // 
            // costo_giornalieroTextBox
            // 
            this.costo_giornalieroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "costo_giornaliero", true));
            this.costo_giornalieroTextBox.Location = new System.Drawing.Point(780, 183);
            this.costo_giornalieroTextBox.Name = "costo_giornalieroTextBox";
            this.costo_giornalieroTextBox.Size = new System.Drawing.Size(100, 22);
            this.costo_giornalieroTextBox.TabIndex = 17;
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(949, 186);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(49, 16);
            clienteLabel.TabIndex = 18;
            clienteLabel.Text = "cliente:";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "cliente", true));
            this.clienteTextBox.Location = new System.Drawing.Point(1004, 183);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(100, 22);
            this.clienteTextBox.TabIndex = 19;
            // 
            // prenotazioniDataGridView
            // 
            this.prenotazioniDataGridView.AutoGenerateColumns = false;
            this.prenotazioniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prenotazioniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.prenotazioniDataGridView.DataSource = this.prenotazioniBindingSource;
            this.prenotazioniDataGridView.Location = new System.Drawing.Point(73, 249);
            this.prenotazioniDataGridView.Name = "prenotazioniDataGridView";
            this.prenotazioniDataGridView.RowHeadersWidth = 51;
            this.prenotazioniDataGridView.RowTemplate.Height = 24;
            this.prenotazioniDataGridView.Size = new System.Drawing.Size(1145, 220);
            this.prenotazioniDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_prenotazione";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_prenotazione";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "camera";
            this.dataGridViewTextBoxColumn2.HeaderText = "camera";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "arrivo";
            this.dataGridViewTextBoxColumn3.HeaderText = "arrivo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partenza";
            this.dataGridViewTextBoxColumn4.HeaderText = "partenza";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "importo";
            this.dataGridViewTextBoxColumn5.HeaderText = "importo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "caparra";
            this.dataGridViewTextBoxColumn6.HeaderText = "caparra";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tipo_struttura";
            this.dataGridViewTextBoxColumn7.HeaderText = "tipo_struttura";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "giorni_permanenza";
            this.dataGridViewTextBoxColumn8.HeaderText = "giorni_permanenza";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "costo_giornaliero";
            this.dataGridViewTextBoxColumn9.HeaderText = "costo_giornaliero";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cliente";
            this.dataGridViewTextBoxColumn10.HeaderText = "cliente";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 554);
            this.Controls.Add(this.prenotazioniDataGridView);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(costo_giornalieroLabel);
            this.Controls.Add(this.costo_giornalieroTextBox);
            this.Controls.Add(giorni_permanenzaLabel);
            this.Controls.Add(this.giorni_permanenzaTextBox);
            this.Controls.Add(tipo_strutturaLabel);
            this.Controls.Add(this.tipo_strutturaTextBox);
            this.Controls.Add(caparraLabel);
            this.Controls.Add(this.caparraTextBox);
            this.Controls.Add(importoLabel);
            this.Controls.Add(this.importoTextBox);
            this.Controls.Add(partenzaLabel);
            this.Controls.Add(this.partenzaDateTimePicker);
            this.Controls.Add(arrivoLabel);
            this.Controls.Add(this.arrivoDateTimePicker);
            this.Controls.Add(cameraLabel);
            this.Controls.Add(this.cameraTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prenotazioniBindingNavigator);
            this.Name = "Form3";
            this.Text = "esercizio 3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingNavigator)).EndInit();
            this.prenotazioniBindingNavigator.ResumeLayout(false);
            this.prenotazioniBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prenotazioniDataSet prenotazioniDataSet;
        private System.Windows.Forms.BindingSource prenotazioniBindingSource;
        private prenotazioniDataSetTableAdapters.prenotazioniTableAdapter prenotazioniTableAdapter;
        private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prenotazioniBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prenotazioniBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cameraTextBox;
        private System.Windows.Forms.DateTimePicker arrivoDateTimePicker;
        private System.Windows.Forms.DateTimePicker partenzaDateTimePicker;
        private System.Windows.Forms.TextBox importoTextBox;
        private System.Windows.Forms.TextBox caparraTextBox;
        private System.Windows.Forms.TextBox tipo_strutturaTextBox;
        private System.Windows.Forms.TextBox giorni_permanenzaTextBox;
        private System.Windows.Forms.TextBox costo_giornalieroTextBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.DataGridView prenotazioniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
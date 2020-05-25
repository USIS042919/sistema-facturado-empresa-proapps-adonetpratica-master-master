namespace proapps
{
    partial class FormularioAvanzados2
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
            System.Windows.Forms.Label idEmpleadosLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label pagosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAvanzados2));
            this.sistema_dbDataSet = new proapps.sistema_dbDataSet();
            this.tabla1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabla1TableAdapter = new proapps.sistema_dbDataSetTableAdapters.tabla1TableAdapter();
            this.tableAdapterManager = new proapps.sistema_dbDataSetTableAdapters.TableAdapterManager();
            this.tabla1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabla1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idEmpleadosTextBox = new System.Windows.Forms.TextBox();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.telefonoComboBox = new System.Windows.Forms.ComboBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.pagosComboBox = new System.Windows.Forms.ComboBox();
            this.tabla2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabla2TableAdapter = new proapps.sistema_dbDataSetTableAdapters.tabla2TableAdapter();
            this.tabla2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gtransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gecenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            idEmpleadosLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            pagosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingNavigator)).BeginInit();
            this.tabla1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2DataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idEmpleadosLabel
            // 
            idEmpleadosLabel.AutoSize = true;
            idEmpleadosLabel.Location = new System.Drawing.Point(59, 39);
            idEmpleadosLabel.Name = "idEmpleadosLabel";
            idEmpleadosLabel.Size = new System.Drawing.Size(21, 13);
            idEmpleadosLabel.TabIndex = 1;
            idEmpleadosLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(35, 72);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(240, 42);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(455, 65);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(40, 13);
            correoLabel.TabIndex = 11;
            correoLabel.Text = "correo:";
            // 
            // pagosLabel
            // 
            pagosLabel.AutoSize = true;
            pagosLabel.Location = new System.Drawing.Point(500, 42);
            pagosLabel.Name = "pagosLabel";
            pagosLabel.Size = new System.Drawing.Size(39, 13);
            pagosLabel.TabIndex = 13;
            pagosLabel.Text = "pagos:";
            // 
            // sistema_dbDataSet
            // 
            this.sistema_dbDataSet.DataSetName = "sistema_dbDataSet";
            this.sistema_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabla1BindingSource
            // 
            this.tabla1BindingSource.DataMember = "tabla1";
            this.tabla1BindingSource.DataSource = this.sistema_dbDataSet;
            // 
            // tabla1TableAdapter
            // 
            this.tabla1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.empleadosTableAdapter = null;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.formasTableAdapter = null;
            this.tableAdapterManager.gastoTableAdapter = null;
            this.tableAdapterManager.informeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proapps.sistema_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabla1BindingNavigator
            // 
            this.tabla1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabla1BindingNavigator.BindingSource = this.tabla1BindingSource;
            this.tabla1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabla1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabla1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tabla1BindingNavigatorSaveItem});
            this.tabla1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabla1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabla1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabla1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabla1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabla1BindingNavigator.Name = "tabla1BindingNavigator";
            this.tabla1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabla1BindingNavigator.Size = new System.Drawing.Size(914, 25);
            this.tabla1BindingNavigator.TabIndex = 0;
            this.tabla1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabla1BindingNavigatorSaveItem
            // 
            this.tabla1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabla1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabla1BindingNavigatorSaveItem.Image")));
            this.tabla1BindingNavigatorSaveItem.Name = "tabla1BindingNavigatorSaveItem";
            this.tabla1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabla1BindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // idEmpleadosTextBox
            // 
            this.idEmpleadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla1BindingSource, "idEmpleados", true));
            this.idEmpleadosTextBox.Location = new System.Drawing.Point(86, 39);
            this.idEmpleadosTextBox.Name = "idEmpleadosTextBox";
            this.idEmpleadosTextBox.Size = new System.Drawing.Size(121, 20);
            this.idEmpleadosTextBox.TabIndex = 2;
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla1BindingSource, "nombre", true));
            this.nombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(86, 65);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(330, 21);
            this.nombreComboBox.TabIndex = 8;
            // 
            // telefonoComboBox
            // 
            this.telefonoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla1BindingSource, "telefono", true));
            this.telefonoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.telefonoComboBox.FormattingEnabled = true;
            this.telefonoComboBox.Location = new System.Drawing.Point(294, 39);
            this.telefonoComboBox.Name = "telefonoComboBox";
            this.telefonoComboBox.Size = new System.Drawing.Size(121, 21);
            this.telefonoComboBox.TabIndex = 10;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla1BindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(501, 65);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(315, 20);
            this.correoTextBox.TabIndex = 12;
            // 
            // pagosComboBox
            // 
            this.pagosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabla1BindingSource, "pagos", true));
            this.pagosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagosComboBox.FormattingEnabled = true;
            this.pagosComboBox.Location = new System.Drawing.Point(545, 39);
            this.pagosComboBox.Name = "pagosComboBox";
            this.pagosComboBox.Size = new System.Drawing.Size(121, 21);
            this.pagosComboBox.TabIndex = 14;
            // 
            // tabla2BindingSource
            // 
            this.tabla2BindingSource.DataMember = "tabla2";
            this.tabla2BindingSource.DataSource = this.sistema_dbDataSet;
            // 
            // tabla2TableAdapter
            // 
            this.tabla2TableAdapter.ClearBeforeFill = true;
            // 
            // tabla2DataGridView
            // 
            this.tabla2DataGridView.AutoGenerateColumns = false;
            this.tabla2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabla2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.codigo,
            this.nombre,
            this.telefono,
            this.correo,
            this.pagos,
            this.Gtransporte,
            this.Gecenario});
            this.tabla2DataGridView.DataSource = this.tabla2BindingSource;
            this.tabla2DataGridView.Location = new System.Drawing.Point(38, 144);
            this.tabla2DataGridView.Name = "tabla2DataGridView";
            this.tabla2DataGridView.Size = new System.Drawing.Size(842, 220);
            this.tabla2DataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEmpleados";
            this.dataGridViewTextBoxColumn1.HeaderText = "Empleados";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idInforme";
            this.dataGridViewTextBoxColumn2.HeaderText = "idInforme";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idGastos";
            this.dataGridViewTextBoxColumn3.HeaderText = "idGastos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo ";
            this.codigo.HeaderText = "codigo ";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.Name = "correo";
            this.correo.Width = 200;
            // 
            // pagos
            // 
            this.pagos.DataPropertyName = "pagos";
            this.pagos.HeaderText = "pagos";
            this.pagos.Name = "pagos";
            this.pagos.Width = 70;
            // 
            // Gtransporte
            // 
            this.Gtransporte.DataPropertyName = "Gtransporte";
            this.Gtransporte.HeaderText = "Gtransporte";
            this.Gtransporte.Name = "Gtransporte";
            // 
            // Gecenario
            // 
            this.Gecenario.DataPropertyName = "Gecenario";
            this.Gecenario.HeaderText = "Gecenario";
            this.Gecenario.Name = "Gecenario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblregistroxden);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Location = new System.Drawing.Point(38, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 18;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(76, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(160, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(32, 38);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(129, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(38, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 38);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(7, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(32, 38);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // FormularioAvanzado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabla2DataGridView);
            this.Controls.Add(idEmpleadosLabel);
            this.Controls.Add(this.idEmpleadosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoComboBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(pagosLabel);
            this.Controls.Add(this.pagosComboBox);
            this.Controls.Add(this.tabla1BindingNavigator);
            this.Name = "FormularioAvanzado2";
            this.Text = "FormularioAvanzado2";
            this.Load += new System.EventHandler(this.FormularioAvanzado2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1BindingNavigator)).EndInit();
            this.tabla1BindingNavigator.ResumeLayout(false);
            this.tabla1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2DataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_dbDataSet sistema_dbDataSet;
        private System.Windows.Forms.BindingSource tabla1BindingSource;
        private sistema_dbDataSetTableAdapters.tabla1TableAdapter tabla1TableAdapter;
        private sistema_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabla1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tabla1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idEmpleadosTextBox;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.ComboBox telefonoComboBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.ComboBox pagosComboBox;
        private System.Windows.Forms.BindingSource tabla2BindingSource;
        private sistema_dbDataSetTableAdapters.tabla2TableAdapter tabla2TableAdapter;
        private System.Windows.Forms.DataGridView tabla2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gtransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gecenario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
    }
}
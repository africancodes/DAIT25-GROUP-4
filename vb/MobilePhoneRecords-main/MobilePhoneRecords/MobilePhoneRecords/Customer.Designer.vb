<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.MPRdbDataSet = New MobilePhoneRecords.MPRdbDataSet()
        Me.CellphoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CellphoneTableAdapter = New MobilePhoneRecords.MPRdbDataSetTableAdapters.cellphoneTableAdapter()
        Me.TableAdapterManager = New MobilePhoneRecords.MPRdbDataSetTableAdapters.TableAdapterManager()
        Me.CellphoneBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CellphoneBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CellphoneDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.methodOfPayment = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.MPRdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CellphoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CellphoneBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CellphoneBindingNavigator.SuspendLayout()
        CType(Me.CellphoneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MPRdbDataSet
        '
        Me.MPRdbDataSet.DataSetName = "MPRdbDataSet"
        Me.MPRdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CellphoneBindingSource
        '
        Me.CellphoneBindingSource.DataMember = "cellphone"
        Me.CellphoneBindingSource.DataSource = Me.MPRdbDataSet
        '
        'CellphoneTableAdapter
        '
        Me.CellphoneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cellphoneTableAdapter = Me.CellphoneTableAdapter
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptTableAdapter = Nothing
        Me.TableAdapterManager.ServiceProviderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MobilePhoneRecords.MPRdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CellphoneBindingNavigator
        '
        Me.CellphoneBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CellphoneBindingNavigator.BindingSource = Me.CellphoneBindingSource
        Me.CellphoneBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CellphoneBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CellphoneBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CellphoneBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.CellphoneBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CellphoneBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CellphoneBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CellphoneBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CellphoneBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CellphoneBindingNavigator.Name = "CellphoneBindingNavigator"
        Me.CellphoneBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CellphoneBindingNavigator.Size = New System.Drawing.Size(896, 25)
        Me.CellphoneBindingNavigator.TabIndex = 0
        Me.CellphoneBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CellphoneBindingNavigatorSaveItem
        '
        Me.CellphoneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CellphoneBindingNavigatorSaveItem.Image = CType(resources.GetObject("CellphoneBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CellphoneBindingNavigatorSaveItem.Name = "CellphoneBindingNavigatorSaveItem"
        Me.CellphoneBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CellphoneBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'CellphoneDataGridView
        '
        Me.CellphoneDataGridView.AllowDrop = True
        Me.CellphoneDataGridView.AllowUserToAddRows = False
        Me.CellphoneDataGridView.AllowUserToDeleteRows = False
        Me.CellphoneDataGridView.AllowUserToResizeColumns = False
        Me.CellphoneDataGridView.AllowUserToResizeRows = False
        Me.CellphoneDataGridView.AutoGenerateColumns = False
        Me.CellphoneDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CellphoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CellphoneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CellphoneDataGridView.DataSource = Me.CellphoneBindingSource
        Me.CellphoneDataGridView.Location = New System.Drawing.Point(35, 82)
        Me.CellphoneDataGridView.Name = "CellphoneDataGridView"
        Me.CellphoneDataGridView.ReadOnly = True
        Me.CellphoneDataGridView.Size = New System.Drawing.Size(839, 235)
        Me.CellphoneDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CellphoneID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CellphoneID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Serial Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Brand"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Number of Sim Cards"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Number of Sim Cards"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Operating System"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Operating System"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CellphoneDate"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CellphoneDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Products in stock"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.methodOfPayment)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(35, 347)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 271)
        Me.Panel1.TabIndex = 3
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(572, 205)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(227, 20)
        Me.NumericUpDown1.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(474, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Serial Number"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CellphoneBindingSource, "Serial Number", True))
        Me.ComboBox3.DataSource = Me.CellphoneBindingSource
        Me.ComboBox3.DisplayMember = "Serial Number"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(572, 106)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox3.TabIndex = 18
        Me.ComboBox3.ValueMember = "Serial Number"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CellphoneBindingSource, "Brand", True))
        Me.ComboBox2.DataSource = Me.CellphoneBindingSource
        Me.ComboBox2.DisplayMember = "Brand"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(572, 52)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox2.TabIndex = 17
        Me.ComboBox2.ValueMember = "Brand"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Black", "White", "Blue", "Orange", "Pink", "Silver", "Grey"})
        Me.ComboBox1.Location = New System.Drawing.Point(572, 155)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(474, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Preferred color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(474, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Product Name"
        '
        'methodOfPayment
        '
        Me.methodOfPayment.FormattingEnabled = True
        Me.methodOfPayment.Items.AddRange(New Object() {"Bank transfer", "EcoCash", "ZipIt"})
        Me.methodOfPayment.Location = New System.Drawing.Point(119, 98)
        Me.methodOfPayment.Name = "methodOfPayment"
        Me.methodOfPayment.Size = New System.Drawing.Size(194, 21)
        Me.methodOfPayment.TabIndex = 9
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(114, 155)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(199, 96)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cutomer Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Method ofPayment"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(194, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buy A product"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Crimson
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(700, 624)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(174, 52)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.Color.Green
        Me.btnBuy.Location = New System.Drawing.Point(520, 624)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(174, 52)
        Me.btnBuy.TabIndex = 5
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(896, 25)
        Me.FillByToolStrip.TabIndex = 6
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(896, 25)
        Me.FillBy1ToolStrip.TabIndex = 7
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(896, 696)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CellphoneDataGridView)
        Me.Controls.Add(Me.CellphoneBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.MPRdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CellphoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CellphoneBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CellphoneBindingNavigator.ResumeLayout(False)
        Me.CellphoneBindingNavigator.PerformLayout()
        CType(Me.CellphoneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MPRdbDataSet As MPRdbDataSet
    Friend WithEvents CellphoneBindingSource As BindingSource
    Friend WithEvents CellphoneTableAdapter As MPRdbDataSetTableAdapters.cellphoneTableAdapter
    Friend WithEvents TableAdapterManager As MPRdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CellphoneBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CellphoneBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Private WithEvents CellphoneDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBuy As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents methodOfPayment As ComboBox
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Basic small print, standard quality" & Global.Microsoft.VisualBasic.ChrW(9), "$30", "#003"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Basic medium print, standard quality" & Global.Microsoft.VisualBasic.ChrW(9), "$50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10), "#004"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Basic large print, standard quality" & Global.Microsoft.VisualBasic.ChrW(9), "$110", "#005"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Base 3D printer", "$799", "#001"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"High-end printer" & Global.Microsoft.VisualBasic.ChrW(9), "$3999", "#002"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"High quality FDM print" & Global.Microsoft.VisualBasic.ChrW(9), "+110%", "#006"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"High quality SLA print" & Global.Microsoft.VisualBasic.ChrW(9), "+210%", "#007"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"FDM print using ABS" & Global.Microsoft.VisualBasic.ChrW(9), "+20%", "#008"}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"FDM print using ASA" & Global.Microsoft.VisualBasic.ChrW(9), "+30%", "#009"}, -1)
        Me.firstNamelb = New System.Windows.Forms.Label()
        Me.lastNamelb = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.emaillb = New System.Windows.Forms.Label()
        Me.quoteBtn = New System.Windows.Forms.Button()
        Me.partsListView = New System.Windows.Forms.ListView()
        Me.C1productName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C2productCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.displayFirst = New System.Windows.Forms.Label()
        Me.displayLast = New System.Windows.Forms.Label()
        Me.addlb = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.displayEmail = New System.Windows.Forms.Label()
        Me.quoteListview = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totalCost = New System.Windows.Forms.Label()
        Me.requestCb = New System.Windows.Forms.CheckBox()
        Me.listview1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listview3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.removeQuote = New System.Windows.Forms.Button()
        Me.contractBtn = New System.Windows.Forms.CheckBox()
        Me.sfdWriter = New System.Windows.Forms.SaveFileDialog()
        Me.removeItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'firstNamelb
        '
        Me.firstNamelb.AutoSize = True
        Me.firstNamelb.Cursor = System.Windows.Forms.Cursors.Default
        Me.firstNamelb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNamelb.Location = New System.Drawing.Point(12, 28)
        Me.firstNamelb.Name = "firstNamelb"
        Me.firstNamelb.Size = New System.Drawing.Size(64, 13)
        Me.firstNamelb.TabIndex = 1
        Me.firstNamelb.Text = "First Name:"
        '
        'lastNamelb
        '
        Me.lastNamelb.AutoSize = True
        Me.lastNamelb.Cursor = System.Windows.Forms.Cursors.Default
        Me.lastNamelb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNamelb.Location = New System.Drawing.Point(12, 63)
        Me.lastNamelb.Name = "lastNamelb"
        Me.lastNamelb.Size = New System.Drawing.Size(62, 13)
        Me.lastNamelb.TabIndex = 2
        Me.lastNamelb.Text = "Last Name:"
        '
        'firstName
        '
        Me.firstName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.firstName.Location = New System.Drawing.Point(82, 25)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(120, 22)
        Me.firstName.TabIndex = 1
        '
        'lastName
        '
        Me.lastName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lastName.Location = New System.Drawing.Point(82, 60)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(120, 22)
        Me.lastName.TabIndex = 2
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.email.Location = New System.Drawing.Point(82, 97)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(120, 22)
        Me.email.TabIndex = 3
        '
        'emaillb
        '
        Me.emaillb.AutoSize = True
        Me.emaillb.Cursor = System.Windows.Forms.Cursors.Default
        Me.emaillb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emaillb.Location = New System.Drawing.Point(14, 100)
        Me.emaillb.Name = "emaillb"
        Me.emaillb.Size = New System.Drawing.Size(37, 13)
        Me.emaillb.TabIndex = 6
        Me.emaillb.Text = "Email:"
        '
        'quoteBtn
        '
        Me.quoteBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.quoteBtn.Location = New System.Drawing.Point(191, 379)
        Me.quoteBtn.Name = "quoteBtn"
        Me.quoteBtn.Size = New System.Drawing.Size(92, 23)
        Me.quoteBtn.TabIndex = 7
        Me.quoteBtn.Text = "Get Quote"
        Me.quoteBtn.UseVisualStyleBackColor = True
        '
        'partsListView
        '
        Me.partsListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.partsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.C1productName, Me.C2productCost, Me.ColumnHeader3})
        Me.partsListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.partsListView.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.partsListView.FullRowSelect = True
        Me.partsListView.GridLines = True
        Me.partsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        Me.partsListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.partsListView.Location = New System.Drawing.Point(253, 100)
        Me.partsListView.Name = "partsListView"
        Me.partsListView.ShowItemToolTips = True
        Me.partsListView.Size = New System.Drawing.Size(349, 98)
        Me.partsListView.TabIndex = 33
        Me.partsListView.UseCompatibleStateImageBehavior = False
        Me.partsListView.View = System.Windows.Forms.View.Details
        '
        'C1productName
        '
        Me.C1productName.Text = "Product"
        Me.C1productName.Width = 199
        '
        'C2productCost
        '
        Me.C2productCost.Text = "Cost"
        Me.C2productCost.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.55!)
        Me.Label1.Location = New System.Drawing.Point(12, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Current Customer Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "First Last:"
        '
        'displayFirst
        '
        Me.displayFirst.AutoSize = True
        Me.displayFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.displayFirst.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayFirst.Location = New System.Drawing.Point(84, 185)
        Me.displayFirst.Name = "displayFirst"
        Me.displayFirst.Size = New System.Drawing.Size(29, 13)
        Me.displayFirst.TabIndex = 37
        Me.displayFirst.Text = "First"
        '
        'displayLast
        '
        Me.displayLast.AutoSize = True
        Me.displayLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.displayLast.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayLast.Location = New System.Drawing.Point(84, 203)
        Me.displayLast.Name = "displayLast"
        Me.displayLast.Size = New System.Drawing.Size(27, 13)
        Me.displayLast.TabIndex = 38
        Me.displayLast.Text = "Last"
        '
        'addlb
        '
        Me.addlb.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.addlb.Location = New System.Drawing.Point(15, 125)
        Me.addlb.Name = "addlb"
        Me.addlb.Size = New System.Drawing.Size(75, 23)
        Me.addlb.TabIndex = 5
        Me.addlb.Text = "Add"
        Me.addlb.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Email: "
        '
        'displayEmail
        '
        Me.displayEmail.AutoSize = True
        Me.displayEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.displayEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayEmail.Location = New System.Drawing.Point(84, 220)
        Me.displayEmail.Name = "displayEmail"
        Me.displayEmail.Size = New System.Drawing.Size(34, 13)
        Me.displayEmail.TabIndex = 41
        Me.displayEmail.Text = "Email"
        '
        'quoteListview
        '
        Me.quoteListview.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.quoteListview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader17})
        Me.quoteListview.Cursor = System.Windows.Forms.Cursors.Default
        Me.quoteListview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.quoteListview.FullRowSelect = True
        Me.quoteListview.GridLines = True
        Me.quoteListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.quoteListview.Location = New System.Drawing.Point(188, 220)
        Me.quoteListview.Name = "quoteListview"
        Me.quoteListview.Size = New System.Drawing.Size(472, 153)
        Me.quoteListview.TabIndex = 42
        Me.quoteListview.UseCompatibleStateImageBehavior = False
        Me.quoteListview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Product"
        Me.ColumnHeader4.Width = 396
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Cost"
        Me.ColumnHeader17.Width = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Click to add items"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(188, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Item Added In Quote"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(515, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Total Cost:"
        '
        'totalCost
        '
        Me.totalCost.AutoSize = True
        Me.totalCost.Cursor = System.Windows.Forms.Cursors.Default
        Me.totalCost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCost.Location = New System.Drawing.Point(594, 384)
        Me.totalCost.Name = "totalCost"
        Me.totalCost.Size = New System.Drawing.Size(0, 13)
        Me.totalCost.TabIndex = 47
        '
        'requestCb
        '
        Me.requestCb.AutoSize = True
        Me.requestCb.Location = New System.Drawing.Point(424, 202)
        Me.requestCb.Name = "requestCb"
        Me.requestCb.Size = New System.Drawing.Size(108, 17)
        Me.requestCb.TabIndex = 4
        Me.requestCb.Text = "Request Prioritize"
        Me.requestCb.UseVisualStyleBackColor = True
        '
        'listview1
        '
        Me.listview1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listview1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.listview1.Cursor = System.Windows.Forms.Cursors.Default
        Me.listview1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.listview1.FullRowSelect = True
        Me.listview1.GridLines = True
        Me.listview1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem4.StateImageIndex = 0
        ListViewItem4.UseItemStyleForSubItems = False
        ListViewItem5.StateImageIndex = 0
        Me.listview1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5})
        Me.listview1.Location = New System.Drawing.Point(253, 25)
        Me.listview1.Name = "listview1"
        Me.listview1.ShowItemToolTips = True
        Me.listview1.Size = New System.Drawing.Size(348, 62)
        Me.listview1.TabIndex = 48
        Me.listview1.UseCompatibleStateImageBehavior = False
        Me.listview1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Product"
        Me.ColumnHeader5.Width = 199
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cost"
        Me.ColumnHeader6.Width = 85
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        '
        'listview2
        '
        Me.listview2.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listview2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.listview2.Cursor = System.Windows.Forms.Cursors.Default
        Me.listview2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.listview2.FullRowSelect = True
        Me.listview2.GridLines = True
        Me.listview2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem6.StateImageIndex = 0
        ListViewItem7.StateImageIndex = 0
        Me.listview2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7})
        Me.listview2.Location = New System.Drawing.Point(253, 100)
        Me.listview2.Name = "listview2"
        Me.listview2.ShowItemToolTips = True
        Me.listview2.Size = New System.Drawing.Size(349, 98)
        Me.listview2.TabIndex = 49
        Me.listview2.UseCompatibleStateImageBehavior = False
        Me.listview2.View = System.Windows.Forms.View.Details
        Me.listview2.Visible = False
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Product"
        Me.ColumnHeader8.Width = 199
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Cost"
        Me.ColumnHeader9.Width = 85
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ID"
        '
        'listview3
        '
        Me.listview3.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listview3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.listview3.Cursor = System.Windows.Forms.Cursors.Default
        Me.listview3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.listview3.FullRowSelect = True
        Me.listview3.GridLines = True
        Me.listview3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.StateImageIndex = 0
        Me.listview3.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem8, ListViewItem9})
        Me.listview3.Location = New System.Drawing.Point(252, 100)
        Me.listview3.Name = "listview3"
        Me.listview3.ShowItemToolTips = True
        Me.listview3.Size = New System.Drawing.Size(349, 98)
        Me.listview3.TabIndex = 50
        Me.listview3.UseCompatibleStateImageBehavior = False
        Me.listview3.View = System.Windows.Forms.View.Details
        Me.listview3.Visible = False
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Product"
        Me.ColumnHeader11.Width = 199
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Cost"
        Me.ColumnHeader12.Width = 85
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "ID"
        '
        'removeQuote
        '
        Me.removeQuote.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.removeQuote.Location = New System.Drawing.Point(300, 379)
        Me.removeQuote.Name = "removeQuote"
        Me.removeQuote.Size = New System.Drawing.Size(92, 23)
        Me.removeQuote.TabIndex = 51
        Me.removeQuote.Text = "Remove Quote"
        Me.removeQuote.UseVisualStyleBackColor = True
        '
        'contractBtn
        '
        Me.contractBtn.AutoSize = True
        Me.contractBtn.Location = New System.Drawing.Point(552, 202)
        Me.contractBtn.Name = "contractBtn"
        Me.contractBtn.Size = New System.Drawing.Size(66, 17)
        Me.contractBtn.TabIndex = 53
        Me.contractBtn.Text = "Contract"
        Me.contractBtn.UseVisualStyleBackColor = True
        '
        'removeItem
        '
        Me.removeItem.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.removeItem.Location = New System.Drawing.Point(407, 379)
        Me.removeItem.Name = "removeItem"
        Me.removeItem.Size = New System.Drawing.Size(92, 23)
        Me.removeItem.TabIndex = 54
        Me.removeItem.Text = "Remove Item"
        Me.removeItem.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 419)
        Me.Controls.Add(Me.removeItem)
        Me.Controls.Add(Me.contractBtn)
        Me.Controls.Add(Me.removeQuote)
        Me.Controls.Add(Me.listview3)
        Me.Controls.Add(Me.listview2)
        Me.Controls.Add(Me.listview1)
        Me.Controls.Add(Me.requestCb)
        Me.Controls.Add(Me.totalCost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.quoteListview)
        Me.Controls.Add(Me.displayEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.addlb)
        Me.Controls.Add(Me.displayLast)
        Me.Controls.Add(Me.displayFirst)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.partsListView)
        Me.Controls.Add(Me.quoteBtn)
        Me.Controls.Add(Me.emaillb)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.lastNamelb)
        Me.Controls.Add(Me.firstNamelb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "3D Printers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstNamelb As Label
    Friend WithEvents lastNamelb As Label
    Friend WithEvents firstName As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents emaillb As Label
    Friend WithEvents quoteBtn As Button
    Friend WithEvents partsListView As ListView
    Friend WithEvents C1productName As ColumnHeader
    Friend WithEvents C2productCost As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents displayFirst As Label
    Friend WithEvents displayLast As Label
    Friend WithEvents addlb As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents displayEmail As Label
    Friend WithEvents quoteListview As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents totalCost As Label
    Protected WithEvents requestCb As CheckBox
    Friend WithEvents listview1 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents listview2 As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents listview3 As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents removeQuote As Button
    Protected WithEvents contractBtn As CheckBox
    Friend WithEvents sfdWriter As SaveFileDialog
    Friend WithEvents removeItem As Button
End Class

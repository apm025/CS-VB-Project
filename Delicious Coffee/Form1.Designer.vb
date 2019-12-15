<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.clbFlavors = New System.Windows.Forms.CheckedListBox()
        Me.clbStyles = New System.Windows.Forms.CheckedListBox()
        Me.lblTotalStyles = New System.Windows.Forms.Label()
        Me.lblTotalFlavors = New System.Windows.Forms.Label()
        Me.txtTotalStyles = New System.Windows.Forms.TextBox()
        Me.txtTotalFlavors = New System.Windows.Forms.TextBox()
        Me.btnSubmitOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFlavor = New System.Windows.Forms.TextBox()
        Me.txtStyle = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.gbConfirm = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbConfirm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbSize)
        Me.GroupBox1.Controls.Add(Me.lblQuantity)
        Me.GroupBox1.Controls.Add(Me.numQuantity)
        Me.GroupBox1.Controls.Add(Me.clbFlavors)
        Me.GroupBox1.Controls.Add(Me.clbStyles)
        Me.GroupBox1.Controls.Add(Me.lblTotalStyles)
        Me.GroupBox1.Controls.Add(Me.lblTotalFlavors)
        Me.GroupBox1.Controls.Add(Me.txtTotalStyles)
        Me.GroupBox1.Controls.Add(Me.txtTotalFlavors)
        Me.GroupBox1.Controls.Add(Me.btnSubmitOrder)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 382)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OrderOptions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(488, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Size"
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cbSize.Location = New System.Drawing.Point(491, 149)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(105, 21)
        Me.cbSize.TabIndex = 27
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(488, 25)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 26
        Me.lblQuantity.Text = "Quantity"
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(491, 41)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(105, 20)
        Me.numQuantity.TabIndex = 25
        '
        'clbFlavors
        '
        Me.clbFlavors.FormattingEnabled = True
        Me.clbFlavors.Location = New System.Drawing.Point(22, 41)
        Me.clbFlavors.Name = "clbFlavors"
        Me.clbFlavors.Size = New System.Drawing.Size(211, 184)
        Me.clbFlavors.TabIndex = 24
        '
        'clbStyles
        '
        Me.clbStyles.FormattingEnabled = True
        Me.clbStyles.Location = New System.Drawing.Point(252, 41)
        Me.clbStyles.Name = "clbStyles"
        Me.clbStyles.Size = New System.Drawing.Size(211, 184)
        Me.clbStyles.TabIndex = 23
        '
        'lblTotalStyles
        '
        Me.lblTotalStyles.AutoSize = True
        Me.lblTotalStyles.Location = New System.Drawing.Point(249, 234)
        Me.lblTotalStyles.Name = "lblTotalStyles"
        Me.lblTotalStyles.Size = New System.Drawing.Size(62, 13)
        Me.lblTotalStyles.TabIndex = 22
        Me.lblTotalStyles.Text = "Total Styles"
        '
        'lblTotalFlavors
        '
        Me.lblTotalFlavors.AutoSize = True
        Me.lblTotalFlavors.Location = New System.Drawing.Point(11, 234)
        Me.lblTotalFlavors.Name = "lblTotalFlavors"
        Me.lblTotalFlavors.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalFlavors.TabIndex = 21
        Me.lblTotalFlavors.Text = "Total Flavors"
        '
        'txtTotalStyles
        '
        Me.txtTotalStyles.Location = New System.Drawing.Point(313, 231)
        Me.txtTotalStyles.Name = "txtTotalStyles"
        Me.txtTotalStyles.ReadOnly = True
        Me.txtTotalStyles.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalStyles.TabIndex = 20
        '
        'txtTotalFlavors
        '
        Me.txtTotalFlavors.Location = New System.Drawing.Point(81, 231)
        Me.txtTotalFlavors.Name = "txtTotalFlavors"
        Me.txtTotalFlavors.ReadOnly = True
        Me.txtTotalFlavors.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalFlavors.TabIndex = 19
        '
        'btnSubmitOrder
        '
        Me.btnSubmitOrder.Location = New System.Drawing.Point(248, 285)
        Me.btnSubmitOrder.Name = "btnSubmitOrder"
        Me.btnSubmitOrder.Size = New System.Drawing.Size(101, 27)
        Me.btnSubmitOrder.TabIndex = 18
        Me.btnSubmitOrder.Text = "Submit Order"
        Me.btnSubmitOrder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.Location = New System.Drawing.Point(132, 285)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 27)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtFlavor
        '
        Me.txtFlavor.Location = New System.Drawing.Point(100, 32)
        Me.txtFlavor.Name = "txtFlavor"
        Me.txtFlavor.ReadOnly = True
        Me.txtFlavor.Size = New System.Drawing.Size(167, 20)
        Me.txtFlavor.TabIndex = 18
        '
        'txtStyle
        '
        Me.txtStyle.Location = New System.Drawing.Point(100, 75)
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.ReadOnly = True
        Me.txtStyle.Size = New System.Drawing.Size(166, 20)
        Me.txtStyle.TabIndex = 19
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(100, 163)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(166, 20)
        Me.txtQuantity.TabIndex = 20
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(100, 116)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.ReadOnly = True
        Me.txtSize.Size = New System.Drawing.Size(166, 20)
        Me.txtSize.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Flavor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Style"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Quantity"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(145, 327)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(101, 27)
        Me.btnConfirm.TabIndex = 26
        Me.btnConfirm.Text = "Confirm Order"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'gbConfirm
        '
        Me.gbConfirm.Controls.Add(Me.PictureBox1)
        Me.gbConfirm.Controls.Add(Me.btnConfirm)
        Me.gbConfirm.Controls.Add(Me.Label4)
        Me.gbConfirm.Controls.Add(Me.Label3)
        Me.gbConfirm.Controls.Add(Me.Label2)
        Me.gbConfirm.Controls.Add(Me.Label1)
        Me.gbConfirm.Controls.Add(Me.txtSize)
        Me.gbConfirm.Controls.Add(Me.txtQuantity)
        Me.gbConfirm.Controls.Add(Me.txtStyle)
        Me.gbConfirm.Controls.Add(Me.txtFlavor)
        Me.gbConfirm.Location = New System.Drawing.Point(654, 12)
        Me.gbConfirm.Name = "gbConfirm"
        Me.gbConfirm.Size = New System.Drawing.Size(292, 382)
        Me.gbConfirm.TabIndex = 27
        Me.gbConfirm.TabStop = False
        Me.gbConfirm.Text = "Confirmation"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 214)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 98)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 518)
        Me.Controls.Add(Me.gbConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbConfirm.ResumeLayout(False)
        Me.gbConfirm.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents clbFlavors As CheckedListBox
    Friend WithEvents clbStyles As CheckedListBox
    Friend WithEvents lblTotalStyles As Label
    Friend WithEvents lblTotalFlavors As Label
    Friend WithEvents txtTotalStyles As TextBox
    Friend WithEvents txtTotalFlavors As TextBox
    Friend WithEvents btnSubmitOrder As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtFlavor As TextBox
    Friend WithEvents txtStyle As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents gbConfirm As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

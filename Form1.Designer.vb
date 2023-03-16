<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCapitales1 = New System.Windows.Forms.ComboBox()
        Me.cmbEstados1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCapitales2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEstados2 = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(690, 494)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(682, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Seleccionar Estado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(44, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estados de México y sus capitales"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbCapitales1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbEstados1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(37, 69)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.2!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.8!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(443, 125)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado"
        '
        'cmbCapitales1
        '
        Me.cmbCapitales1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCapitales1.Enabled = False
        Me.cmbCapitales1.FormattingEnabled = True
        Me.cmbCapitales1.Items.AddRange(New Object() {"Guanajuato", "Chilpancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza"})
        Me.cmbCapitales1.Location = New System.Drawing.Point(225, 43)
        Me.cmbCapitales1.Name = "cmbCapitales1"
        Me.cmbCapitales1.Size = New System.Drawing.Size(214, 28)
        Me.cmbCapitales1.TabIndex = 3
        '
        'cmbEstados1
        '
        Me.cmbEstados1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstados1.FormattingEnabled = True
        Me.cmbEstados1.Items.AddRange(New Object() {"Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "México", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla"})
        Me.cmbEstados1.Location = New System.Drawing.Point(4, 43)
        Me.cmbEstados1.Name = "cmbEstados1"
        Me.cmbEstados1.Size = New System.Drawing.Size(214, 28)
        Me.cmbEstados1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(225, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Capital"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(682, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Seleccionar Capital"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(64, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Estados de México y sus capitales"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCapitales2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbEstados2, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(64, 53)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.2!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.8!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(443, 125)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(4, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Estados"
        '
        'cmbCapitales2
        '
        Me.cmbCapitales2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCapitales2.FormattingEnabled = True
        Me.cmbCapitales2.Items.AddRange(New Object() {"Guanajuato", "Chilpancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza"})
        Me.cmbCapitales2.Location = New System.Drawing.Point(225, 43)
        Me.cmbCapitales2.Name = "cmbCapitales2"
        Me.cmbCapitales2.Size = New System.Drawing.Size(214, 28)
        Me.cmbCapitales2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(225, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 38)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Capital"
        '
        'cmbEstados2
        '
        Me.cmbEstados2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstados2.Enabled = False
        Me.cmbEstados2.FormattingEnabled = True
        Me.cmbEstados2.Items.AddRange(New Object() {"Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "México", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla"})
        Me.cmbEstados2.Location = New System.Drawing.Point(4, 43)
        Me.cmbEstados2.Name = "cmbEstados2"
        Me.cmbEstados2.Size = New System.Drawing.Size(214, 28)
        Me.cmbEstados2.TabIndex = 2
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 494)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Text = "Paises y Capitales"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmbCapitales1 As ComboBox
    Friend WithEvents cmbEstados1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCapitales2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstados2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

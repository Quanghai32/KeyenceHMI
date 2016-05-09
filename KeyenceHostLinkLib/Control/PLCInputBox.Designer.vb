<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLCInputBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
		Me.butWrite = New System.Windows.Forms.Button()
		Me.txtValue = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'butWrite
		'
		Me.butWrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.butWrite.Location = New System.Drawing.Point(123, 4)
		Me.butWrite.Name = "butWrite"
		Me.butWrite.Size = New System.Drawing.Size(38, 38)
		Me.butWrite.TabIndex = 1
		Me.butWrite.Text = "W"
		Me.butWrite.UseVisualStyleBackColor = True
		'
		'txtValue
		'
		Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtValue.Location = New System.Drawing.Point(4, 4)
		Me.txtValue.Name = "txtValue"
		Me.txtValue.ReadOnly = True
		Me.txtValue.Size = New System.Drawing.Size(113, 38)
		Me.txtValue.TabIndex = 2
		'
		'PLCInputBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.txtValue)
		Me.Controls.Add(Me.butWrite)
		Me.Name = "PLCInputBox"
		Me.Size = New System.Drawing.Size(164, 49)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents butWrite As System.Windows.Forms.Button
	Friend WithEvents txtValue As System.Windows.Forms.TextBox

End Class

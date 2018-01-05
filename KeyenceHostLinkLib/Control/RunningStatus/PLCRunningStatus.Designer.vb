<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLCRunningStatus
	Inherits PLCBaseControl

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
		Me.butRun = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'butRun
		'
		Me.butRun.Dock = System.Windows.Forms.DockStyle.Fill
		Me.butRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.butRun.Location = New System.Drawing.Point(0, 0)
		Me.butRun.Name = "butRun"
		Me.butRun.Size = New System.Drawing.Size(150, 49)
		Me.butRun.TabIndex = 0
		Me.butRun.Text = "Button1"
		Me.butRun.UseVisualStyleBackColor = True
		'
		'PLCRunningStatus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.butRun)
		Me.Name = "PLCRunningStatus"
		Me.Size = New System.Drawing.Size(150, 49)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents butRun As System.Windows.Forms.Button

End Class

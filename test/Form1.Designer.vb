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
		Me.components = New System.ComponentModel.Container()
		Me.HostlinkKeyence1 = New KeyenceHostLinkLib.HostlinkKeyence(Me.components)
		Me.PlcNumberBox1 = New KeyenceHostLinkLib.PLCNumberBox()
		Me.SuspendLayout()
		'
		'HostlinkKeyence1
		'
		Me.HostlinkKeyence1.Name = "HostlinkKeyence1"
		Me.HostlinkKeyence1.time = 100.0R
		'
		'PlcNumberBox1
		'
		Me.PlcNumberBox1.InputColor = System.Drawing.SystemColors.Control
		Me.PlcNumberBox1.Location = New System.Drawing.Point(41, 109)
		Me.PlcNumberBox1.Name = "PlcNumberBox1"
		Me.PlcNumberBox1.PLCLink = Nothing
		Me.PlcNumberBox1.Size = New System.Drawing.Size(178, 50)
		Me.PlcNumberBox1.TabIndex = 0
		Me.PlcNumberBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Controls.Add(Me.PlcNumberBox1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents HostlinkKeyence1 As KeyenceHostLinkLib.HostlinkKeyence
	Friend WithEvents PlcNumberBox1 As KeyenceHostLinkLib.PLCNumberBox

End Class

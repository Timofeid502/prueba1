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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(657, 56)
        Button1.Margin = New Padding(5, 5, 5, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 35)
        Button1.TabIndex = 0
        Button1.Text = "JOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(657, 116)
        Button2.Margin = New Padding(5, 5, 5, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 35)
        Button2.TabIndex = 1
        Button2.Text = "JAVIER"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(54, 225)
        Button3.Margin = New Padding(5, 5, 5, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 35)
        Button3.TabIndex = 2
        Button3.Text = "Actualizar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.YellowGreen
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(875, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.Blue
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 5, 5, 5)
        Name = "Form1"
        Text = "Prueba1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

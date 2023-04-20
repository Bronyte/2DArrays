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
        ListBox1 = New ListBox()
        Button_Array = New Button()
        Button_Clear = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(10, 9)
        ListBox1.Margin = New Padding(3, 2, 3, 2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(497, 364)
        ListBox1.TabIndex = 0
        ' 
        ' Button_Array
        ' 
        Button_Array.Location = New Point(228, 392)
        Button_Array.Margin = New Padding(3, 2, 3, 2)
        Button_Array.Name = "Button_Array"
        Button_Array.Size = New Size(82, 22)
        Button_Array.TabIndex = 1
        Button_Array.Text = "ARRAY"
        Button_Array.UseVisualStyleBackColor = True
        ' 
        ' Button_Clear
        ' 
        Button_Clear.Location = New Point(347, 392)
        Button_Clear.Margin = New Padding(3, 2, 3, 2)
        Button_Clear.Name = "Button_Clear"
        Button_Clear.Size = New Size(82, 22)
        Button_Clear.TabIndex = 1
        Button_Clear.Text = "CLEAR"
        Button_Clear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(517, 423)
        Controls.Add(Button_Clear)
        Controls.Add(Button_Array)
        Controls.Add(ListBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button_Array As Button
    Friend WithEvents Button_Clear As Button
End Class

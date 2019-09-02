<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.LblMean = New System.Windows.Forms.Label()
        Me.lblMeanOutput = New System.Windows.Forms.Label()
        Me.lblSD = New System.Windows.Forms.Label()
        Me.lblSdOutput = New System.Windows.Forms.Label()
        Me.lblMedOutput = New System.Windows.Forms.Label()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtES = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAboveMean = New System.Windows.Forms.TextBox()
        Me.ACondition = New System.Windows.Forms.Label()
        Me.BCondition = New System.Windows.Forms.Label()
        Me.CCondition = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DCondition = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(98, 115)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(588, 31)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = "67,87,84,78,90,70,71,72,54,65,67,59,86,76,77"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(98, 79)
        Me.lblInput.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(59, 25)
        Me.lblInput.TabIndex = 1
        Me.lblInput.Text = "Input"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 202)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Score"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(98, 329)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(6)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(588, 31)
        Me.txtOutput.TabIndex = 3
        '
        'LblMean
        '
        Me.LblMean.AutoSize = True
        Me.LblMean.Location = New System.Drawing.Point(92, 410)
        Me.LblMean.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblMean.Name = "LblMean"
        Me.LblMean.Size = New System.Drawing.Size(66, 25)
        Me.LblMean.TabIndex = 4
        Me.LblMean.Text = "Mean"
        '
        'lblMeanOutput
        '
        Me.lblMeanOutput.AutoSize = True
        Me.lblMeanOutput.Location = New System.Drawing.Point(288, 410)
        Me.lblMeanOutput.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMeanOutput.Name = "lblMeanOutput"
        Me.lblMeanOutput.Size = New System.Drawing.Size(24, 25)
        Me.lblMeanOutput.TabIndex = 5
        Me.lblMeanOutput.Text = "0"
        '
        'lblSD
        '
        Me.lblSD.AutoSize = True
        Me.lblSD.Location = New System.Drawing.Point(92, 471)
        Me.lblSD.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSD.Name = "lblSD"
        Me.lblSD.Size = New System.Drawing.Size(41, 25)
        Me.lblSD.TabIndex = 6
        Me.lblSD.Text = "SD"
        '
        'lblSdOutput
        '
        Me.lblSdOutput.AutoSize = True
        Me.lblSdOutput.Location = New System.Drawing.Point(288, 471)
        Me.lblSdOutput.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSdOutput.Name = "lblSdOutput"
        Me.lblSdOutput.Size = New System.Drawing.Size(24, 25)
        Me.lblSdOutput.TabIndex = 7
        Me.lblSdOutput.Text = "0"
        '
        'lblMedOutput
        '
        Me.lblMedOutput.AutoSize = True
        Me.lblMedOutput.Location = New System.Drawing.Point(288, 533)
        Me.lblMedOutput.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMedOutput.Name = "lblMedOutput"
        Me.lblMedOutput.Size = New System.Drawing.Size(24, 25)
        Me.lblMedOutput.TabIndex = 8
        Me.lblMedOutput.Text = "0"
        '
        'lblMedian
        '
        Me.lblMedian.AutoSize = True
        Me.lblMedian.Location = New System.Drawing.Point(92, 533)
        Me.lblMedian.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(83, 25)
        Me.lblMedian.TabIndex = 9
        Me.lblMedian.Text = "Median"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(288, 594)
        Me.lblN.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(24, 25)
        Me.lblN.TabIndex = 10
        Me.lblN.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 594)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "N"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(288, 656)
        Me.lblMax.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(24, 25)
        Me.lblMax.TabIndex = 12
        Me.lblMax.Text = "0"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(288, 717)
        Me.lblMin.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(24, 25)
        Me.lblMin.TabIndex = 13
        Me.lblMin.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 656)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Max Scores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 717)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Min Scores"
        '
        'txtES
        '
        Me.txtES.Location = New System.Drawing.Point(600, 440)
        Me.txtES.Margin = New System.Windows.Forms.Padding(6)
        Me.txtES.Multiline = True
        Me.txtES.Name = "txtES"
        Me.txtES.Size = New System.Drawing.Size(212, 398)
        Me.txtES.TabIndex = 16
        Me.txtES.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(594, 410)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Exam Scores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(910, 410)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Scores Above Mean"
        '
        'txtAboveMean
        '
        Me.txtAboveMean.Location = New System.Drawing.Point(916, 440)
        Me.txtAboveMean.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAboveMean.Multiline = True
        Me.txtAboveMean.Name = "txtAboveMean"
        Me.txtAboveMean.Size = New System.Drawing.Size(218, 398)
        Me.txtAboveMean.TabIndex = 19
        '
        'ACondition
        '
        Me.ACondition.AutoSize = True
        Me.ACondition.Location = New System.Drawing.Point(1406, 463)
        Me.ACondition.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ACondition.Name = "ACondition"
        Me.ACondition.Size = New System.Drawing.Size(123, 25)
        Me.ACondition.TabIndex = 20
        Me.ACondition.Text = "A Condition"
        '
        'BCondition
        '
        Me.BCondition.AutoSize = True
        Me.BCondition.Location = New System.Drawing.Point(1406, 514)
        Me.BCondition.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.BCondition.Name = "BCondition"
        Me.BCondition.Size = New System.Drawing.Size(123, 25)
        Me.BCondition.TabIndex = 21
        Me.BCondition.Text = "B Condition"
        '
        'CCondition
        '
        Me.CCondition.AutoSize = True
        Me.CCondition.Location = New System.Drawing.Point(1406, 571)
        Me.CCondition.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.CCondition.Name = "CCondition"
        Me.CCondition.Size = New System.Drawing.Size(124, 25)
        Me.CCondition.TabIndex = 22
        Me.CCondition.Text = "C Condition"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 298)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Sorted Array"
        '
        'DCondition
        '
        Me.DCondition.AutoSize = True
        Me.DCondition.Location = New System.Drawing.Point(1406, 633)
        Me.DCondition.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.DCondition.Name = "DCondition"
        Me.DCondition.Size = New System.Drawing.Size(124, 25)
        Me.DCondition.TabIndex = 24
        Me.DCondition.Text = "D Condition"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1245, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Minimum for A ="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1245, 514)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Minimum for B="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1245, 571)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Minimum for C="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1245, 633)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 25)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Minimum for D="
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1245, 689)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 25)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Score below is F"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1245, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Scoring Map"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DCondition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CCondition)
        Me.Controls.Add(Me.BCondition)
        Me.Controls.Add(Me.ACondition)
        Me.Controls.Add(Me.txtAboveMean)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtES)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.lblMedOutput)
        Me.Controls.Add(Me.lblSdOutput)
        Me.Controls.Add(Me.lblSD)
        Me.Controls.Add(Me.lblMeanOutput)
        Me.Controls.Add(Me.LblMean)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txtInput)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInput As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents LblMean As Label
    Friend WithEvents lblMeanOutput As Label
    Friend WithEvents lblSD As Label
    Friend WithEvents lblSdOutput As Label
    Friend WithEvents lblMedOutput As Label
    Friend WithEvents lblMedian As Label
    Friend WithEvents lblN As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtES As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAboveMean As TextBox
    Friend WithEvents ACondition As Label
    Friend WithEvents BCondition As Label
    Friend WithEvents CCondition As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DCondition As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
End Class

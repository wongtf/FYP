﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardTypeSelection
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
        Me.btnCreditCard = New System.Windows.Forms.Button()
        Me.btnDebitCard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreditCard
        '
        Me.btnCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditCard.Location = New System.Drawing.Point(71, 43)
        Me.btnCreditCard.Name = "btnCreditCard"
        Me.btnCreditCard.Size = New System.Drawing.Size(134, 61)
        Me.btnCreditCard.TabIndex = 0
        Me.btnCreditCard.Text = "Credit Card"
        Me.btnCreditCard.UseVisualStyleBackColor = True
        '
        'btnDebitCard
        '
        Me.btnDebitCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebitCard.Location = New System.Drawing.Point(71, 152)
        Me.btnDebitCard.Name = "btnDebitCard"
        Me.btnDebitCard.Size = New System.Drawing.Size(134, 61)
        Me.btnDebitCard.TabIndex = 1
        Me.btnDebitCard.Text = "Debit Card"
        Me.btnDebitCard.UseVisualStyleBackColor = True
        '
        'frmCardTypeSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDebitCard)
        Me.Controls.Add(Me.btnCreditCard)
        Me.Name = "frmCardTypeSelection"
        Me.Text = "Select Card Type"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreditCard As System.Windows.Forms.Button
    Friend WithEvents btnDebitCard As System.Windows.Forms.Button
End Class

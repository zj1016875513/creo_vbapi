﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_load
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_suppressFeat = New System.Windows.Forms.Button()
        Me.Btn_new = New System.Windows.Forms.Button()
        Me.Btn_Connect = New System.Windows.Forms.Button()
        Me.Btn_listFeat = New System.Windows.Forms.Button()
        Me.Btn_delFeat = New System.Windows.Forms.Button()
        Me.Btn_importFeatFromStep = New System.Windows.Forms.Button()
        Me.Rtb_featInfo = New System.Windows.Forms.RichTextBox()
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Rtb_featInfo, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(565, 466)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_suppressFeat, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_new, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_Connect, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_listFeat, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_delFeat, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_importFeatFromStep, 0, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(192, 458)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'Btn_suppressFeat
        '
        Me.Btn_suppressFeat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_suppressFeat.Enabled = False
        Me.Btn_suppressFeat.Location = New System.Drawing.Point(3, 307)
        Me.Btn_suppressFeat.Name = "Btn_suppressFeat"
        Me.Btn_suppressFeat.Size = New System.Drawing.Size(186, 70)
        Me.Btn_suppressFeat.TabIndex = 4
        Me.Btn_suppressFeat.Text = "确保打开一个prt，点此选择特征并隐含"
        Me.Btn_suppressFeat.UseVisualStyleBackColor = True
        '
        'Btn_new
        '
        Me.Btn_new.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_new.Location = New System.Drawing.Point(4, 4)
        Me.Btn_new.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_new.Name = "Btn_new"
        Me.Btn_new.Size = New System.Drawing.Size(184, 68)
        Me.Btn_new.TabIndex = 0
        Me.Btn_new.Text = "启动新会话"
        Me.Btn_new.UseVisualStyleBackColor = True
        '
        'Btn_Connect
        '
        Me.Btn_Connect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Connect.Location = New System.Drawing.Point(4, 80)
        Me.Btn_Connect.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Connect.Name = "Btn_Connect"
        Me.Btn_Connect.Size = New System.Drawing.Size(184, 68)
        Me.Btn_Connect.TabIndex = 1
        Me.Btn_Connect.Text = "连接现有会话"
        Me.Btn_Connect.UseVisualStyleBackColor = True
        '
        'Btn_listFeat
        '
        Me.Btn_listFeat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_listFeat.Enabled = False
        Me.Btn_listFeat.Location = New System.Drawing.Point(3, 155)
        Me.Btn_listFeat.Name = "Btn_listFeat"
        Me.Btn_listFeat.Size = New System.Drawing.Size(186, 70)
        Me.Btn_listFeat.TabIndex = 2
        Me.Btn_listFeat.Text = "确保打开一个prt，点此列出当前模型特征列表"
        Me.Btn_listFeat.UseVisualStyleBackColor = True
        '
        'Btn_delFeat
        '
        Me.Btn_delFeat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_delFeat.Enabled = False
        Me.Btn_delFeat.Location = New System.Drawing.Point(3, 231)
        Me.Btn_delFeat.Name = "Btn_delFeat"
        Me.Btn_delFeat.Size = New System.Drawing.Size(186, 70)
        Me.Btn_delFeat.TabIndex = 3
        Me.Btn_delFeat.Text = "确保打开一个prt，点此选择特征并删除"
        Me.Btn_delFeat.UseVisualStyleBackColor = True
        '
        'Btn_importFeatFromStep
        '
        Me.Btn_importFeatFromStep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_importFeatFromStep.Enabled = False
        Me.Btn_importFeatFromStep.Location = New System.Drawing.Point(3, 383)
        Me.Btn_importFeatFromStep.Name = "Btn_importFeatFromStep"
        Me.Btn_importFeatFromStep.Size = New System.Drawing.Size(186, 72)
        Me.Btn_importFeatFromStep.TabIndex = 5
        Me.Btn_importFeatFromStep.Text = "确保打开一个prt，点此打开一个step文件后在Creo窗口选择一个坐标系后导入"
        Me.Btn_importFeatFromStep.UseVisualStyleBackColor = True
        '
        'Rtb_featInfo
        '
        Me.Rtb_featInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rtb_featInfo.Location = New System.Drawing.Point(203, 3)
        Me.Rtb_featInfo.Name = "Rtb_featInfo"
        Me.Rtb_featInfo.ReadOnly = True
        Me.Rtb_featInfo.Size = New System.Drawing.Size(359, 460)
        Me.Rtb_featInfo.TabIndex = 5
        Me.Rtb_featInfo.Text = ""
        '
        'Ofd
        '
        Me.Ofd.Filter = "(*.stp;*.step)|*.stp;*.step"
        '
        'Frm_load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 466)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Frm_load"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Btn_new As Button
    Friend WithEvents Btn_Connect As Button
    Friend WithEvents Btn_listFeat As Button
    Friend WithEvents Rtb_featInfo As RichTextBox
    Friend WithEvents Btn_delFeat As Button
    Friend WithEvents Btn_suppressFeat As Button
    Friend WithEvents Btn_importFeatFromStep As Button
    Friend WithEvents Ofd As OpenFileDialog
End Class

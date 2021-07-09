Imports Microsoft.VisualBasic
Imports System
Namespace Grid_FormatRules
	Partial Public Class BarConditionForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.checkBox3 = New System.Windows.Forms.CheckBox()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.Panel1.SuspendLayout()
			CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.Panel2.SuspendLayout()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.Size = New System.Drawing.Size(1049, 486)
			Me.dashboardViewer1.TabIndex = 0
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Horizontal = False
			Me.splitContainerControl1.IsSplitterFixed = True
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			' 
			' splitContainerControl1.Panel1
			' 
			Me.splitContainerControl1.Panel1.Controls.Add(Me.checkBox3)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.checkBox2)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.checkBox1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			' 
			' splitContainerControl1.Panel2
			' 
			Me.splitContainerControl1.Panel2.Controls.Add(Me.dashboardViewer1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(1049, 545)
			Me.splitContainerControl1.SplitterPosition = 49
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' checkBox3
			' 
			Me.checkBox3.AutoSize = True
			Me.checkBox3.Location = New System.Drawing.Point(233, 12)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(94, 17)
			Me.checkBox3.TabIndex = 2
			Me.checkBox3.Text = "Show bar only"
			Me.checkBox3.UseVisualStyleBackColor = True
'			Me.checkBox3.CheckedChanged += New System.EventHandler(Me.checkBox3_CheckedChanged);
			' 
			' checkBox2
			' 
			Me.checkBox2.AutoSize = True
			Me.checkBox2.Location = New System.Drawing.Point(153, 12)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(73, 17)
			Me.checkBox2.TabIndex = 1
			Me.checkBox2.Text = "Draw axis"
			Me.checkBox2.UseVisualStyleBackColor = True
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox2_CheckedChanged);
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New System.Drawing.Point(12, 12)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(118, 17)
			Me.checkBox1.TabIndex = 0
			Me.checkBox1.Text = "Allow negative axis"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' BarConditionForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1049, 545)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "BarConditionForm"
			Me.Text = "Bar Format Rules"
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.Panel1.ResumeLayout(False)
			Me.splitContainerControl1.Panel1.PerformLayout()
			CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.Panel2.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox

	End Class
End Namespace


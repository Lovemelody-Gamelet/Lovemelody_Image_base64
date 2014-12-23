<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.txtSourceCode = New System.Windows.Forms.RichTextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnImagetoBase64 = New System.Windows.Forms.Button()
        Me.btnBase64ToImage = New System.Windows.Forms.Button()
        Me.lablelPicPreview = New System.Windows.Forms.GroupBox()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.Base64Copy = New System.Windows.Forms.Button()
        Me.LabelBase64 = New System.Windows.Forms.Label()
        Me.btnSetLang = New System.Windows.Forms.Button()
        Me.LangSelect = New System.Windows.Forms.ComboBox()
        Me.LangOpenFileFilter = New System.Windows.Forms.Label()
        Me.LangBase64ToImageErrorMsgbox = New System.Windows.Forms.Label()
        Me.LangBase64Error = New System.Windows.Forms.Label()
        Me.LangCopyedMsg = New System.Windows.Forms.Label()
        Me.HTMLPreview = New System.Windows.Forms.Button()
        Me.HTMLTitle = New System.Windows.Forms.Label()
        Me.HTMLSpan = New System.Windows.Forms.Label()
        Me.HTMLOriginal = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ButtonPlus = New System.Windows.Forms.Button()
        Me.ButtonMinus = New System.Windows.Forms.Button()
        Me.LabelOpaticy = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lablelPicPreview.SuspendLayout()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSourceCode
        '
        Me.txtSourceCode.Location = New System.Drawing.Point(11, 56)
        Me.txtSourceCode.Name = "txtSourceCode"
        Me.txtSourceCode.ReadOnly = True
        Me.txtSourceCode.Size = New System.Drawing.Size(431, 471)
        Me.txtSourceCode.TabIndex = 0
        Me.txtSourceCode.Text = ""
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(95, 8)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(432, 20)
        Me.txtPath.TabIndex = 1
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(19, 13)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(58, 13)
        Me.LabelPath.TabIndex = 2
        Me.LabelPath.Text = "圖片路徑:"
        Me.LabelPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(554, 8)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 25)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "打開圖片"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnImagetoBase64
        '
        Me.btnImagetoBase64.Location = New System.Drawing.Point(639, 8)
        Me.btnImagetoBase64.Name = "btnImagetoBase64"
        Me.btnImagetoBase64.Size = New System.Drawing.Size(116, 25)
        Me.btnImagetoBase64.TabIndex = 4
        Me.btnImagetoBase64.Text = "圖片轉換為Base64"
        Me.btnImagetoBase64.UseVisualStyleBackColor = True
        '
        'btnBase64ToImage
        '
        Me.btnBase64ToImage.Location = New System.Drawing.Point(758, 8)
        Me.btnBase64ToImage.Name = "btnBase64ToImage"
        Me.btnBase64ToImage.Size = New System.Drawing.Size(110, 25)
        Me.btnBase64ToImage.TabIndex = 5
        Me.btnBase64ToImage.Text = "Base64轉換為圖片"
        Me.btnBase64ToImage.UseVisualStyleBackColor = True
        '
        'lablelPicPreview
        '
        Me.lablelPicPreview.Controls.Add(Me.pbPreview)
        Me.lablelPicPreview.Location = New System.Drawing.Point(447, 39)
        Me.lablelPicPreview.Name = "lablelPicPreview"
        Me.lablelPicPreview.Size = New System.Drawing.Size(425, 492)
        Me.lablelPicPreview.TabIndex = 7
        Me.lablelPicPreview.TabStop = False
        Me.lablelPicPreview.Text = "圖片預覽"
        '
        'pbPreview
        '
        Me.pbPreview.Image = Global.Lovemelody_Image_base64.My.Resources.Resources.Lovemelody
        Me.pbPreview.Location = New System.Drawing.Point(2, 17)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(419, 469)
        Me.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPreview.TabIndex = 6
        Me.pbPreview.TabStop = False
        '
        'Base64Copy
        '
        Me.Base64Copy.Location = New System.Drawing.Point(13, 534)
        Me.Base64Copy.Name = "Base64Copy"
        Me.Base64Copy.Size = New System.Drawing.Size(429, 25)
        Me.Base64Copy.TabIndex = 8
        Me.Base64Copy.Text = "複製Base64 碼"
        Me.Base64Copy.UseVisualStyleBackColor = True
        '
        'LabelBase64
        '
        Me.LabelBase64.AutoSize = True
        Me.LabelBase64.Location = New System.Drawing.Point(12, 40)
        Me.LabelBase64.Name = "LabelBase64"
        Me.LabelBase64.Size = New System.Drawing.Size(58, 13)
        Me.LabelBase64.TabIndex = 9
        Me.LabelBase64.Text = "Base64碼:"
        '
        'btnSetLang
        '
        Me.btnSetLang.Location = New System.Drawing.Point(568, 533)
        Me.btnSetLang.Name = "btnSetLang"
        Me.btnSetLang.Size = New System.Drawing.Size(86, 25)
        Me.btnSetLang.TabIndex = 7
        Me.btnSetLang.Text = "設定語言"
        Me.btnSetLang.UseVisualStyleBackColor = True
        '
        'LangSelect
        '
        Me.LangSelect.FormattingEnabled = True
        Me.LangSelect.Items.AddRange(New Object() {"繁體中文", "English"})
        Me.LangSelect.Location = New System.Drawing.Point(449, 536)
        Me.LangSelect.Name = "LangSelect"
        Me.LangSelect.Size = New System.Drawing.Size(113, 21)
        Me.LangSelect.TabIndex = 10
        Me.LangSelect.Text = "繁體中文"
        '
        'LangOpenFileFilter
        '
        Me.LangOpenFileFilter.AutoSize = True
        Me.LangOpenFileFilter.Location = New System.Drawing.Point(22, 67)
        Me.LangOpenFileFilter.Name = "LangOpenFileFilter"
        Me.LangOpenFileFilter.Size = New System.Drawing.Size(55, 13)
        Me.LangOpenFileFilter.TabIndex = 11
        Me.LangOpenFileFilter.Text = "任何圖片"
        Me.LangOpenFileFilter.Visible = False
        '
        'LangBase64ToImageErrorMsgbox
        '
        Me.LangBase64ToImageErrorMsgbox.AutoSize = True
        Me.LangBase64ToImageErrorMsgbox.Location = New System.Drawing.Point(19, 80)
        Me.LangBase64ToImageErrorMsgbox.Name = "LangBase64ToImageErrorMsgbox"
        Me.LangBase64ToImageErrorMsgbox.Size = New System.Drawing.Size(106, 13)
        Me.LangBase64ToImageErrorMsgbox.TabIndex = 12
        Me.LangBase64ToImageErrorMsgbox.Text = "沒有任何Base64碼!"
        Me.LangBase64ToImageErrorMsgbox.Visible = False
        '
        'LangBase64Error
        '
        Me.LangBase64Error.AutoSize = True
        Me.LangBase64Error.Location = New System.Drawing.Point(19, 93)
        Me.LangBase64Error.Name = "LangBase64Error"
        Me.LangBase64Error.Size = New System.Drawing.Size(97, 13)
        Me.LangBase64Error.TabIndex = 13
        Me.LangBase64Error.Text = "不是Base64格式!!"
        Me.LangBase64Error.Visible = False
        '
        'LangCopyedMsg
        '
        Me.LangCopyedMsg.AutoSize = True
        Me.LangCopyedMsg.Location = New System.Drawing.Point(22, 106)
        Me.LangCopyedMsg.Name = "LangCopyedMsg"
        Me.LangCopyedMsg.Size = New System.Drawing.Size(55, 13)
        Me.LangCopyedMsg.TabIndex = 14
        Me.LangCopyedMsg.Text = "複製成功"
        Me.LangCopyedMsg.Visible = False
        '
        'HTMLPreview
        '
        Me.HTMLPreview.Location = New System.Drawing.Point(660, 533)
        Me.HTMLPreview.Name = "HTMLPreview"
        Me.HTMLPreview.Size = New System.Drawing.Size(115, 25)
        Me.HTMLPreview.TabIndex = 15
        Me.HTMLPreview.Text = "在網頁中檢視"
        Me.HTMLPreview.UseVisualStyleBackColor = True
        '
        'HTMLTitle
        '
        Me.HTMLTitle.AutoSize = True
        Me.HTMLTitle.Location = New System.Drawing.Point(22, 119)
        Me.HTMLTitle.Name = "HTMLTitle"
        Me.HTMLTitle.Size = New System.Drawing.Size(138, 13)
        Me.HTMLTitle.TabIndex = 16
        Me.HTMLTitle.Text = "戀愛の旋律♪ ~ 網頁預覽"
        Me.HTMLTitle.Visible = False
        '
        'HTMLSpan
        '
        Me.HTMLSpan.AutoSize = True
        Me.HTMLSpan.Location = New System.Drawing.Point(22, 132)
        Me.HTMLSpan.Name = "HTMLSpan"
        Me.HTMLSpan.Size = New System.Drawing.Size(127, 13)
        Me.HTMLSpan.TabIndex = 17
        Me.HTMLSpan.Text = "以下為圖片的Base64碼"
        Me.HTMLSpan.Visible = False
        '
        'HTMLOriginal
        '
        Me.HTMLOriginal.AutoSize = True
        Me.HTMLOriginal.Location = New System.Drawing.Point(22, 145)
        Me.HTMLOriginal.Name = "HTMLOriginal"
        Me.HTMLOriginal.Size = New System.Drawing.Size(79, 13)
        Me.HTMLOriginal.TabIndex = 18
        Me.HTMLOriginal.Text = "點我檢視原圖"
        Me.HTMLOriginal.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(879, 80)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 419)
        Me.TrackBar1.TabIndex = 19
        Me.TrackBar1.TabStop = False
        Me.TrackBar1.TickFrequency = 5
        '
        'ButtonPlus
        '
        Me.ButtonPlus.Location = New System.Drawing.Point(879, 506)
        Me.ButtonPlus.Name = "ButtonPlus"
        Me.ButtonPlus.Size = New System.Drawing.Size(20, 22)
        Me.ButtonPlus.TabIndex = 20
        Me.ButtonPlus.Text = "+"
        Me.ButtonPlus.UseVisualStyleBackColor = True
        '
        'ButtonMinus
        '
        Me.ButtonMinus.Location = New System.Drawing.Point(879, 52)
        Me.ButtonMinus.Name = "ButtonMinus"
        Me.ButtonMinus.Size = New System.Drawing.Size(20, 22)
        Me.ButtonMinus.TabIndex = 21
        Me.ButtonMinus.Text = "-"
        Me.ButtonMinus.UseVisualStyleBackColor = True
        '
        'LabelOpaticy
        '
        Me.LabelOpaticy.AutoSize = True
        Me.LabelOpaticy.Location = New System.Drawing.Point(877, 534)
        Me.LabelOpaticy.Name = "LabelOpaticy"
        Me.LabelOpaticy.Size = New System.Drawing.Size(33, 13)
        Me.LabelOpaticy.TabIndex = 22
        Me.LabelOpaticy.Text = "100%"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(781, 539)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(77, 13)
        Me.LinkLabel2.TabIndex = 24
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "戀愛の旋律♪"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 563)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LabelOpaticy)
        Me.Controls.Add(Me.ButtonMinus)
        Me.Controls.Add(Me.ButtonPlus)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.HTMLOriginal)
        Me.Controls.Add(Me.HTMLSpan)
        Me.Controls.Add(Me.HTMLTitle)
        Me.Controls.Add(Me.HTMLPreview)
        Me.Controls.Add(Me.LangCopyedMsg)
        Me.Controls.Add(Me.LangBase64Error)
        Me.Controls.Add(Me.LangBase64ToImageErrorMsgbox)
        Me.Controls.Add(Me.LangOpenFileFilter)
        Me.Controls.Add(Me.LangSelect)
        Me.Controls.Add(Me.btnSetLang)
        Me.Controls.Add(Me.LabelBase64)
        Me.Controls.Add(Me.Base64Copy)
        Me.Controls.Add(Me.lablelPicPreview)
        Me.Controls.Add(Me.btnBase64ToImage)
        Me.Controls.Add(Me.btnImagetoBase64)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.LabelPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtSourceCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "圖片<--->Base64 轉譯器 (戀愛の旋律♪製作 : http://goo.gl/E5kTUH )"
        Me.lablelPicPreview.ResumeLayout(False)
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSourceCode As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents LabelPath As System.Windows.Forms.Label
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnImagetoBase64 As System.Windows.Forms.Button
    Friend WithEvents btnBase64ToImage As System.Windows.Forms.Button
    Friend WithEvents lablelPicPreview As System.Windows.Forms.GroupBox
    Friend WithEvents pbPreview As System.Windows.Forms.PictureBox
    Friend WithEvents Base64Copy As System.Windows.Forms.Button
    Friend WithEvents LabelBase64 As System.Windows.Forms.Label
    Friend WithEvents btnSetLang As System.Windows.Forms.Button
    Friend WithEvents LangSelect As System.Windows.Forms.ComboBox
    Friend WithEvents LangOpenFileFilter As System.Windows.Forms.Label
    Friend WithEvents LangBase64ToImageErrorMsgbox As System.Windows.Forms.Label
    Friend WithEvents LangBase64Error As System.Windows.Forms.Label
    Friend WithEvents LangCopyedMsg As System.Windows.Forms.Label
    Friend WithEvents HTMLPreview As System.Windows.Forms.Button
    Friend WithEvents HTMLTitle As System.Windows.Forms.Label
    Friend WithEvents HTMLSpan As System.Windows.Forms.Label
    Friend WithEvents HTMLOriginal As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents ButtonPlus As System.Windows.Forms.Button
    Friend WithEvents ButtonMinus As System.Windows.Forms.Button
    Friend WithEvents LabelOpaticy As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel

End Class

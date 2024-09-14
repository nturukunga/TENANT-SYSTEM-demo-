<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFrm))
        Panel1 = New Panel()
        TxtUsername = New TextBox()
        UsrIcon = New PictureBox()
        Panel2 = New Panel()
        TxtPassword = New TextBox()
        PassIcon = New PictureBox()
        LoginBtn = New Button()
        ExitBtn = New Button()
        LogIcon = New PictureBox()
        SgnInLbl = New Label()
        Panel1.SuspendLayout()
        CType(UsrIcon, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(LogIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TxtUsername)
        Panel1.Controls.Add(UsrIcon)
        Panel1.Location = New Point(196, 239)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(329, 67)
        Panel1.TabIndex = 2
        ' 
        ' TxtUsername
        ' 
        TxtUsername.BorderStyle = BorderStyle.None
        TxtUsername.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtUsername.Location = New Point(65, 19)
        TxtUsername.Multiline = True
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(258, 31)
        TxtUsername.TabIndex = 3
        ' 
        ' UsrIcon
        ' 
        UsrIcon.Image = CType(resources.GetObject("UsrIcon.Image"), Image)
        UsrIcon.Location = New Point(4, 6)
        UsrIcon.Name = "UsrIcon"
        UsrIcon.Size = New Size(58, 54)
        UsrIcon.SizeMode = PictureBoxSizeMode.StretchImage
        UsrIcon.TabIndex = 3
        UsrIcon.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TxtPassword)
        Panel2.Controls.Add(PassIcon)
        Panel2.Location = New Point(196, 312)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(329, 67)
        Panel2.TabIndex = 4
        ' 
        ' TxtPassword
        ' 
        TxtPassword.BorderStyle = BorderStyle.None
        TxtPassword.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPassword.Location = New Point(65, 19)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(258, 24)
        TxtPassword.TabIndex = 3
        ' 
        ' PassIcon
        ' 
        PassIcon.Image = CType(resources.GetObject("PassIcon.Image"), Image)
        PassIcon.Location = New Point(4, 6)
        PassIcon.Name = "PassIcon"
        PassIcon.Size = New Size(58, 54)
        PassIcon.SizeMode = PictureBoxSizeMode.StretchImage
        PassIcon.TabIndex = 3
        PassIcon.TabStop = False
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Pink
        LoginBtn.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(261, 406)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(217, 55)
        LoginBtn.TabIndex = 5
        LoginBtn.Text = "Log In"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackColor = Color.Pink
        ExitBtn.Font = New Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExitBtn.Location = New Point(261, 467)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(217, 55)
        ExitBtn.TabIndex = 6
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = False
        ' 
        ' LogIcon
        ' 
        LogIcon.Image = CType(resources.GetObject("LogIcon.Image"), Image)
        LogIcon.Location = New Point(261, 12)
        LogIcon.Name = "LogIcon"
        LogIcon.Size = New Size(217, 162)
        LogIcon.SizeMode = PictureBoxSizeMode.StretchImage
        LogIcon.TabIndex = 7
        LogIcon.TabStop = False
        ' 
        ' SgnInLbl
        ' 
        SgnInLbl.AutoSize = True
        SgnInLbl.BackColor = Color.Black
        SgnInLbl.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SgnInLbl.ForeColor = SystemColors.ButtonFace
        SgnInLbl.Location = New Point(330, 188)
        SgnInLbl.Name = "SgnInLbl"
        SgnInLbl.Size = New Size(81, 28)
        SgnInLbl.TabIndex = 8
        SgnInLbl.Text = "Sign In"
        ' 
        ' LoginFrm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(730, 587)
        Controls.Add(SgnInLbl)
        Controls.Add(LogIcon)
        Controls.Add(ExitBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginFrm"
        Text = "LOGIN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UsrIcon, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PassIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(LogIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents UsrIcon As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PassIcon As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LogIcon As PictureBox
    Friend WithEvents SgnInLbl As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents ExitBtn As Button

End Class

Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Public Class frmMenu
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnpMaintenance As System.Windows.Forms.MenuItem
    Friend WithEvents mnpFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnpSetup As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileLogoff As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetupJob As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetupData As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetupBank As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSeparator1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetupSeparator1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnpReport As System.Windows.Forms.MenuItem
    Friend WithEvents mnpHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnpUser As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuUserPassword As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterSegment As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterColorData As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterEmbossing As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterEncodeData As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterIndentation As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterMailer As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterSMC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterUltragrafix As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSecurityUser As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterHeader As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMasterFooter As System.Windows.Forms.MenuItem
    Friend WithEvents lbJob As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbAlgorithm As System.Windows.Forms.Label
    Friend WithEvents lbBIN As System.Windows.Forms.Label
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbTotalOUTPUT As System.Windows.Forms.Label
    Friend WithEvents lbTotalINPUT As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher2 As System.IO.FileSystemWatcher
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportHouseKeep As System.Windows.Forms.MenuItem
    Friend WithEvents lbInput As System.Windows.Forms.LinkLabel
    Friend WithEvents lbOutput As System.Windows.Forms.LinkLabel
    Friend WithEvents lbRoot As System.Windows.Forms.LinkLabel
    Friend WithEvents mnuSecurityGroups As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSecurityMenus As System.Windows.Forms.MenuItem
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportSetup As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileScan As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFilePrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportEmboss As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportCourier As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportSummary As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileException As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportExceptions As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportRegister As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportReconciliation As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileRevException As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportCourierChange As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnuReportMissing As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSearch As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDataConversion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCardRetrievalList As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetupUploadFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportConversion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportAuditLog As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileDeletion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrintMailer As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCorpMailerPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSetupFormat As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnpFile = New System.Windows.Forms.MenuItem
        Me.mnuDataConversion = New System.Windows.Forms.MenuItem
        Me.mnuFileOpen = New System.Windows.Forms.MenuItem
        Me.mnuPrintMailer = New System.Windows.Forms.MenuItem
        Me.mnuFilePrint = New System.Windows.Forms.MenuItem
        Me.mnuFileScan = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.mnuFileException = New System.Windows.Forms.MenuItem
        Me.mnuFileRevException = New System.Windows.Forms.MenuItem
        Me.mnuFileSeparator1 = New System.Windows.Forms.MenuItem
        Me.mnuFileSearch = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.mnuFileLogoff = New System.Windows.Forms.MenuItem
        Me.mnuFileExit = New System.Windows.Forms.MenuItem
        Me.mnpSetup = New System.Windows.Forms.MenuItem
        Me.mnuSetupJob = New System.Windows.Forms.MenuItem
        Me.mnuSetupSeparator1 = New System.Windows.Forms.MenuItem
        Me.mnuSetupData = New System.Windows.Forms.MenuItem
        Me.mnuSetupFormat = New System.Windows.Forms.MenuItem
        Me.mnuSetupBank = New System.Windows.Forms.MenuItem
        Me.mnuSetupUploadFile = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.mnuReportSetup = New System.Windows.Forms.MenuItem
        Me.mnpMaintenance = New System.Windows.Forms.MenuItem
        Me.mnuMasterSegment = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnuMasterHeader = New System.Windows.Forms.MenuItem
        Me.mnuMasterColorData = New System.Windows.Forms.MenuItem
        Me.mnuMasterEmbossing = New System.Windows.Forms.MenuItem
        Me.mnuMasterEncodeData = New System.Windows.Forms.MenuItem
        Me.mnuMasterIndentation = New System.Windows.Forms.MenuItem
        Me.mnuMasterMailer = New System.Windows.Forms.MenuItem
        Me.mnuMasterSMC = New System.Windows.Forms.MenuItem
        Me.mnuMasterUltragrafix = New System.Windows.Forms.MenuItem
        Me.mnuMasterFooter = New System.Windows.Forms.MenuItem
        Me.mnpReport = New System.Windows.Forms.MenuItem
        Me.mnuReportHouseKeep = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuReportConversion = New System.Windows.Forms.MenuItem
        Me.mnuReportEmboss = New System.Windows.Forms.MenuItem
        Me.mnuReportCourier = New System.Windows.Forms.MenuItem
        Me.mnuReportExceptions = New System.Windows.Forms.MenuItem
        Me.mnuReportReconciliation = New System.Windows.Forms.MenuItem
        Me.mnuReportCourierChange = New System.Windows.Forms.MenuItem
        Me.mnuReportSummary = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.mnuReportAuditLog = New System.Windows.Forms.MenuItem
        Me.mnuReportRegister = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.mnuReportMissing = New System.Windows.Forms.MenuItem
        Me.mnuCardRetrievalList = New System.Windows.Forms.MenuItem
        Me.mnpUser = New System.Windows.Forms.MenuItem
        Me.mnuUserPassword = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuSecurityUser = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.mnuSecurityMenus = New System.Windows.Forms.MenuItem
        Me.mnuSecurityGroups = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.mnuFileDeletion = New System.Windows.Forms.MenuItem
        Me.mnpHelp = New System.Windows.Forms.MenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
        Me.StatusBar = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.lbJob = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lbAlgorithm = New System.Windows.Forms.Label
        Me.lbBIN = New System.Windows.Forms.Label
        Me.lbName = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.lbTotalOUTPUT = New System.Windows.Forms.Label
        Me.lbTotalINPUT = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.FileSystemWatcher2 = New System.IO.FileSystemWatcher
        Me.lbInput = New System.Windows.Forms.LinkLabel
        Me.lbOutput = New System.Windows.Forms.LinkLabel
        Me.lbRoot = New System.Windows.Forms.LinkLabel
        Me.Label11 = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.mnuCorpMailerPrint = New System.Windows.Forms.MenuItem
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnpFile, Me.mnpSetup, Me.mnpMaintenance, Me.mnpReport, Me.mnpUser, Me.mnpHelp})
        '
        'mnpFile
        '
        Me.mnpFile.Index = 0
        Me.mnpFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDataConversion, Me.mnuFileOpen, Me.mnuPrintMailer, Me.mnuCorpMailerPrint, Me.mnuFilePrint, Me.mnuFileScan, Me.MenuItem7, Me.mnuFileException, Me.mnuFileRevException, Me.mnuFileSeparator1, Me.mnuFileSearch, Me.MenuItem11, Me.mnuFileLogoff, Me.mnuFileExit})
        Me.mnpFile.Text = "File"
        '
        'mnuDataConversion
        '
        Me.mnuDataConversion.Index = 0
        Me.mnuDataConversion.Text = "Data Conversion"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Index = 1
        Me.mnuFileOpen.Text = "Load File"
        '
        'mnuPrintMailer
        '
        Me.mnuPrintMailer.Index = 2
        Me.mnuPrintMailer.Text = "Print Mailer"
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Index = 4
        Me.mnuFilePrint.Text = "Print CN"
        '
        'mnuFileScan
        '
        Me.mnuFileScan.Index = 5
        Me.mnuFileScan.Text = "Scan CN"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "-"
        '
        'mnuFileException
        '
        Me.mnuFileException.Index = 7
        Me.mnuFileException.Text = "Exception List"
        '
        'mnuFileRevException
        '
        Me.mnuFileRevException.Index = 8
        Me.mnuFileRevException.Text = "Reverse Exception"
        '
        'mnuFileSeparator1
        '
        Me.mnuFileSeparator1.Index = 9
        Me.mnuFileSeparator1.Text = "-"
        '
        'mnuFileSearch
        '
        Me.mnuFileSearch.Index = 10
        Me.mnuFileSearch.Text = "Search Record"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 11
        Me.MenuItem11.Text = "-"
        '
        'mnuFileLogoff
        '
        Me.mnuFileLogoff.Index = 12
        Me.mnuFileLogoff.Text = "Log Off"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 13
        Me.mnuFileExit.Text = "Exit"
        '
        'mnpSetup
        '
        Me.mnpSetup.Index = 1
        Me.mnpSetup.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSetupJob, Me.mnuSetupSeparator1, Me.mnuSetupData, Me.mnuSetupFormat, Me.mnuSetupBank, Me.mnuSetupUploadFile, Me.MenuItem5, Me.mnuReportSetup})
        Me.mnpSetup.Text = "Setup"
        '
        'mnuSetupJob
        '
        Me.mnuSetupJob.Index = 0
        Me.mnuSetupJob.Text = "Job Setup"
        '
        'mnuSetupSeparator1
        '
        Me.mnuSetupSeparator1.Index = 1
        Me.mnuSetupSeparator1.Text = "-"
        '
        'mnuSetupData
        '
        Me.mnuSetupData.Index = 2
        Me.mnuSetupData.Text = "Card Setup"
        '
        'mnuSetupFormat
        '
        Me.mnuSetupFormat.Index = 3
        Me.mnuSetupFormat.Text = "Data Setup"
        '
        'mnuSetupBank
        '
        Me.mnuSetupBank.Index = 4
        Me.mnuSetupBank.Text = "Bank"
        '
        'mnuSetupUploadFile
        '
        Me.mnuSetupUploadFile.Index = 5
        Me.mnuSetupUploadFile.Text = "Upload File Setup"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "-"
        '
        'mnuReportSetup
        '
        Me.mnuReportSetup.Index = 7
        Me.mnuReportSetup.Text = "Report Setup"
        '
        'mnpMaintenance
        '
        Me.mnpMaintenance.Index = 2
        Me.mnpMaintenance.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMasterSegment, Me.MenuItem2, Me.mnuMasterHeader, Me.mnuMasterColorData, Me.mnuMasterEmbossing, Me.mnuMasterEncodeData, Me.mnuMasterIndentation, Me.mnuMasterMailer, Me.mnuMasterSMC, Me.mnuMasterUltragrafix, Me.mnuMasterFooter})
        Me.mnpMaintenance.Text = "Master"
        Me.mnpMaintenance.Visible = False
        '
        'mnuMasterSegment
        '
        Me.mnuMasterSegment.Index = 0
        Me.mnuMasterSegment.Text = "Segment"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'mnuMasterHeader
        '
        Me.mnuMasterHeader.Index = 2
        Me.mnuMasterHeader.Text = "Header"
        '
        'mnuMasterColorData
        '
        Me.mnuMasterColorData.Index = 3
        Me.mnuMasterColorData.Text = "ColorData"
        '
        'mnuMasterEmbossing
        '
        Me.mnuMasterEmbossing.Index = 4
        Me.mnuMasterEmbossing.Text = "Embossing"
        '
        'mnuMasterEncodeData
        '
        Me.mnuMasterEncodeData.Index = 5
        Me.mnuMasterEncodeData.Text = "EncodeData"
        '
        'mnuMasterIndentation
        '
        Me.mnuMasterIndentation.Index = 6
        Me.mnuMasterIndentation.Text = "Indentation"
        '
        'mnuMasterMailer
        '
        Me.mnuMasterMailer.Index = 7
        Me.mnuMasterMailer.Text = "Mailer"
        '
        'mnuMasterSMC
        '
        Me.mnuMasterSMC.Index = 8
        Me.mnuMasterSMC.Text = "SMC"
        '
        'mnuMasterUltragrafix
        '
        Me.mnuMasterUltragrafix.Index = 9
        Me.mnuMasterUltragrafix.Text = "Ultragrafix"
        '
        'mnuMasterFooter
        '
        Me.mnuMasterFooter.Index = 10
        Me.mnuMasterFooter.Text = "Footer"
        '
        'mnpReport
        '
        Me.mnpReport.Index = 3
        Me.mnpReport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuReportHouseKeep, Me.MenuItem3, Me.mnuReportConversion, Me.mnuReportEmboss, Me.mnuReportCourier, Me.mnuReportExceptions, Me.mnuReportReconciliation, Me.mnuReportCourierChange, Me.mnuReportSummary, Me.MenuItem8, Me.mnuReportAuditLog, Me.mnuReportRegister, Me.MenuItem10, Me.mnuReportMissing, Me.mnuCardRetrievalList})
        Me.mnpReport.Text = "Report"
        '
        'mnuReportHouseKeep
        '
        Me.mnuReportHouseKeep.Index = 0
        Me.mnuReportHouseKeep.Text = "HouseKeeping"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'mnuReportConversion
        '
        Me.mnuReportConversion.Index = 2
        Me.mnuReportConversion.Text = "Conversion Report"
        '
        'mnuReportEmboss
        '
        Me.mnuReportEmboss.Index = 3
        Me.mnuReportEmboss.Text = "Embossing Report"
        '
        'mnuReportCourier
        '
        Me.mnuReportCourier.Index = 4
        Me.mnuReportCourier.Text = "Courier Report"
        '
        'mnuReportExceptions
        '
        Me.mnuReportExceptions.Index = 5
        Me.mnuReportExceptions.Text = "Exceptions Report"
        '
        'mnuReportReconciliation
        '
        Me.mnuReportReconciliation.Index = 6
        Me.mnuReportReconciliation.Text = "Reconciliation Report"
        '
        'mnuReportCourierChange
        '
        Me.mnuReportCourierChange.Index = 7
        Me.mnuReportCourierChange.Text = "Courier Change Report"
        '
        'mnuReportSummary
        '
        Me.mnuReportSummary.Index = 8
        Me.mnuReportSummary.Text = "Summary Report"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 9
        Me.MenuItem8.Text = "-"
        '
        'mnuReportAuditLog
        '
        Me.mnuReportAuditLog.Index = 10
        Me.mnuReportAuditLog.Text = "Audit Log Report"
        '
        'mnuReportRegister
        '
        Me.mnuReportRegister.Index = 11
        Me.mnuReportRegister.Text = "Issuer Register"
        Me.mnuReportRegister.Visible = False
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 12
        Me.MenuItem10.Text = "-"
        '
        'mnuReportMissing
        '
        Me.mnuReportMissing.Index = 13
        Me.mnuReportMissing.Text = "Missing Card Report"
        '
        'mnuCardRetrievalList
        '
        Me.mnuCardRetrievalList.Index = 14
        Me.mnuCardRetrievalList.Text = "Card Retrieval List"
        '
        'mnpUser
        '
        Me.mnpUser.Index = 4
        Me.mnpUser.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuUserPassword, Me.MenuItem1, Me.mnuSecurityUser, Me.MenuItem4, Me.mnuSecurityMenus, Me.mnuSecurityGroups, Me.MenuItem9, Me.mnuFileDeletion})
        Me.mnpUser.Text = "Security"
        '
        'mnuUserPassword
        '
        Me.mnuUserPassword.Index = 0
        Me.mnuUserPassword.Text = "Change Password"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "-"
        '
        'mnuSecurityUser
        '
        Me.mnuSecurityUser.Index = 2
        Me.mnuSecurityUser.Text = "User"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "-"
        '
        'mnuSecurityMenus
        '
        Me.mnuSecurityMenus.Index = 4
        Me.mnuSecurityMenus.Text = "Access Group"
        '
        'mnuSecurityGroups
        '
        Me.mnuSecurityGroups.Index = 5
        Me.mnuSecurityGroups.Text = "Access Menu"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 6
        Me.MenuItem9.Text = "-"
        '
        'mnuFileDeletion
        '
        Me.mnuFileDeletion.Index = 7
        Me.mnuFileDeletion.Text = "File Deletion"
        '
        'mnpHelp
        '
        Me.mnpHelp.Index = 5
        Me.mnpHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpAbout})
        Me.mnpHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 0
        Me.mnuHelpAbout.Text = "About"
        '
        'StatusBar
        '
        Me.StatusBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.Location = New System.Drawing.Point(0, 498)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar.ShowPanels = True
        Me.StatusBar.Size = New System.Drawing.Size(833, 23)
        Me.StatusBar.TabIndex = 0
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 616
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 200
        '
        'lbJob
        '
        Me.lbJob.AutoSize = True
        Me.lbJob.BackColor = System.Drawing.Color.Transparent
        Me.lbJob.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJob.ForeColor = System.Drawing.Color.Black
        Me.lbJob.Location = New System.Drawing.Point(28, 244)
        Me.lbJob.Name = "lbJob"
        Me.lbJob.Size = New System.Drawing.Size(0, 14)
        Me.lbJob.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(28, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(326, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Job associated with this bank:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(488, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 23)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = " :"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(488, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 23)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = " :"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(364, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 23)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "File OUTPUT folder"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(364, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 23)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "File INPUT folder"
        '
        'lbAlgorithm
        '
        Me.lbAlgorithm.BackColor = System.Drawing.Color.Transparent
        Me.lbAlgorithm.ForeColor = System.Drawing.Color.White
        Me.lbAlgorithm.Location = New System.Drawing.Point(155, 136)
        Me.lbAlgorithm.Name = "lbAlgorithm"
        Me.lbAlgorithm.Size = New System.Drawing.Size(168, 23)
        Me.lbAlgorithm.TabIndex = 32
        Me.lbAlgorithm.Text = "-N/A-"
        '
        'lbBIN
        '
        Me.lbBIN.BackColor = System.Drawing.Color.Transparent
        Me.lbBIN.ForeColor = System.Drawing.Color.White
        Me.lbBIN.Location = New System.Drawing.Point(155, 104)
        Me.lbBIN.Name = "lbBIN"
        Me.lbBIN.Size = New System.Drawing.Size(168, 23)
        Me.lbBIN.TabIndex = 31
        Me.lbBIN.Text = "-N/A-"
        '
        'lbName
        '
        Me.lbName.BackColor = System.Drawing.Color.Transparent
        Me.lbName.ForeColor = System.Drawing.Color.White
        Me.lbName.Location = New System.Drawing.Point(155, 72)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(168, 23)
        Me.lbName.TabIndex = 30
        Me.lbName.Text = "-N/A-"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(488, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = " :"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(135, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = " :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(135, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = " :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(135, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = " :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(364, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Root folder"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "File algorithm"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Bank BIN"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Bank name"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(28, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(298, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Bank information:"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'lbTotalOUTPUT
        '
        Me.lbTotalOUTPUT.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalOUTPUT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalOUTPUT.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbTotalOUTPUT.Location = New System.Drawing.Point(508, 219)
        Me.lbTotalOUTPUT.Name = "lbTotalOUTPUT"
        Me.lbTotalOUTPUT.Size = New System.Drawing.Size(47, 23)
        Me.lbTotalOUTPUT.TabIndex = 48
        Me.lbTotalOUTPUT.Text = "0"
        Me.lbTotalOUTPUT.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbTotalINPUT
        '
        Me.lbTotalINPUT.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalINPUT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalINPUT.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbTotalINPUT.Location = New System.Drawing.Point(508, 191)
        Me.lbTotalINPUT.Name = "lbTotalINPUT"
        Me.lbTotalINPUT.Size = New System.Drawing.Size(47, 23)
        Me.lbTotalINPUT.TabIndex = 47
        Me.lbTotalINPUT.Text = "0"
        Me.lbTotalINPUT.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(488, 220)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 23)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = " :"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label18.Location = New System.Drawing.Point(488, 192)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 23)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = " :"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label19.Location = New System.Drawing.Point(360, 220)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 23)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Total OUTPUT file"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label20.Location = New System.Drawing.Point(360, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 23)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Total INPUT file"
        '
        'FileSystemWatcher2
        '
        Me.FileSystemWatcher2.EnableRaisingEvents = True
        Me.FileSystemWatcher2.SynchronizingObject = Me
        '
        'lbInput
        '
        Me.lbInput.LinkColor = System.Drawing.Color.MidnightBlue
        Me.lbInput.Location = New System.Drawing.Point(508, 104)
        Me.lbInput.Name = "lbInput"
        Me.lbInput.Size = New System.Drawing.Size(321, 26)
        Me.lbInput.TabIndex = 49
        Me.lbInput.TabStop = True
        Me.lbInput.Text = "-N/A-"
        '
        'lbOutput
        '
        Me.lbOutput.LinkColor = System.Drawing.Color.MidnightBlue
        Me.lbOutput.Location = New System.Drawing.Point(508, 136)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(321, 26)
        Me.lbOutput.TabIndex = 50
        Me.lbOutput.TabStop = True
        Me.lbOutput.Text = "-N/A-"
        '
        'lbRoot
        '
        Me.lbRoot.LinkColor = System.Drawing.Color.MidnightBlue
        Me.lbRoot.Location = New System.Drawing.Point(508, 72)
        Me.lbRoot.Name = "lbRoot"
        Me.lbRoot.Size = New System.Drawing.Size(321, 26)
        Me.lbRoot.TabIndex = 51
        Me.lbRoot.TabStop = True
        Me.lbRoot.Text = "-N/A-"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(1, 474)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(930, 14)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = resources.GetString("Label11.Text")
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(776, 422)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(45, 45)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 52
        Me.picLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(628, 434)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'mnuCorpMailerPrint
        '
        Me.mnuCorpMailerPrint.Index = 3
        Me.mnuCorpMailerPrint.Text = "Print Corporate Mailer"
        '
        'frmMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(833, 521)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbRoot)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.lbInput)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.lbTotalOUTPUT)
        Me.Controls.Add(Me.lbTotalINPUT)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbJob)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lbAlgorithm)
        Me.Controls.Add(Me.lbBIN)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DPS + Reporting System "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim boolLogOff As Boolean

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim szLastLogin As String
            szLastLogin = Mid(UserInfo.LastLogin, 7, 2) & "/" & Mid(UserInfo.LastLogin, 5, 2) & "/" & Mid(UserInfo.LastLogin, 1, 4) & " " & _
                          Mid(UserInfo.LastLogin, 9, 2) & ":" & Mid(UserInfo.LastLogin, 11, 2) & ":" & Mid(UserInfo.LastLogin, 13, 2)

            StatusBar.Panels(0).Text = "Welcome " & UserInfo.Name & ". Your last login to the system is on " & szLastLogin & "."
            StatusBar.Panels(1).Text = "Connected: " & gszServerName

            boolLogOff = False

            'Assign the user access right 
            DisableAllMenu()
            AssignUserRights(UserInfo.GroupId)

            Dim szError As String = ""

            'Determine if the user is an admin, and control function accessibility
            If (GetBankInfo(UserInfo.BankId, BankInfo, szError) = False) Then
                MessageBox.Show("Fail to retrieve bank information for this user. " & szError, "Warning", MessageBoxButtons.OK)
                Application.Exit()
            Else
                Me.Text = "DPS + Report Tool-" & BankInfo.BankName & " v" & Application.ProductVersion.ToString

                lbName.Text = BankInfo.BankName
                lbBIN.Text = BankInfo.Bin

                Select Case BankInfo.Algorithm
                    Case BANK_ENCRYPT_ALGORITHM.PLAINTEXT
                        lbAlgorithm.Text = "Plain Text"
                    Case BANK_ENCRYPT_ALGORITHM.DCQSS
                        lbAlgorithm.Text = "DCQSS"
                    Case Else
                        lbAlgorithm.Text = "Unknown"
                End Select

                Dim szFileName As String
                szFileName = gszWorkDrive & "LOGO\" & BankInfo.Logo

                If (IsFileExist(szFileName) = True) Then
                    picLogo.Visible = True
                    picLogo.Image = Image.FromFile(szFileName)
                Else
                    picLogo.Visible = False
                End If

                If (IsFolderExist(BankInfo.Folder_Backup) = False) Then
                    Directory.CreateDirectory(BankInfo.Folder_Backup)
                End If

                If (IsFolderExist(BankInfo.Folder_Error) = False) Then
                    Directory.CreateDirectory(BankInfo.Folder_Error)
                End If

                If (IsFolderExist(BankInfo.Folder_Input) = False) Then
                    Directory.CreateDirectory(BankInfo.Folder_Input)
                End If

                If (IsFolderExist(BankInfo.Folder_Ready) = False) Then
                    Directory.CreateDirectory(BankInfo.Folder_Ready)
                End If

                lbRoot.Text = BankInfo.Folder_Root
                lbInput.Text = BankInfo.Folder_Input
                lbOutput.Text = BankInfo.Folder_Ready

                LoadJobList()

                'Tracking file movement in INPUT and OUTPUT folder
                Dim szFileCollection() As String
                Dim dwIndex As Integer

                If (IsFolderExist(BankInfo.Folder_Input) = True) Then
                    szFileCollection = Directory.GetFiles(BankInfo.Folder_Input)
                    lbTotalINPUT.Text = UBound(szFileCollection) + 1

                    FileSystemWatcher1.Path = BankInfo.Folder_Input
                    FileSystemWatcher1.EnableRaisingEvents = True
                Else
                    lbTotalINPUT.Text = "0"
                End If

                If (IsFolderExist(BankInfo.Folder_Ready) = True) Then
                    szFileCollection = Directory.GetFiles(BankInfo.Folder_Ready)
                    lbTotalOUTPUT.Text = UBound(szFileCollection) + 1

                    FileSystemWatcher2.Path = BankInfo.Folder_Ready
                    FileSystemWatcher2.EnableRaisingEvents = True
                Else
                    lbTotalOUTPUT.Text = "0"
                End If

                'Add by SY
                'Check the report setup for menu display
                Dim MenuItemRep() As MenuItem
                If GetReportInfo(UserInfo.BankId) Then

                    If (UBound(arReportInfo) > 0) Then
                        ReDim Preserve MenuItemRep(UBound(arReportInfo))
                        For dwIndex = 1 To UBound(arReportInfo)
                            MenuItemRep(dwIndex) = New MenuItem(arReportInfo(dwIndex).MenuDisplay)
                            mnpReport.MenuItems.Add(MenuItemRep(dwIndex))

                            ' Add functionality to the menu items. 
                            AddHandler MenuItemRep(dwIndex).Click, AddressOf MenuClick
                        Next dwIndex

                    End If
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LoadJobList()
        'Get job associated with this bank
        Dim szTemp As String = ""
        Dim szCount As String
        Dim szJobName As String
        Dim szFileIDF As String

        Dim dwCount As Integer = 1

        Dim myconn As New OleDb.OleDbConnection(gszConnString)
        Dim strSQL As String = "SELECT * FROM JobSetup WHERE job_bank_id=" & UserInfo.BankId & " AND job_deleted=0 ORDER BY job_description ASC"

        Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
        Dim datareader As OleDb.OleDbDataReader = Nothing

        myconn.Open()
        datareader = myCmd.ExecuteReader()

        While datareader.Read()
            szCount = Mid(CStr(dwCount) & "." & Space(3), 1, 3)
            szJobName = Mid(datareader("job_description") & Space(20), 1, 20)
            szFileIDF = "File identifier: " & Mid(datareader("job_fileind") & Space(30), 1, 30)

            szTemp = szTemp & szCount & szJobName & szFileIDF & vbCrLf

            dwCount += 1
        End While

        myconn.Close()

        If (szTemp = "") Then
            lbJob.Text = "=No job associated with this bank="
        Else
            lbJob.Text = szTemp
        End If

    End Sub

    'Added by SY
    Private Sub MenuClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mnuitem As MenuItem
        Dim dlgViewReport As New FrmViewReport

        mnuitem = CType(sender, MenuItem)

        Dim dwi As Integer
        For dwi = 1 To UBound(arReportInfo)
            If mnuitem.Text = arReportInfo(dwi).MenuDisplay Then
                szReportFileName = arReportInfo(dwi).ReportFileName
                szReportType = mnuitem.Text
                dlgViewReport.ShowDialog()
                dlgViewReport.Dispose()
                Exit For
            End If
        Next
    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        Dim dlgOpen As New frmOpen

        Me.Opacity = 0.9
        dlgOpen.ShowDialog()
        dlgOpen.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuFileScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileScan.Click
        Dim dlgScan As New frmScan

        Me.Opacity = 0.9
        dlgScan.ShowDialog()
        dlgScan.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuFileLogoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileLogoff.Click
        boolLogOff = True
        DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub frmMenu_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        FileSystemWatcher1.EnableRaisingEvents = False

        If (boolLogOff = True) Then
            DialogResult = Windows.Forms.DialogResult.Abort
        Else
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub mnuSetupBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetupBank.Click
        Dim dlgBank As New frmBank
        Me.Opacity = 0.9
        dlgBank.ShowDialog()
        dlgBank.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuSetupJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetupJob.Click
        Dim dlgJobSetup As New frmJobSetup

        Me.Opacity = 0.9
        dlgJobSetup.ShowDialog()
        dlgJobSetup.Dispose()
        Me.Opacity = 1

        LoadJobList()
    End Sub

    Private Sub mnuSetupFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetupFormat.Click
        Dim dlgFormatSetup As New frmDataSetupMainMenu

        Me.Opacity = 0.9
        dlgFormatSetup.ShowDialog()
        dlgFormatSetup.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuSetupData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetupData.Click
        Dim dlgDataSetup As New frmCardSetupMainMenu

        Me.Opacity = 0.9
        dlgDataSetup.ShowDialog()
        dlgDataSetup.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportHouseKeep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportHouseKeep.Click
        Dim dlgHouseKeep As New frmReportHousekeep

        Me.Opacity = 0.9
        dlgHouseKeep.ShowDialog()
        dlgHouseKeep.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuUserPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserPassword.Click
        Dim dlgPassword As New frmChgPwd

        Me.Opacity = 0.9
        dlgPassword.ShowDialog()
        dlgPassword.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuSecurityUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSecurityUser.Click
        If (BankInfo.Id = 0) Then
            Dim dlgAdminUser As New frmAdminUser

            Me.Opacity = 0.9
            dlgAdminUser.ShowDialog()
            dlgAdminUser.Dispose()
            Me.Opacity = 1
        Else
            Dim dlgUser As New frmUser

            Me.Opacity = 0.9
            dlgUser.ShowDialog()
            dlgUser.Dispose()
            Me.Opacity = 1
        End If
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub FileSystemWatcher1_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Deleted
        Dim szFileCollection() As String

        szFileCollection = Directory.GetFiles(BankInfo.Folder_Input)
        lbTotalINPUT.Text = UBound(szFileCollection) + 1

    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Dim szFileCollection() As String

        szFileCollection = Directory.GetFiles(BankInfo.Folder_Input)
        lbTotalINPUT.Text = UBound(szFileCollection) + 1

    End Sub

    Private Sub FileSystemWatcher2_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher2.Created
        Dim szFileCollection() As String

        szFileCollection = Directory.GetFiles(BankInfo.Folder_Ready)
        lbTotalOUTPUT.Text = UBound(szFileCollection) + 1

    End Sub

    Private Sub FileSystemWatcher2_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher2.Deleted
        Dim szFileCollection() As String

        szFileCollection = Directory.GetFiles(BankInfo.Folder_Ready)
        lbTotalOUTPUT.Text = UBound(szFileCollection) + 1

    End Sub

    Private Sub lbInput_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbInput.LinkClicked
        Process.Start("explorer.exe", BankInfo.Folder_Input)
    End Sub

    Private Sub lbRoot_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbRoot.LinkClicked
        Process.Start("explorer.exe", BankInfo.Folder_Root)
    End Sub

    Private Sub lbOutput_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbOutput.LinkClicked
        Process.Start("explorer.exe", BankInfo.Folder_Ready)
    End Sub

    'chgs on 08/06/07
    Private Sub DisableAllMenu()

        Try
            Dim MainMenuControl As MenuItem
            Dim dwIndex As Integer
            Dim dwCount As Integer

            For Each MainMenuControl In Me.MainMenu1.MenuItems
                MainMenuControl.Enabled = False
                dwIndex = MainMenuControl.MenuItems.Count()

                For dwCount = 0 To dwIndex - 1
                    MainMenuControl.MenuItems.Item(dwCount).Enabled = False
                Next
            Next MainMenuControl

            'Dim buttonToolbar As ToolBarButton
            'For Each buttonToolbar In Me.ToolBar1.Buttons
            '    buttonToolbar.Enabled = False
            'Next buttonToolbar

        Catch ex As Exception
            MessageBox.Show("frmMenu_DisableAllMenu: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub AssignUserRights(ByVal GroupID As Long)

        Try
            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim strSQL As String = "SELECT Menus.menu_control_name FROM Menus INNER JOIN AccessRights ON Menus.menu_id = AccessRights.menu_id Where AccessRights.group_id=" & GroupID

            Dim myCmd As New OleDb.OleDbCommand(strSQL, myconn)
            Dim datareader As OleDb.OleDbDataReader = Nothing
            Dim MainMenuControl As New MenuItem
            'Dim buttonToolbar As ToolBarButton

            Dim dwControl As Integer
            Dim dwIndex As Integer

            myconn.Open()
            datareader = myCmd.ExecuteReader()

            While datareader.Read()
                For Each MainMenuControl In Me.MainMenu1.MenuItems
                    If (MainMenuControl.Text = datareader("menu_control_name")) Then
                        MainMenuControl.Enabled = True
                        GoTo NextControl
                    End If

                    dwIndex = MainMenuControl.MenuItems.Count()
                    For dwControl = 0 To dwIndex - 1
                        If (MainMenuControl.MenuItems.Item(dwControl).Text = datareader("menu_control_name")) Then
                            MainMenuControl.MenuItems.Item(dwControl).Enabled = True
                        End If
                    Next
NextControl:
                Next MainMenuControl

                'For Each buttonToolbar In Me.ToolBar1.Buttons
                '    If (buttonToolbar.Tag = datareader("menu_control_name")) Then
                '        buttonToolbar.Enabled = True
                '        Exit For
                '    End If
                'Next buttonToolbar

            End While

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("frmMenu_AssignUserRights: Exception-" & ex.Message)
        End Try

    End Sub

    Private Sub mnuSecurityMenus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSecurityMenus.Click
        Dim dlgAccessGroup As New frmAccessGroup

        Me.Opacity = 0.9
        dlgAccessGroup.ShowDialog()
        dlgAccessGroup.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuSecurityGroups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSecurityGroups.Click
        Dim dlgAccessMenu As New frmAccessMenu

        Me.Opacity = 0.9
        dlgAccessMenu.ShowDialog()
        dlgAccessMenu.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportEmboss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportEmboss.Click
        Dim dlgEmbossRpt As New frmEmbossRpt

        Me.Opacity = 0.9
        dlgEmbossRpt.ShowDialog()
        dlgEmbossRpt.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuReportCourier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportCourier.Click
        Dim dlgCourierRpt As New frmCourierRpt

        Me.Opacity = 0.9
        dlgCourierRpt.ShowDialog()
        dlgCourierRpt.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuFilePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFilePrint.Click
        Try
            Dim dlgCNPrint As New frmCNPrint

            Me.Opacity = 0.9
            dlgCNPrint.ShowDialog()
            dlgCNPrint.Dispose()

            Dim myconn As New OleDb.OleDbConnection(gszConnString)
            Dim myCmd As New OleDb.OleDbCommand

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            myconn.Open()
            myCmd.Connection = myconn

            myCmd.CommandText = "DELETE FROM TempPrint WHERE StationId='" & gszStationId & "'"
            myCmd.ExecuteNonQuery()
            myconn.Close()

        Catch ex As Exception
        Finally
            Me.Opacity = 1
        End Try
    End Sub

    Private Sub mnuFileException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileException.Click
        Dim dlgExceptions As New frmExceptions

        Me.Opacity = 0.9
        dlgExceptions.ShowDialog()
        dlgExceptions.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportConversion.Click
        Dim dlgConvReport As New frmConvReport

        Me.Opacity = 0.9
        dlgConvReport.ShowDialog()
        dlgConvReport.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuReportSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportSummary.Click
        Dim dlgSummaryRpt As New frmSummary

        Me.Opacity = 0.9
        dlgSummaryRpt.ShowDialog()
        dlgSummaryRpt.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportExceptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportExceptions.Click
        Dim dlgExceptionRpt As New frmExceptionRpt

        Me.Opacity = 0.9
        dlgExceptionRpt.ShowDialog()
        dlgExceptionRpt.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportReconciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportReconciliation.Click
        Dim dlgReconciliationRpt As New frmReconciliationRpt

        Me.Opacity = 0.9
        dlgReconciliationRpt.ShowDialog()
        dlgReconciliationRpt.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuFileRevException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileRevException.Click
        Dim dlgRevExceptions As New frmRevExceptions

        Me.Opacity = 0.9
        dlgRevExceptions.ShowDialog()
        dlgRevExceptions.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportCourierChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportCourierChange.Click
        Dim dlgCNChangeRpt As New frmChangeCNRpt

        Me.Opacity = 0.9
        dlgCNChangeRpt.ShowDialog()
        dlgCNChangeRpt.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportAuditLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportAuditLog.Click
        Dim dlgAuditLogPrint As New frmAuditLogPrint

        Me.Opacity = 0.9
        dlgAuditLogPrint.ShowDialog()
        dlgAuditLogPrint.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuReportMissing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportMissing.Click
        Dim dlgMissingEmbossRpt As New frmMissingEmbossRpt

        Me.Opacity = 0.9
        dlgMissingEmbossRpt.ShowDialog()
        dlgMissingEmbossRpt.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuFileSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSearch.Click
        Dim dlgSearch As New frmSearch

        Me.Opacity = 0.9
        dlgSearch.ShowDialog()
        dlgSearch.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuDataConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDataConversion.Click
        Dim dlgDataConversion As New frmLoadData

        Me.Opacity = 0.9
        dlgDataConversion.ShowDialog()
        dlgDataConversion.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuCardRetrievalList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCardRetrievalList.Click
        Dim dlgCardRetrievalList As New frmCardRetrieval

        Me.Opacity = 0.9
        dlgCardRetrievalList.ShowDialog()
        dlgCardRetrievalList.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuSetupUploadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetupUploadFile.Click
        Dim dlgUploadFileSetup As New frmUploadFileSetup

        Me.Opacity = 0.9
        dlgUploadFileSetup.ShowDialog()
        dlgUploadFileSetup.Dispose()
        Me.Opacity = 1

    End Sub

    Private Sub mnuFileDeletion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileDeletion.Click
        Dim dlgShredFile As New frmShred

        Me.Opacity = 0.9
        dlgShredFile.ShowDialog()
        dlgShredFile.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuPrintMailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintMailer.Click
        Dim dlgMailerPrint As New frmMailerPrint

        Me.Opacity = 0.9
        dlgMailerPrint.ShowDialog()
        dlgMailerPrint.Dispose()
        Me.Opacity = 1
    End Sub

    Private Sub mnuCorpMailerPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCorpMailerPrint.Click
        Dim dlgMailerPrint As New frmCorpMailerPrint

        Me.Opacity = 0.9
        dlgMailerPrint.ShowDialog()
        dlgMailerPrint.Dispose()
        Me.Opacity = 1
    End Sub
End Class

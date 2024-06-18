<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptImprimirEcheq
    Inherits GrapeCity.ActiveReports.SectionReport

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RptImprimirEcheq))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtNroEcheque = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TxtImporte = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TxtLocalidad = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtfechaEmision = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtfechaPago = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCantidad = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCUITEmisor = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtRazonSocial = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBanco = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCmc7parte1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCmc7parte2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCmc7parte3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtSerie = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCmc7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtCodParte1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCodParte2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCodParte3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.lblCuitEndoso = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtCUITEndoso = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroEcheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfechaEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfechaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCUITEmisor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmc7parte1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmc7parte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmc7parte3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCmc7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodParte1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodParte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodParte3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCuitEndoso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCUITEndoso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape2, Me.Label1, Me.Label2, Me.txtNroEcheque, Me.TxtImporte, Me.Label4, Me.Line1, Me.TxtLocalidad, Me.Line4, Me.txtfechaEmision, Me.txtfechaPago, Me.Label9, Me.Label10, Me.txtCantidad, Me.txtCUITEmisor, Me.Shape1, Me.Label11, Me.txtRazonSocial, Me.txtBanco, Me.Line8, Me.txtCmc7parte1, Me.txtCmc7parte2, Me.txtCmc7parte3, Me.Line2, Me.txtSerie, Me.txtCmc7, Me.Line9, Me.txtCodParte1, Me.txtCodParte2, Me.txtCodParte3, Me.lblCuitEndoso, Me.txtCUITEndoso})
        Me.Detail.Height = 2.528884!
        Me.Detail.Name = "Detail"
        '
        'Shape2
        '
        Me.Shape2.Height = 0.3248032!
        Me.Shape2.Left = 4.507874!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(10.0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape2.Top = 0.03937008!
        Me.Shape2.Width = 1.664174!
        '
        'Label1
        '
        Me.Label1.Height = 0.1667323!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.7060317!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.Label1.Text = "CHEQUE DE PAGO DIFERIDO-CPD"
        Me.Label1.Top = 0.09350388!
        Me.Label1.Width = 1.948425!
        '
        'Label2
        '
        Me.Label2.Height = 0.1480315!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.7060317!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 5pt; ddo-char-set: 1"
        Me.Label2.Text = "La fecha de pago no puede exceder un plazo de 360 dias"
        Me.Label2.Top = 0.3151575!
        Me.Label2.Width = 1.948425!
        '
        'txtNroEcheque
        '
        Me.txtNroEcheque.DataField = "NroCheque"
        Me.txtNroEcheque.Height = 0.2625985!
        Me.txtNroEcheque.Left = 3.00485!
        Me.txtNroEcheque.Name = "txtNroEcheque"
        Me.txtNroEcheque.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; ddo-char-set: 0"
        Me.txtNroEcheque.Text = "12345678"
        Me.txtNroEcheque.Top = 0.2923228!
        Me.txtNroEcheque.Width = 0.7283463!
        '
        'TxtImporte
        '
        Me.TxtImporte.DataField = "Importe"
        Me.TxtImporte.Height = 0.2374016!
        Me.TxtImporte.Left = 4.714875!
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.TxtImporte.Text = "importe"
        Me.TxtImporte.Top = 0.08337008!
        Me.TxtImporte.Width = 1.404331!
        '
        'Label4
        '
        Me.Label4.Height = 0.2295276!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.559842!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 9.75pt; font-weight: bold"
        Me.Label4.Text = "$"
        Me.Label4.Top = 0.09370077!
        Me.Label4.Width = 0.1350393!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 1.571!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.65!
        Me.Line1.Width = 3.739764!
        Me.Line1.X1 = 1.571!
        Me.Line1.X2 = 5.310764!
        Me.Line1.Y1 = 1.65!
        Me.Line1.Y2 = 1.65!
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Height = 0.1791339!
        Me.TxtLocalidad.Left = 0.7060317!
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.TxtLocalidad.Text = "Localidad"
        Me.TxtLocalidad.Top = 0.6230314!
        Me.TxtLocalidad.Width = 1.0!
        '
        'Line4
        '
        Me.Line4.Height = 0.001968503!
        Me.Line4.Left = 1.706031!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.8210629!
        Me.Line4.Width = 2.239765!
        Me.Line4.X1 = 1.706031!
        Me.Line4.X2 = 3.945796!
        Me.Line4.Y1 = 0.8210629!
        Me.Line4.Y2 = 0.8230314!
        '
        'txtfechaEmision
        '
        Me.txtfechaEmision.Height = 0.2!
        Me.txtfechaEmision.Left = 1.741464!
        Me.txtfechaEmision.Name = "txtfechaEmision"
        Me.txtfechaEmision.Text = "AÑO"
        Me.txtfechaEmision.Top = 0.6021653!
        Me.txtfechaEmision.Width = 2.204331!
        '
        'txtfechaPago
        '
        Me.txtfechaPago.Height = 0.2!
        Me.txtfechaPago.Left = 1.095796!
        Me.txtfechaPago.Name = "txtfechaPago"
        Me.txtfechaPago.Text = "AÑO"
        Me.txtfechaPago.Top = 0.8812993!
        Me.txtfechaPago.Width = 2.833465!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.7060317!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = ""
        Me.Label9.Text = "EL"
        Me.Label9.Top = 0.8895671!
        Me.Label9.Width = 0.2708659!
        '
        'Label10
        '
        Me.Label10.Height = 0.2728341!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.7060317!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 6.75pt; font-weight: normal; ddo-char-set: 0"
        Me.Label10.Text = "LA CANTIDAD DE PESOS"
        Me.Label10.Top = 1.26122!
        Me.Label10.Width = 0.8645669!
        '
        'txtCantidad
        '
        Me.txtCantidad.Height = 0.2!
        Me.txtCantidad.Left = 1.570598!
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Style = "font-size: 8.25pt"
        Me.txtCantidad.Text = "cantidad"
        Me.txtCantidad.Top = 1.26122!
        Me.txtCantidad.Width = 3.535827!
        '
        'txtCUITEmisor
        '
        Me.txtCUITEmisor.DataField = "cuitEmisor"
        Me.txtCUITEmisor.Height = 0.1979167!
        Me.txtCUITEmisor.Left = 1.232!
        Me.txtCUITEmisor.Name = "txtCUITEmisor"
        Me.txtCUITEmisor.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.txtCUITEmisor.Text = "CuitEmisor"
        Me.txtCUITEmisor.Top = 1.702!
        Me.txtCUITEmisor.Width = 1.209055!
        '
        'Shape1
        '
        Me.Shape1.Height = 0.8153543!
        Me.Shape1.Left = 4.903543!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(10.0!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Top = 0.4291339!
        Me.Shape1.Width = 1.268504!
        '
        'Label11
        '
        Me.Label11.Height = 0.2!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.7323934!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = ""
        Me.Label11.Text = "CUIT"
        Me.Label11.Top = 1.702!
        Me.Label11.Width = 0.3956693!
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.DataField = "RazonSocial"
        Me.txtRazonSocial.Height = 0.1979167!
        Me.txtRazonSocial.Left = 2.555228!
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Text = "razonSocial"
        Me.txtRazonSocial.Top = 1.703968!
        Me.txtRazonSocial.Width = 3.396457!
        '
        'txtBanco
        '
        Me.txtBanco.DataField = "BancoEmision"
        Me.txtBanco.Height = 0.5988031!
        Me.txtBanco.Left = 0.06311832!
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Style = "font-size: 6pt; font-weight: bold; text-align: left"
        Me.txtBanco.Text = "Banco"
        Me.txtBanco.Top = 0.7001969!
        Me.txtBanco.Width = 0.5523622!
        '
        'Line8
        '
        Me.Line8.Height = 2.110826!
        Me.Line8.Left = 0.6153543!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.09350511!
        Me.Line8.Width = 0.00000005960464!
        Me.Line8.X1 = 0.6153544!
        Me.Line8.X2 = 0.6153543!
        Me.Line8.Y1 = 2.204331!
        Me.Line8.Y2 = 0.09350511!
        '
        'txtCmc7parte1
        '
        Me.txtCmc7parte1.DataField = "cmc7"
        Me.txtCmc7parte1.Height = 0.2!
        Me.txtCmc7parte1.Left = 4.955512!
        Me.txtCmc7parte1.Name = "txtCmc7parte1"
        Me.txtCmc7parte1.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCmc7parte1.Text = "parte1"
        Me.txtCmc7parte1.Top = 0.5003937!
        Me.txtCmc7parte1.Width = 0.7917325!
        '
        'txtCmc7parte2
        '
        Me.txtCmc7parte2.DataField = "Cmc7"
        Me.txtCmc7parte2.Height = 0.2!
        Me.txtCmc7parte2.Left = 4.955512!
        Me.txtCmc7parte2.Name = "txtCmc7parte2"
        Me.txtCmc7parte2.Style = "font-size: 8pt; text-align: center; ddo-char-set: 1"
        Me.txtCmc7parte2.Text = "parte2"
        Me.txtCmc7parte2.Top = 0.7468504!
        Me.txtCmc7parte2.Width = 0.791732!
        '
        'txtCmc7parte3
        '
        Me.txtCmc7parte3.DataField = "Cmc7"
        Me.txtCmc7parte3.Height = 0.2!
        Me.txtCmc7parte3.Left = 4.955512!
        Me.txtCmc7parte3.Name = "txtCmc7parte3"
        Me.txtCmc7parte3.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCmc7parte3.Text = "parte3"
        Me.txtCmc7parte3.Top = 0.9704725!
        Me.txtCmc7parte3.Width = 0.7917325!
        '
        'Line2
        '
        Me.Line2.Height = 0!
        Me.Line2.Left = 1.095796!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.100196!
        Me.Line2.Width = 2.85!
        Me.Line2.X1 = 1.095796!
        Me.Line2.X2 = 3.945796!
        Me.Line2.Y1 = 1.100196!
        Me.Line2.Y2 = 1.100196!
        '
        'txtSerie
        '
        Me.txtSerie.Height = 0.2!
        Me.txtSerie.Left = 3.00485!
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Style = "font-size: 8pt; text-align: center; ddo-char-set: 1"
        Me.txtSerie.Text = "SERIE"
        Me.txtSerie.Top = 0.06003936!
        Me.txtSerie.Width = 0.7283464!
        '
        'txtCmc7
        '
        Me.txtCmc7.DataField = "Cmc7"
        Me.txtCmc7.Height = 0.2291338!
        Me.txtCmc7.Left = 2.014567!
        Me.txtCmc7.Name = "txtCmc7"
        Me.txtCmc7.Style = "color: Gray; font-size: 13pt; font-weight: bold; text-align: center; ddo-char-set" &
    ": 1"
        Me.txtCmc7.Text = "CMC7"
        Me.txtCmc7.Top = 2.204331!
        Me.txtCmc7.Width = 3.936992!
        '
        'Line9
        '
        Me.Line9.Height = 0!
        Me.Line9.Left = 0!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 2.452756!
        Me.Line9.Width = 6.243701!
        Me.Line9.X1 = 0!
        Me.Line9.X2 = 6.243701!
        Me.Line9.Y1 = 2.452756!
        Me.Line9.Y2 = 2.452756!
        '
        'txtCodParte1
        '
        Me.txtCodParte1.Height = 0.2!
        Me.txtCodParte1.Left = 5.858268!
        Me.txtCodParte1.Name = "txtCodParte1"
        Me.txtCodParte1.Text = Nothing
        Me.txtCodParte1.Top = 0.5003937!
        Me.txtCodParte1.Visible = False
        Me.txtCodParte1.Width = 0.3854332!
        '
        'txtCodParte2
        '
        Me.txtCodParte2.Height = 0.2!
        Me.txtCodParte2.Left = 5.858268!
        Me.txtCodParte2.Name = "txtCodParte2"
        Me.txtCodParte2.Text = Nothing
        Me.txtCodParte2.Top = 0.7468504!
        Me.txtCodParte2.Visible = False
        Me.txtCodParte2.Width = 0.3137794!
        '
        'txtCodParte3
        '
        Me.txtCodParte3.Height = 0.2!
        Me.txtCodParte3.Left = 5.858268!
        Me.txtCodParte3.Name = "txtCodParte3"
        Me.txtCodParte3.Text = Nothing
        Me.txtCodParte3.Top = 0.9704725!
        Me.txtCodParte3.Visible = False
        Me.txtCodParte3.Width = 0.3137794!
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.DataField = "Cmc7"
        Me.GroupHeader1.Height = 0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.NewColumn = GrapeCity.ActiveReports.SectionReportModel.NewColumn.Before
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'lblCuitEndoso
        '
        Me.lblCuitEndoso.Height = 0.2!
        Me.lblCuitEndoso.HyperLink = Nothing
        Me.lblCuitEndoso.Left = 0.7322835!
        Me.lblCuitEndoso.Name = "lblCuitEndoso"
        Me.lblCuitEndoso.Style = "font-size: 7pt; ddo-char-set: 1"
        Me.lblCuitEndoso.Text = "CUITEndoso"
        Me.lblCuitEndoso.Top = 2.004331!
        Me.lblCuitEndoso.Width = 0.6692914!
        '
        'txtCUITEndoso
        '
        Me.txtCUITEndoso.DataField = "CUITEndoso"
        Me.txtCUITEndoso.Height = 0.1979167!
        Me.txtCUITEndoso.Left = 1.401575!
        Me.txtCUITEndoso.Name = "txtCUITEndoso"
        Me.txtCUITEndoso.Style = "font-size: 8pt; ddo-char-set: 1"
        Me.txtCUITEndoso.Text = "CuitEndoso"
        Me.txtCUITEndoso.Top = 2.004331!
        Me.txtCUITEndoso.Width = 0.7271655!
        '
        'RptImprimirEcheq
        '
        Me.MasterReport = False
        Me.CompatibilityMode = GrapeCity.ActiveReports.Document.CompatibilityModes.CrossPlatform
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.260416!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroEcheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfechaEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfechaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCUITEmisor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCmc7parte1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCmc7parte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCmc7parte3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCmc7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodParte1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodParte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodParte3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCuitEndoso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCUITEndoso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtNroEcheque As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TxtImporte As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents TxtLocalidad As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtfechaEmision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtfechaPago As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtCantidad As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCUITEmisor As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtRazonSocial As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtBanco As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtCmc7parte1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCmc7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtCmc7parte2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCmc7parte3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtSerie As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCodParte1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCodParte2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCodParte3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblCuitEndoso As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtCUITEndoso As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class

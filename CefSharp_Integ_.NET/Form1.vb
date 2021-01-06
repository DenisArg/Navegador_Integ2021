Imports CefSharp.WinForms
Imports CefSharp

Public Class Form1
    Public Property ScriptErrorsSuppressed As Boolean
    'Objeto que recoje los datos leidos de la tabla
    Dim dt As New DataTable
    'Contador del número de filas
    Dim intFila As Integer = 0
    Dim int As Integer = 0

    Private WithEvents browser As ChromiumWebBrowser
    Public Sub New()
        InitializeComponent()
        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)
        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Dim UrlUsar As String
        'Objeto conexión para conectarse a la base de datos de Access
        Dim Snombre_Base As String
        Dim adaptador As System.Data.OleDb.OleDbDataAdapter
        Dim strConexion As System.Data.OleDb.OleDbConnection
        'Variable que contiene la select a ejecutar sobre la base de datos
        Dim strSQL As String
        'Adaptador de la base de datos con la aplicación
        Snombre_Base = "C:\Dominial\dB\IntercambioNET.mdb"
        strSQL = "SELECT * FROM Datos_NET"
        strConexion = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" & Snombre_Base & "")
        adaptador = New OleDb.OleDbDataAdapter(strSQL, strConexion)
        Dim ds As New DataSet
        'Rellena al adaptador con el primer dato leído
        adaptador.Fill(dt)
        'Vacía la memoria del adaptador
        adaptador.Dispose()
        'llama a la subrutina qu emuestra el texto en la caja
        UrlUsar = CType(dt.Rows(intFila)("UrlDestino"), String)
        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        browser = New ChromiumWebBrowser("" & UrlUsar) With {.Dock = DockStyle.Fill}
        browser.Name = "Navegador Integ"
        TabControl1.SelectedTab.Controls.Add(browser)
        TxT_URL.Text = UrlUsar
        browser.Dock = DockStyle.Fill

    End Sub

    Private Sub cmdEnvioDatos_Click(sender As Object, e As EventArgs) Handles cmdEnvioDatos.Click
        'CUIL
        Dim CUIL_CUIT As String, Nombre As String, Apellido As String, Genero As String, FechaNacimiento As Date, NroPag As Integer
        'Objeto conexión para conectarse a la base de datos de Access
        'Dim strConexion As New OleDbConnection("Provider=Microsoft.jet.Oledb.4.0;Data Source=" + My.Application.Info.DirectoryPath + "\Database21.mdb")
        Dim Snombre_Base As String
        Dim adaptador As System.Data.OleDb.OleDbDataAdapter
        Dim strConexion As System.Data.OleDb.OleDbConnection
        'Variable que contiene la select a ejecutar sobre la base de datos
        Dim strSQL As String
        'Adaptador de la base de datos con la aplicación
        Snombre_Base = "C:\Dominial\dB\IntercambioNET.mdb"
        strSQL = "SELECT * FROM Datos_NET"
        strConexion = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" & Snombre_Base & "")
        adaptador = New OleDb.OleDbDataAdapter(strSQL, strConexion)
        Dim ds As New DataSet
        'Rellena al adaptador con el primer dato leído
        adaptador.Fill(dt)
        'Vacía la memoria del adaptador
        adaptador.Dispose()
        NroPag = CType(dt.Rows(intFila)("NroPag"), Integer)
        If NroPag = 1 Then

            CUIL_CUIT = CType(dt.Rows(intFila)("CUIL_CUIT"), String)
            'TipoDoc = dt.Rows(intFila)("TipoDoc")
            Nombre = CType(dt.Rows(intFila)("Nombre"), String)
            Apellido = CType(dt.Rows(intFila)("Apellido"), String)
            Genero = CType(dt.Rows(intFila)("Genero"), String)
            FechaNacimiento = CType(dt.Rows(intFila)("FechaNacimiento"), Date)

            With browser
                'Complete web form
                Dim identifiers As List(Of Long) = .GetBrowser.GetFrameIdentifiers()
                For Each i As Long In identifiers
                    Try
                        Dim frame As CefSharp.IFrame = .GetBrowser.GetFrame(i)
                        frame.EvaluateScriptAsync("document.getElementById('edit-lastname').value='" & Apellido & "';")
                        'frame.EvaluateScriptAsync("document.getElementById('ctl00_Contenido_Apellido_Casada').value=" & Val(CUIL_CUIT) & ";")
                        frame.EvaluateScriptAsync("document.getElementById('edit-name').value='" & Nombre & "';")
                        If Genero = "FEMENINO" Then
                            frame.EvaluateScriptAsync("document.getElementById('edit-sexo-f').click();")
                        End If
                        If Genero = "MASCULINO" Then
                            frame.EvaluateScriptAsync("document.getElementById('edit-sexo-m').click();")
                        End If
                        frame.EvaluateScriptAsync("document.getElementById('edit-nro-doc').value=" & Val(CUIL_CUIT) & ";")
                        frame.EvaluateScriptAsync("document.getElementById('edit-date').value='" & FechaNacimiento.ToString(“dd/MM/yyyy”) & "';")
                        'MsgBox(CUIL_CUIT)
                        'frame.EvaluateScriptAsync("document.getElementById('ctl00_Contenido_Estado_Civil').value='26813871';")
                        frame.EvaluateScriptAsync("document.getElementById('edit-security-code').click();")
                        'frame.EvaluateScriptAsync("document.getElementById('paw').value='1234';")
                        'frame.EvaluateScriptAsync("document.getElementById('btgo').click();")
                        Exit For
                    Catch ex As Exception
                    End Try
                Next
            End With
        End If

        If NroPag = 2 Then
            CUIL_CUIT = CType(dt.Rows(intFila)("CUIL_CUIT"), String)
            txtcuit.Visible = False
            txtcuit.Text = CType(dt.Rows(intFila)("CUIL_CUIT"), String)
            txtcuit.SelectAll()
            txtcuit.Copy()
            My.Computer.Keyboard.SendKeys("{TAB}", True)
            My.Computer.Keyboard.SendKeys("{TAB}", True)
            My.Computer.Keyboard.SendKeys("{TAB}", True)
            'My.Computer.Keyboard.SendKeys("{TAB}", True)
            My.Computer.Keyboard.SendKeys("(^(v))", True)
            My.Computer.Keyboard.SendKeys("{TAB}", True)
            'With browser
            'Complete web form
            'Dim identifiers As List(Of Long) = .GetBrowser.GetFrameIdentifiers()
            'For Each i As Long In identifiers
            'Try
            'Dim frame As CefSharp.IFrame = .GetBrowser.GetFrame(i)
            'frame.EvaluateScriptAsync("document.getElementById('cuit').value='" & Val(CUIL_CUIT) & "';")
            'frame.EvaluateScriptAsync("document.getElementById('cuit').value='78877';")
            'frame.ExecuteJavaScriptAsync("document.getElementById('cuit').value='20022';")
            'frame.EvaluateScriptAsync("document.getElementByname('cuit').value='78877';")
            ''MsgBox(CUIL_CUIT)
            ''frame.EvaluateScriptAsync("document.getElementById('').click();")
            'Exit For
            'Catch ex As Exception
            'End Try
            'Next
            'End With
        End If
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Me.Close()

    End Sub
    Public Class DownloadHandler2
        'Inherits IDownloadHandler

        Public Sub OnBeforeDownload(ByVal browser As IBrowser, ByVal downloadItem As DownloadItem, ByVal callback As IBeforeDownloadCallback)
            downloadItem.SuggestedFileName = "c:\temp\temp.pdf"
            MsgBox("Public Sub OnBeforeDownload(ByVal browser As IBrowser, ByVal downloadItem As DownloadItem, ByVal callback As IBeforeDownloadCallback)")
            If Not callback.IsDisposed Then
                MsgBox("If Not callback.IsDisposed Then")
                Using callback
                    callback.[Continue](downloadItem.SuggestedFileName, showDialog:=False)
                End Using
            End If
        End Sub

        Public Sub OnDownloadUpdated(ByVal browser As IBrowser, ByVal downloadItem As DownloadItem, ByVal callback As IDownloadItemCallback)
            If Not downloadItem.IsInProgress AndAlso browser.IsPopup AndAlso Not browser.HasDocument Then
                browser.GetHost().CloseBrowser(False)
            End If
        End Sub
    End Class
    Public Function OnBeforePopup(ByVal browser As IWebBrowser, ByVal sourceUrl As String, ByVal targetUrl As String, ByRef x As Integer, ByRef y As Integer, ByRef width As Integer, ByRef height As Integer) As Boolean
        '    Dim brf As Object = Nothing
        '    brf.InvokeOnUiThreadIfRequired(
        '        Function()
        '    Dim bf = New BRForm(targetUrl) With {.Visible = True}
        ' End Function)
        '    Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

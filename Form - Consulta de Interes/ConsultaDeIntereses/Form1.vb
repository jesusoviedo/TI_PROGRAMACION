Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmConsultaIntereses

    ''' <summary>
    ''' Autor: Jesus Oviedo Riquelme
    ''' Año 2016
    ''' Version 1.2
    ''' </summary>
    Private Sub frmConsultaIntereses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarControles()
    End Sub

    ''' <summary>
    ''' btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
    ''' Metodo que se ejecuta al dar clic en el boton aceptar, el cual llama al metodo VerificarDatos y a la funcion EscribirArchivo)
    ''' </summary>
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'si el metodo VerificarDatos devuelve true, el not lo convierte el false
        'mientras no se ingrese correctamente todos los datos no se escribira en el archivo
        If Not (VerificarDatos()) Then
            EscribirArchivo()
        End If
    End Sub

    ''' <summary>
    ''' VerificarDatos() As Boolean
    ''' Funcion que validad los datos ingresados o seleccionados, devuelve true si un dato no cumple con cierto requisito
    ''' </summary>
    Private Function VerificarDatos() As Boolean
        Dim vError As Boolean = False
        'valida que se ingrese un nombre
        If txtNombre.Text.Length = 0 Then
            MessageBox.Show("Debe ingresar un Nombre")
            vError = True
        Else
            'valida que se ingrese un e-mail
            If txtEmail.Text.Length = 0 Then
                MessageBox.Show("Debe ingresar un E-mail")
                vError = True
            Else
                'valida que se ingrese un e-mail valido
                If Not (ValidarEmail(txtEmail.Text)) Then
                    MessageBox.Show("Debe ingresar una direccion de E-mail valida")
                    vError = True
                    'valida que se haya seleccionado una ciudad
                ElseIf cboCiudad.SelectedIndex = -1 Then
                    MessageBox.Show("Debe seleccionar una Ciudad")
                    vError = True
                Else
                    'valida que se haya seleccionado un sexo
                    If Not (rdbFemenino.Checked) And Not (rdbMasculino.Checked) Then
                        MessageBox.Show("Debe indicar el Sexo")
                        vError = True
                    Else
                        'valida que se haya seleccionado almenos un interes
                        If Not (chkCine.Checked) And Not (chkDeportes.Checked) And Not (chkInformatica.Checked) And Not (chkViajes.Checked) Then
                            MessageBox.Show("Debe seleccionar al menos un interes")
                            vError = True
                        End If
                    End If
                End If
            End If
        End If
        'retorna la varible vError
        Return vError
    End Function

    ''' <summary>
    ''' EscribirArchivo() 
    ''' Metodo que crea el archivo con nombre archivo_contacto.txt en la carpeta bin (usando ruta relativa)
    ''' Dentro del archivo creado se va añadiendo todo lo ingresado o seleccionado en el form
    ''' Se controla excepciones durante la creacion y escritura en el archivo
    ''' </summary>
    Private Sub EscribirArchivo()
        Try
            'J:\Visual Studio 2015\Projects\UAA\ConsultaDeIntereses\ConsultaDeIntereses\archivo_contacto.txt
            'se indica la direccion relativa o excaxta y el nombre del archivo con su extension
            Dim vArchivo As New StreamWriter("..\archivo_contacto.txt", True)
            'se carga en el bufer los valores a ser escritos en el archivo
            vArchivo.Write(txtNombre.Text & ";")
            vArchivo.Write(txtEmail.Text & ";")
            vArchivo.Write(cboCiudad.Text & ";")
            'si es hombre se escribira M, caso contrario F
            If rdbMasculino.Checked = True Then
                vArchivo.Write("M" & ";")
            Else
                vArchivo.Write("F" & ";")
            End If
            'Verifica que intereses estan chequeados y lo escribe
            'viajes
            If chkViajes.Checked = True Then
                vArchivo.Write((",VIAJES"))
            End If
            'deportes
            If chkDeportes.Checked = True Then
                vArchivo.Write(",DEPORTES")
            End If
            'cine
            If chkCine.Checked = True Then
                vArchivo.Write(",CINE")
            End If
            'informatica
            If chkInformatica.Checked Then
                vArchivo.Write(",INFORMATICA")
            End If
            'realiza un salto de linea y escribe una linea en blanco en el bufer
            vArchivo.WriteLine()
            'metodo que escribe todo lo cargado en el bufer
            vArchivo.Flush()
            'mensaje que se despliega cuando se graban los datos en el archivo
            MessageBox.Show("Registro guardado con exito")
        Catch ex As Exception
            'mensaje que se despliega cuando ocurre una excepcion en el bloque try
            MessageBox.Show(ex.Message)
        Finally
            'haya o no una excepcion, siempre se inicializa los controlarodes
            InicializarControles()
        End Try
    End Sub

    ''' <summary>
    ''' ValidarEmail(ByVal email As String) As Boolean 
    ''' Metodo que usa las expresiones regulares para poder validar mail retorna true si esta correcto el mail o false si no lo esta
    ''' </summary>
    Function ValidarEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    ''' <summary>
    ''' InicializarControles()
    ''' Metodo que setea los valores de los controles usados en el form
    ''' </summary>
    Private Sub InicializarControles()
        'TextBox vacios y que todo lo ingresado este en mayuscula
        txtNombre.Text = String.Empty
        txtNombre.CharacterCasing = CharacterCasing.Upper
        txtEmail.Text = String.Empty
        txtEmail.CharacterCasing = CharacterCasing.Upper
        'ComboBox sin autoseleccion de item y que no permita ingresar manualmente una ciudad
        cboCiudad.SelectedIndex = -1
        cboCiudad.DropDownStyle = ComboBoxStyle.DropDownList
        'RadioButton no chequeados o seleccionados
        rdbMasculino.Checked = False
        rdbFemenino.Checked = False
        'CheckBox no chequeados o seleccionados
        chkViajes.Checked = False
        chkDeportes.Checked = False
        chkCine.Checked = False
        chkInformatica.Checked = False
        'Single se usa tabulador debe seguir recorrer de acuerdo a este orden
        txtNombre.TabIndex = 0
        txtEmail.TabIndex = 1
        cboCiudad.TabIndex = 2
        rdbMasculino.TabIndex = 3
        rdbFemenino.TabIndex = 4
        chkViajes.TabIndex = 5
        chkDeportes.TabIndex = 6
        chkCine.TabIndex = 7
        chkInformatica.TabIndex = 8
        btnAceptar.TabIndex = 100
        btnSalir.TabIndex = 101
    End Sub

    ''' <summary>
    ''' btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    ''' Metodo que se ejecuta al dar clic en el boton salir y permite cerra el form
    ''' </summary>
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'cierra el form
        Close()
    End Sub
End Class
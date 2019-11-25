Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim usuario, psw, BD, servidor As String
        Try
            servidor = "DESKTOP-OR1POIQ"
            usuario = "sa"
            psw = "123456"
            BD = "Tarea5"
            conexion = New SqlConnection
            conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlquery As String 'cadena centencia sql 
        Dim commando As New SqlCommand 'Objeto de comando

        Dim radioSexo As String
        If RadioButton1.Checked Then
            radioSexo = "Masculino"
        Else
            radioSexo = "Femenino"
        End If

        If clave.Text <> repetir_clave.Text Then
            MsgBox("ERROR: Las contraseñas no son iguales!")
        End If

        Try
            If usuario.Text = "" Or clave.Text = "" Or correo.Text = "" Or correo.Text = "" Or apellido.Text = "" Or nombre.Text = "" Or
                    provincia.Text = "" Or codigopostal.Text = "" Or fecha.Text = "" Or comentarios.Text = "" Then
                MsgBox("ERROR: Para registar este usuario llene todo los campos requeridos")

            ElseIf CheckBox1.Checked Then
                sqlquery = "INSERT INTO formulario (nombreUsuario, clave, correo, apellido,nombre, pais, provincia,codigoPostal, sexo, fechaNacimiento,comentario)
                VALUES('" & usuario.Text & "', '" & clave.Text & "', '" & correo.Text & "', '" & apellido.Text & "', '" & nombre.Text & "', '" & paises.Text & "', '" & provincia.Text & "', '" & codigopostal.Text & "', '" & radioSexo & "', '" & fecha.Text & "', '" & comentarios.Text & "')"

                commando = New SqlCommand(sqlquery, conexion)
                commando.ExecuteNonQuery()

                'Limpiar
                usuario.Text = ""
                clave.Text = ""
                correo.Text = ""
                apellido.Text = ""
                nombre.Text = ""
                provincia.Text = ""
                codigopostal.Text = ""
                fecha.Text = ""
                comentarios.Text = ""
                repetir_clave.Text = ""
                RadioButton1.Checked = False
                RadioButton2.Checked = False
            Else
                MsgBox("ERROR: no ha aceptado los terminos y condiciones")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("ERROR: Nombre de Usuario ya registrado")
        End Try
    End Sub

    Protected Sub consultar_Click(sender As Object, e As EventArgs) Handles consultar.Click
        Dim data As SqlDataReader ' objeto de lectura
        Dim commando As New SqlCommand 'Objeto de comando
        Dim sqlquery As String 'cadena sentencia sql
        Dim sexoBD As String
        Try
            If usuario.Text = "" Then
                MsgBox("Para Consultar ingrese el nombre de usuario en el campo requerido")
            End If
            sqlquery = "SELECT * FROM formulario WHERE nombreUsuario = '" & usuario.Text & "' "
            commando = New SqlCommand(sqlquery, conexion)
            data = commando.ExecuteReader
            data.Read()

            clave.Text = data("clave")
            repetir_clave.Text = data("clave")
            correo.Text = data("correo")
            apellido.Text = data("apellido")
            nombre.Text = data("nombre")
            provincia.Text = data("provincia")
            codigopostal.Text = data("codigoPostal")
            fecha.Text = data("fechaNacimiento")
            comentarios.Text = data("comentario")
            CheckBox1.Checked = True
            sexoBD = data("sexo")

            If sexoBD = "Masculino" Then
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            Else
                RadioButton2.Checked = True
                RadioButton1.Checked = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        data.Close()
    End Sub
End Class
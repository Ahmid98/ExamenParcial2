Public Class SISTEMA
    Public matriz(8, 5) As String
    Public index As Byte = 0



    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        If index < 5 Then

            If txt_nombre.Text <> "" Then
                matriz(0, index) = txt_nombre.Text
            Else
                MsgBox("Debe ingresar un nombre..")
                Exit Sub
            End If

            If txt_cui.Text <> "" Then
                matriz(1, index) = txt_cui.Text
            Else
                MsgBox("Debe ingresar un CUI..")
                Exit Sub
            End If

            If txt_direccion.Text <> "" Then
                matriz(2, index) = txt_direccion.Text
            Else
                MsgBox("Debe ingresar una direccion..")
                Exit Sub
            End If

            If ck_tv.Checked Or ck_telefono.Checked Or ck_laptop.Checked Or ck_refri.Checked Then
                Dim costo_tv As Double = 0
                Dim costo_tel As Double = 0
                Dim costo_laptop As Double = 0
                Dim costo_refri As Double = 0

                If ck_tv.Checked Then
                    costo_tv = InputBox("Introdusca costo de la TV", "", "Ingrese dato", 100, 200)


                End If

                If ck_telefono.Checked Then
                    costo_tel = InputBox("Introdusca costo del telefono", "", "Ingrese dato", 100, 200)


                End If

                If ck_laptop.Checked Then
                    costo_laptop = InputBox("Introdusca costo de la laptop", "", "Ingrese dato", 100, 200)

                End If

                If ck_refri.Checked Then
                    costo_refri = InputBox("Introdusca costo de la refrigeradora", "", "Ingrese dato", 100, 200)

                End If

                matriz(3, index) = costo_tv + costo_tel + costo_laptop + costo_refri
            Else
                MsgBox("Debes elegir al menos un aparato.")
                Exit Sub
            End If




            If cb_plazo.SelectedIndex <> -1 Then
                matriz(4, index) = cb_plazo.SelectedItem
            Else
                MsgBox("Debe seleccionar un plazo..")
                Exit Sub
            End If

            If ck_tv.Checked Or ck_telefono.Checked Or ck_laptop.Checked Or ck_refri.Checked Then
                Dim aux As String
                If ck_tv.Checked Then
                    aux = "Tv"
                End If

                If ck_telefono.Checked Then
                    aux += " telefono"
                End If

                If ck_laptop.Checked Then
                    aux += " laptop"
                End If

                If ck_refri.Checked Then
                    aux += " refri"
                End If

                matriz(5, index) = aux
            Else
                MsgBox("Debes elegir al menos un aparato.")
                Exit Sub
            End If

            matriz(6, index) = System.Math.Round(Resultado.PagoParcial(matriz(3, index)), 2)
            matriz(7, index) = System.Math.Round(Resultado.Descuento, 2)
            matriz(8, index) = System.Math.Round(Resultado.Total, 2)

            ListBox1.Items.Add(matriz(0, index))
            ListBox2.Items.Add(matriz(1, index))
            ListBox3.Items.Add(matriz(2, index))
            ListBox4.Items.Add(matriz(3, index))
            ListBox5.Items.Add(matriz(4, index))
            ListBox6.Items.Add(matriz(5, index))
            ListBox7.Items.Add(matriz(6, index))
            ListBox8.Items.Add(matriz(7, index))
            ListBox9.Items.Add(matriz(8, index))

            index = index + 1
        End If



    End Sub

    Private Sub LIMPIARLISTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARLISTASToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("Deseas salir", vbYesNo, "") = vbYes Then
            End
        End If
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        For i = 0 To 8
            For j = 0 To 5
                matriz(i, j) = ""
            Next j
        Next i
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        txt_nombre.Clear()
        txt_cui.Clear()
        txt_direccion.Clear()
        cb_plazo.SelectedIndex = -1
        ck_laptop.Checked = False
        ck_refri.Checked = False
        ck_telefono.Checked = False
        ck_tv.Checked = False

    End Sub
End Class

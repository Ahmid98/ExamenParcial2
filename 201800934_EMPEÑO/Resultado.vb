Module Resultado

    Const corto_tv = 250
    Const corto_telefono = 550
    Const corto_laptop = 770
    Const corto_refri = 1000
    Const largo_tv = 300
    Const largo_telefono = 600
    Const largo_laptop = 800
    Const largo_refri = 1200

    Function PagoParcial(total As Double) As Double
        Dim costo_tv As Double = 0
        Dim costo_tel As Double = 0
        Dim costo_laptop As Double = 0
        Dim costo_refri As Double = 0
        Dim pagop As Double

        If SISTEMA.ck_tv.Checked Then
            Select Case SISTEMA.cb_plazo.SelectedIndex
                Case 0
                    costo_tv = corto_tv
                Case 1
                    costo_tv = largo_tv
            End Select

        End If

        If SISTEMA.ck_telefono.Checked Then
            Select Case SISTEMA.cb_plazo.SelectedIndex
                Case 0
                    costo_tel = corto_telefono
                Case 1
                    costo_tel = largo_telefono
            End Select

        End If

        If SISTEMA.ck_laptop.Checked Then
            Select Case SISTEMA.cb_plazo.SelectedIndex
                Case 0
                    costo_laptop = corto_laptop
                Case 1
                    costo_laptop = largo_laptop
            End Select

        End If

        If SISTEMA.ck_refri.Checked Then
            Select Case SISTEMA.cb_plazo.SelectedIndex
                Case 0
                    costo_refri = corto_refri
                Case 1
                    costo_refri = largo_refri
            End Select

        End If



        pagop = costo_tv + costo_tel + costo_laptop + costo_refri

        Return pagop


    End Function

    Function Descuento() As Double
        Dim descuento1 As Double

        If SISTEMA.ck_tv.Checked And SISTEMA.ck_refri.Checked Then
            Select Case SISTEMA.cb_plazo.SelectedIndex
                Case 0
                    descuento1 = PagoParcial(SISTEMA.matriz(3, SISTEMA.index)) * 0.15
                Case 1
                    descuento1 = PagoParcial(SISTEMA.matriz(3, SISTEMA.index)) * 0.05
            End Select
        End If

        If SISTEMA.ck_telefono.Checked And SISTEMA.ck_laptop.Checked Then
            Select Case SISTEMA.cb_plazo.SelectedIndex
                Case 0
                    descuento1 = PagoParcial(SISTEMA.matriz(3, SISTEMA.index)) * 0.05
                Case 1
                    descuento1 = PagoParcial(SISTEMA.matriz(3, SISTEMA.index)) * 0.1
            End Select
        End If

        Return descuento1
    End Function

    Function Total() As Double
        Dim total1 As Double = 0

        total1 = PagoParcial(SISTEMA.matriz(3, SISTEMA.index)) - Descuento()

        Return total1
    End Function
End Module

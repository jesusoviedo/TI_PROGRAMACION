Module ModuloPrincipal
    ''' <summary>
    ''' Tipos de datos https://msdn.microsoft.com/es-es/library/47zceaw7.aspx
    ''' Procedimiento https://msdn.microsoft.com/es-es/library/bza7eswf.aspx
    ''' Estructuras de control https://msdn.microsoft.com/es-es/library/ms225304(v=vs.90).aspx
    ''' Excepciones https://support.microsoft.com/es-es/kb/301283
    ''' </summary>

    Dim Valor1, Valor2, Operacion As Integer

    Sub Main()
        Do
            IngresarDatos()
            MostrarResultado()
            'se coloca esto para que la consola no se cierre luego de mostrar el resultado
            Console.ReadLine()
        Loop While Operacion <> 0
    End Sub

    Sub IngresarDatos()
        'inicializo los valores, limpio la consola y muestro un mensaje inicial
        Valor1 = 0
        Valor2 = 0
        Console.Clear()
        Console.Write("*** Calculadora ***" + vbCrLf) 'vbCrLf hace salto de linea

        'controlo que se ingrese un valor numerico y no alfanumerico
        Try
            Console.WriteLine("Ingrese el tipo de Operacion (1=suma , 2=resta, 3=multiplicacion, 4=division, 0= salir)")
            Operacion = Console.ReadLine()
        Catch ex As Exception
            Operacion = 99
        End Try

        'controlo si la opcion ingresada es correcta
        If Operacion >= 1 And Operacion <= 4 Then
            Dim err As Boolean
            'controlo que se ingrese un valor numerico y no alfanumerico
            Console.WriteLine("Ingrese el valor 1:")
            Do
                err = False
                Try
                    Valor1 = Console.ReadLine()
                Catch ex As Exception
                    Console.WriteLine("Debe ingresar un numero")
                    err = True
                End Try
            Loop Until err = False

            'controlo que se ingrese un valor numerico y no alfanumerico
            Console.WriteLine("Ingrese el valor 2:")
            Do
                err = False
                Try
                    Valor2 = Console.ReadLine()
                Catch ex As Exception
                    Console.WriteLine("Debe ingresar un numero")
                    err = True
                End Try
            Loop Until err = False
        End If
    End Sub

    Sub MostrarResultado()
        'usando case, se calcula el resultado de la operación
        Select Case Operacion
            Case 1
                Console.WriteLine("El resultado de la suma es: " + CalcularResultado(Valor1, Valor2, Operacion))
            Case 2
                Console.WriteLine("El resultado de la resta es: " & CalcularResultado(Valor1, Valor2, Operacion))
            Case 3
                Console.WriteLine("El resultado de la multiplicación es: " & CalcularResultado(Valor1, Valor2, Operacion))
            Case 4
                Console.WriteLine("El resultado de la división es: " & CalcularResultado(Valor1, Valor2, Operacion))
            Case 0
                Console.Clear()
                Console.WriteLine("*** Hasta luego ***")
            Case Else
                Console.Clear()
                Console.WriteLine("Opción no valida, ingrese una opción valida")
        End Select

        'usando if anidados, se calcula el resultado de la operación
        'If Operacion = 1 Then
        '    Console.WriteLine("El resultado de la suma es: " + CStr(Valor1 + Valor2))
        'Else
        '    If Operacion = 2 Then
        '        Console.WriteLine("El resultado de la resta es: " & CStr(Valor1 - Valor2))
        '    Else
        '        If Operacion = 3 Then
        '            Console.WriteLine("El resultado de la multiplicación es: " & CStr(Valor1 * Valor2))
        '        Else
        '            If Operacion = 4 Then
        '                Console.WriteLine("El resultado de la división es " & CStr(Valor1 / Valor2))
        '            Else
        '                If Operacion = 0 Then
        '                    Console.Clear()
        '                    Console.WriteLine("*** Hasta luego ***")
        '                Else
        '                    Console.Clear()
        '                    Console.WriteLine("Opcion no valida")
        '                End If
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Public Function CalcularResultado(valor1 As Integer, valor2 As Integer, tipoOperacion As Integer) As String
        Dim resultado As String

        If tipoOperacion = 1 Then
            resultado = CStr(valor1 + valor2)
        End If

        If tipoOperacion = 2 Then
            resultado = CStr(valor1 - valor2)
        End If

        If tipoOperacion = 3 Then
            resultado = CStr(valor1 * valor2)
        End If

        If tipoOperacion = 4 Then
            If valor2 = 0 Then
                resultado = "Infinito"
            Else
                resultado = CStr(valor1 / valor2)
            End If
        End If

        Return resultado
    End Function

End Module

Imports System.Data.OleDb

Module Module1



    Sub Main()

        Console.WriteLine("Reading iris dataset")

        'Dim path As String = "iris_inc_preds_simple.csv"
        Dim path As String = "iris_inc_preds_interactions.csv"
        Dim folder As String = "C:\Users\Rob\Documents\R_gbm_pmml_to_dotnet"

        Dim CnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";Extended Properties=""text;HDR=Yes;FMT=Delimited"";"

        Dim dssample As New DataSet
        Using Adp As New OleDbDataAdapter("select * from [" & path & "]", CnStr)
            Adp.Fill(dssample)
        End Using

        Console.WriteLine("No lines " & dssample.Tables(0).Rows.Count())

        fnScoreModel(dssample.Tables(0))

        Console.ReadKey()



    End Sub


    Public Function fnScoreModel(ByRef dt As DataTable)
        For Each row As DataRow In dt.Rows
            Dim score As Double = 5.8433333333333346
            If row.Item("PetalWidth") Is Nothing Then
                score = score + 0.000053999999999998968
            End If
            If row.Item("PetalWidth") < 1.25 Then
                'Start of a complex loop
                If row.Item("PetalWidth") Is Nothing Then
                    score = score + -0.00072954022988505856
                End If
                If row.Item("PetalWidth") < 0.25 Then
                    score = score + -0.00091000000000000141
                End If
                If row.Item("PetalWidth") >= 0.25 Then
                    score = score + -0.00053619047619047711
                End If
                'End of a complex loop
            End If
            If row.Item("PetalWidth") >= 1.25 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00054797101449275266
                End If
                If row.Item("PetalLength") < 5.45 Then
                    'Start of a complex loop
                    If row.Item("PetalLength") Is Nothing Then
                        score = score + 0.00019666666666666541
                    End If
                    If row.Item("PetalLength") < 4.6 Then
                        score = score + 0.000072051282051280814
                    End If
                    If row.Item("PetalLength") >= 4.6 Then
                        score = score + 0.00029196078431372417
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.45 Then
                    score = score + 0.0012066666666666664
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000016619138404080949
            End If
            If row.Item("PetalLength") < 3.95 Then
                'Start of a complex loop
                If row.Item("SepalWidth") Is Nothing Then
                    score = score + -0.000791154965986396
                End If
                If row.Item("SepalWidth") < 3.45 Then
                    'Start of a complex loop
                    If row.Item("PetalWidth") Is Nothing Then
                        score = score + -0.00088841242063492174
                    End If
                    If row.Item("PetalWidth") < 0.25 Then
                        score = score + -0.00099956619047619159
                    End If
                    If row.Item("PetalWidth") >= 0.25 Then
                        score = score + -0.00073279714285714418
                    End If
                    'End of a complex loop
                End If
                If row.Item("SepalWidth") >= 3.45 Then
                    score = score + -0.00057895688311688533
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 3.95 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00066109971073044472
                End If
                If row.Item("PetalLength") < 5.65 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + 0.00040280244390063577
                    End If
                    If row.Item("SepalWidth") < 2.8499999999999996 Then
                        score = score + 0.00023980649051928317
                    End If
                    If row.Item("SepalWidth") >= 2.8499999999999996 Then
                        score = score + 0.00052504940893665026
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.65 Then
                    score = score + 0.0012637933333333325
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.0000032822609706419332
            End If
            If row.Item("PetalLength") < 4.25 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + -0.00067554198730686332
                End If
                If row.Item("PetalLength") < 3.6 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + -0.00087778070927272832
                    End If
                    If row.Item("SepalWidth") < 3.25 Then
                        score = score + -0.001099970626666668
                    End If
                    If row.Item("SepalWidth") >= 3.25 Then
                        score = score + -0.000672682323986015
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 3.6 Then
                    score = score + -0.00021590852829353376
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 4.25 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00061726517872433165
                End If
                If row.Item("PetalLength") < 5.25 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + 0.00041473566413946191
                    End If
                    If row.Item("SepalWidth") < 2.8499999999999996 Then
                        score = score + 0.00025628930146035178
                    End If
                    If row.Item("SepalWidth") >= 2.8499999999999996 Then
                        score = score + 0.00058449962415279427
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.25 Then
                    score = score + 0.001204600771020454
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000043181174407935521
            End If
            If row.Item("PetalLength") < 4.25 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + -0.00061651738123065416
                End If
                If row.Item("PetalLength") < 3.4 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + -0.0008255859266215102
                    End If
                    If row.Item("SepalWidth") < 3.3499999999999996 Then
                        score = score + -0.0010206014277481562
                    End If
                    If row.Item("SepalWidth") >= 3.3499999999999996 Then
                        score = score + -0.00070370123841735643
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 3.4 Then
                    score = score + -0.00022824722550477856
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 4.25 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00061206020481802863
                End If
                If row.Item("PetalLength") < 5.4 Then
                    'Start of a complex loop
                    If row.Item("PetalLength") Is Nothing Then
                        score = score + 0.00042755803564234154
                    End If
                    If row.Item("PetalLength") < 4.95 Then
                        score = score + 0.00033429634038347486
                    End If
                    If row.Item("PetalLength") >= 4.95 Then
                        score = score + 0.00054625473869908089
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.4 Then
                    score = score + 0.0010733156277572466
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.0000074505413252837611
            End If
            If row.Item("PetalLength") < 4.15 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + -0.000705366290047346
                End If
                If row.Item("PetalLength") < 1.65 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + -0.00092494263187773936
                    End If
                    If row.Item("SepalWidth") < 3.3 Then
                        score = score + -0.001189431310802729
                    End If
                    If row.Item("SepalWidth") >= 3.3 Then
                        score = score + -0.00066045395295274956
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 1.65 Then
                    score = score + -0.00039168580171821256
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 4.15 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00057130886005398731
                End If
                If row.Item("PetalLength") < 5.35 Then
                    'Start of a complex loop
                    If row.Item("PetalLength") Is Nothing Then
                        score = score + 0.00029537502104048572
                    End If
                    If row.Item("PetalLength") < 4.55 Then
                        score = score + 0.000146529796687084
                    End If
                    If row.Item("PetalLength") >= 4.55 Then
                        score = score + 0.00041232484017530128
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.35 Then
                    score = score + 0.0010024554835125837
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.00006183866256026723
            End If
            If row.Item("PetalLength") < 4.3000000000000007 Then
                'Start of a complex loop
                If row.Item("PetalWidth") Is Nothing Then
                    score = score + -0.0006487765260316953
                End If
                If row.Item("PetalWidth") < 0.35 Then
                    'Start of a complex loop
                    If row.Item("PetalLength") Is Nothing Then
                        score = score + -0.00079413394075491725
                    End If
                    If row.Item("PetalLength") < 1.45 Then
                        score = score + -0.0007493224142691953
                    End If
                    If row.Item("PetalLength") >= 1.45 Then
                        score = score + -0.00083894546724063909
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalWidth") >= 0.35 Then
                    score = score + -0.00044112307642709254
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 4.3000000000000007 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00065112930675848013
                End If
                If row.Item("PetalLength") < 5.65 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + 0.000412488491266256
                    End If
                    If row.Item("SepalWidth") < 2.8499999999999996 Then
                        score = score + 0.00030115085537303345
                    End If
                    If row.Item("SepalWidth") >= 2.8499999999999996 Then
                        score = score + 0.00049289900607802782
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.65 Then
                    score = score + 0.001390915834784375
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000024551129013792565
            End If
            If row.Item("PetalLength") < 3.95 Then
                'Start of a complex loop
                If row.Item("PetalWidth") Is Nothing Then
                    score = score + -0.00069839593856875037
                End If
                If row.Item("PetalWidth") < 0.35 Then
                    score = score + -0.00084880698476990832
                End If
                If row.Item("PetalWidth") >= 0.35 Then
                    score = score + -0.00047856440950551935
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 3.95 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00047691477577129231
                End If
                If row.Item("PetalLength") < 5.45 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + 0.00023885082373986658
                    End If
                    If row.Item("SepalWidth") < 2.8499999999999996 Then
                        score = score + 0.000041555098144834142
                    End If
                    If row.Item("SepalWidth") >= 2.8499999999999996 Then
                        score = score + 0.00040132965658283445
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.45 Then
                    score = score + 0.0010919133185191424
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.0000045047705316903356
            End If
            If row.Item("PetalLength") < 4.25 Then
                'Start of a complex loop
                If row.Item("PetalWidth") Is Nothing Then
                    score = score + -0.000629074067759769
                End If
                If row.Item("PetalWidth") < 0.35 Then
                    'Start of a complex loop
                    If row.Item("PetalLength") Is Nothing Then
                        score = score + -0.00092753372761169748
                    End If
                    If row.Item("PetalLength") < 1.45 Then
                        score = score + -0.0010374908494972907
                    End If
                    If row.Item("PetalLength") >= 1.45 Then
                        score = score + -0.00081757660572610413
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalWidth") >= 0.35 Then
                    'Start of a complex loop
                    If row.Item("PetalLength") Is Nothing Then
                        score = score + -0.00033061440790784055
                    End If
                    If row.Item("PetalLength") < 3.75 Then
                        score = score + -0.00044947659514806996
                    End If
                    If row.Item("PetalLength") >= 3.75 Then
                        score = score + -0.00021175222066761111
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 4.25 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + 0.00070928871201468536
                End If
                If row.Item("PetalLength") < 5.3000000000000007 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + 0.00043508460749047917
                    End If
                    If row.Item("SepalWidth") < 2.95 Then
                        score = score + 0.00020474834676794309
                    End If
                    If row.Item("SepalWidth") >= 2.95 Then
                        score = score + 0.00064448120814733013
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 5.3000000000000007 Then
                    score = score + 0.0011205948688009946
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.000018977057960305786
            End If
            If row.Item("PetalLength") < 4.55 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + -0.00054196426317005349
                End If
                If row.Item("PetalLength") < 3.4 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + -0.000849564299092005
                    End If
                    If row.Item("SepalWidth") < 3.3499999999999996 Then
                        score = score + -0.0010764864803862093
                    End If
                    If row.Item("SepalWidth") >= 3.3499999999999996 Then
                        score = score + -0.00068747702673900178
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 3.4 Then
                    score = score + -0.00010770538892729868
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 4.55 Then
                'Start of a complex loop
                If row.Item("SepalWidth") Is Nothing Then
                    score = score + 0.00069540629814691555
                End If
                If row.Item("SepalWidth") < 2.8499999999999996 Then
                    score = score + 0.00043432583770194606
                End If
                If row.Item("SepalWidth") >= 2.8499999999999996 Then
                    score = score + 0.00092747781854244391
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000051209961069631237
            End If
            If row.Item("PetalLength") < 5.15 Then
                'Start of a complex loop
                If row.Item("PetalLength") Is Nothing Then
                    score = score + -0.00041924108916857351
                End If
                If row.Item("PetalLength") < 3.95 Then
                    'Start of a complex loop
                    If row.Item("SepalWidth") Is Nothing Then
                        score = score + -0.00076383714345913852
                    End If
                    If row.Item("SepalWidth") < 3.3499999999999996 Then
                        score = score + -0.00094803116278502862
                    End If
                    If row.Item("SepalWidth") >= 3.3499999999999996 Then
                        score = score + -0.00056813099792538016
                    End If
                    'End of a complex loop
                End If
                If row.Item("PetalLength") >= 3.95 Then
                    'Start of a complex loop
                    If row.Item("PetalLength") Is Nothing Then
                        score = score + 0.000054578485480953342
                    End If
                    If row.Item("PetalLength") < 4.6 Then
                        score = score + -0.000051735493927857929
                    End If
                    If row.Item("PetalLength") >= 4.6 Then
                        score = score + 0.00018022227932773031
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            If row.Item("PetalLength") >= 5.15 Then
                score = score + 0.0011142219445770191
            End If
            Console.WriteLine(" score delta  = " & CStr(score - row.Item("mdl_pred")))
        Next row
    End Function


End Module

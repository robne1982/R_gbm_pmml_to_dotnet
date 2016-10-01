Imports System.Data.OleDb

Module Module1



    Sub Main()

        Console.WriteLine("Reading iris dataset")

        Dim path As String = "iris_inc_preds_simple.csv"
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
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.00000066666666666804991
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.00066333333333333489
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.00075666666666666547
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000047332666666667651
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.00067517000000000076
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.00067019571428571288
            End If
            If row.Item("PetalWidth") Is Nothing Then
                score = score + 0.000024530308285712863
            End If
            If row.Item("PetalWidth") < 1.35 Then
                score = score + -0.00059086769749034859
            End If
            If row.Item("PetalWidth") >= 1.35 Then
                score = score + 0.00062373362969924643
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000080615290447027187
            End If
            If row.Item("PetalLength") < 3.95 Then
                score = score + -0.00083837365927220714
            End If
            If row.Item("PetalLength") >= 3.95 Then
                score = score + 0.00051476628505847135
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000011148275596027115
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.00064083275316667565
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.0007084911273418569
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.000023258547748459267
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.00062407050888537308
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.000653552629207717
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.000086510662653482538
            End If
            If row.Item("PetalLength") < 3.75 Then
                score = score + -0.00080730068538118621
            End If
            If row.Item("PetalLength") >= 3.75 Then
                score = score + 0.00053341633667081687
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.00010011820551476484
            End If
            If row.Item("PetalLength") < 4.6 Then
                score = score + -0.00056828023041101481
            End If
            If row.Item("PetalLength") >= 4.6 Then
                score = score + 0.00083620584427773509
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.00012420012421415284
            End If
            If row.Item("PetalLength") < 4.05 Then
                score = score + -0.0007921610080047131
            End If
            If row.Item("PetalLength") >= 4.05 Then
                score = score + 0.000526182841581919
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.000052546161521813707
            End If
            If row.Item("PetalLength") < 4.55 Then
                score = score + -0.00054851228987916171
            End If
            If row.Item("PetalLength") >= 4.55 Then
                score = score + 0.00086021845559187439
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.00005861672796182243
            End If
            If row.Item("PetalLength") < 3.95 Then
                score = score + -0.00077234659963258342
            End If
            If row.Item("PetalLength") >= 3.95 Then
                score = score + 0.00055365871035848975
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.000080253947616539659
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.00069514452150349411
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.00079600638065041693
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000038402132683057455
            End If
            If row.Item("PetalLength") < 3.85 Then
                score = score + -0.0007617836067130403
            End If
            If row.Item("PetalLength") >= 3.85 Then
                score = score + 0.00044385218333693104
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.000018279232852721587
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.00060268016807309079
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.000506175905008717
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + 0.000028068729321484132
            End If
            If row.Item("PetalLength") < 4.55 Then
                score = score + -0.000554038496495108
            End If
            If row.Item("PetalLength") >= 4.55 Then
                score = score + 0.0007689324712698742
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000053183351551465234
            End If
            If row.Item("PetalLength") < 4.55 Then
                score = score + -0.00049323233307002742
            End If
            If row.Item("PetalLength") >= 4.55 Then
                score = score + 0.00082691461148565908
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000029619269927324818
            End If
            If row.Item("PetalLength") < 3.95 Then
                score = score + -0.00081822426497065381
            End If
            If row.Item("PetalLength") >= 3.95 Then
                score = score + 0.00062434584791348454
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.00005920823132274402
            End If
            If row.Item("PetalLength") < 3.8 Then
                score = score + -0.00081188698117705264
            End If
            If row.Item("PetalLength") >= 3.8 Then
                score = score + 0.00044257760191346177
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.00010808078473257244
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.0007060058445315584
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.00050600441181773736
            End If
            If row.Item("PetalLength") Is Nothing Then
                score = score + -0.000036535721029430642
            End If
            If row.Item("PetalLength") < 4.25 Then
                score = score + -0.00066451135997058525
            End If
            If row.Item("PetalLength") >= 4.25 Then
                score = score + 0.00057491424320274618
            End If
            Console.WriteLine(" score delta  = " & CStr(score - row.Item("mdl_pred")))
        Next row
    End Function





End Module

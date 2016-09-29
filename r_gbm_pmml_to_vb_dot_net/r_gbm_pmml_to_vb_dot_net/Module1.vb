Imports System.Data.OleDb

Module Module1



    Sub Main()

        Console.WriteLine("Reading iris dataset")

        Dim path As String = "iris_preds.csv"
        Dim folder As String = "C:\Users\Rob\Documents\R_gbm_pmml_to_dotnet"

        Dim CnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folder & ";Extended Properties=""text;HDR=Yes;FMT=Delimited"";"

        Dim dssample As New DataSet
        Using Adp As New OleDbDataAdapter("select * from [" & path & "]", CnStr)
            Adp.Fill(dssample)
        End Using

        Console.WriteLine("No lines " & dssample.Tables(0).Rows.Count())


        Console.ReadKey()

    End Sub

End Module

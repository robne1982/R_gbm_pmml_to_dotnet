Imports System.Data.OleDb

Module Module1



    Sub Main()

        Console.WriteLine("Reading iris dataset")

        'Dim path As String = "iris_inc_preds_simple.csv"
        Dim path As String = "titanic_inc_preds_interactions.csv"
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
            Dim score As Double = -0.47328770444692542
            ' Tree #1
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000045684481973026788
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00081690333899884528
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00013414308109224908
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010295172789609871
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015337294786483412
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022486667983409089
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000591827930481942
                End If
                'End of a complex loop
            End If
            ' Tree #2
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00015045093108400902
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00089863486147689334
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013662756761070082
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023876822852678865
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.0001796415272289287
                    End If
                    If row.Item("Age") < 27.5 Then
                        score = score + 0.00057179753022252363
                    End If
                    If row.Item("Age") >= 27.5 Then
                        score = score + -0.0010948654825002548
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #3
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000084257551904804047
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00090009736688789451
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000082008654919068241
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0011912526919368612
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014883810388191794
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023839804282507109
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000519170740667248
                End If
                'End of a complex loop
            End If
            ' Tree #4
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000029411313144599549
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00071905464427437051
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00013322186891238632
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.000912515700324142
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013757085698856402
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.00233973358823146
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000322891773534284
                End If
                'End of a complex loop
            End If
            ' Tree #5
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00008490919454000037
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00088885568107013
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000053349421872639829
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0011170556285161407
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014044532067882527
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023766817192413339
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00040697200570002706
                End If
                'End of a complex loop
            End If
            ' Tree #6
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000075695134562115681
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.000840369250631251
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.0000969096309511998
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010358478575298851
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013983148391764151
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023325063383565444
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00027457723871336079
                End If
                'End of a complex loop
            End If
            ' Tree #7
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000047374200982730069
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00081359157336112085
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000027480020584875565
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.001019397602199537
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014444662458996996
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022230523481856618
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00051919000840044
                End If
                'End of a complex loop
            End If
            ' Tree #8
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00013312577401789125
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.0008849840529406329
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00012795405905055012
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0011339264702943982
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001330757232626387
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023632957299193689
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00022749692045032446
                End If
                'End of a complex loop
            End If
            ' Tree #9
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000057646213060050055
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00090089808819229908
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000090936109364232593
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0011042651651274847
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015045319402298217
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.00241770830953547
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.0005432936567501918
                End If
                'End of a complex loop
            End If
            ' Tree #10
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000046177275875960072
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00077727156359883845
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00024162327888304342
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010409329482761675
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015419356108713218
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0024249979694357334
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00048716668258605244
                End If
                'End of a complex loop
            End If
            ' Tree #11
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00007388008916596971
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00071263740504864763
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00019016733331986052
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00097966415865060057
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013583701980608477
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002152029190872541
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000432434706447205
                End If
                'End of a complex loop
            End If
            ' Tree #12
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000082765783209927724
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00080296035943864
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.0001228418714039934
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010645098686004602
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0016759587190432004
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0024722211596031065
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000610372217705679
                End If
                'End of a complex loop
            End If
            ' Tree #13
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000036472710708532565
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00077185846987339718
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0016422849889115606
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023557983501784549
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00076902983034610834
                    End If
                    If row.Item("SibSp") < 2.5 Then
                        score = score + 0.0011641511000096841
                    End If
                    If row.Item("SibSp") >= 2.5 Then
                        score = score + -0.0012424966333957313
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #14
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000012182892193178186
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00081560631040614347
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000015223974775469953
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010405472609793314
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015059743461183341
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0024052933384145349
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000454657777659395
                End If
                'End of a complex loop
            End If
            ' Tree #15
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000015619830116689266
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00080366645751883345
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00014169647683955029
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00097863649646489953
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015038170741128603
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022671680700393415
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.0005441758220909984
                End If
                'End of a complex loop
            End If
            ' Tree #16
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000025357697223008597
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00073880191777410159
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00014568526126284767
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010045447025071759
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014550756865724403
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002290863064262471
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00054022734072254241
                End If
                'End of a complex loop
            End If
            ' Tree #17
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000041351456332521084
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.0007988298799231526
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000022784646943808248
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.000986033189842207
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013899876427900359
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022009657975454321
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00039095658258411309
                End If
                'End of a complex loop
            End If
            ' Tree #18
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000031171151029937726
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00080190808712017885
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00016599051332614022
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.000973549556153083
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013688383468048672
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022518285462240907
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00062959073798877336
                End If
                'End of a complex loop
            End If
            ' Tree #19
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000041268677253332834
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00074552986062297088
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000027150450254979841
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00093441410214214094
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013162874196368248
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023245800441187509
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00025349249112884871
                End If
                'End of a complex loop
            End If
            ' Tree #20
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000061642697822241713
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00073018378414853584
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000351938933055527
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010149529202548681
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015141651615648145
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023364482914152575
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00056797635461361981
                End If
                'End of a complex loop
            End If
            ' Tree #21
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000089254019639748727
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00070533263369602309
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000010964839132469345
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00090238295377486949
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015046114958940922
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023879360501040422
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00045188223265757622
                End If
                'End of a complex loop
            End If
            ' Tree #22
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00004274737641002224
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00090731984222625235
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001558928537826455
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023168010939428234
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.000781370980252519
                    End If
                    If row.Item("Age") < 6.5 Then
                        score = score + 0.0016046135835177189
                    End If
                    If row.Item("Age") >= 6.5 Then
                        score = score + 0.00025589697816834876
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #23
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000006057397825597856
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00084933974370794913
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014814717091966862
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022819825947455667
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00056355256043396978
                    End If
                    If row.Item("SibSp") < 1.5 Then
                        score = score + 0.00092847867769132509
                    End If
                    If row.Item("SibSp") >= 1.5 Then
                        score = score + -0.0010264826647587927
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #24
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000043767502798801281
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00084138291379601423
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00025408283083936566
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010095525410743498
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014784789025030691
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023152143237564304
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00053715155359303777
                End If
                'End of a complex loop
            End If
            ' Tree #25
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000067497615034425659
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00087123786133789507
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00005119714029276588
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0011033955083917673
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0016759407178430971
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022860114908490538
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.0009339627506736904
                End If
                'End of a complex loop
            End If
            ' Tree #26
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000068841116098960524
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00073339190116174745
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014433989078688322
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023689554631168672
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00042291347515946057
                    End If
                    If row.Item("SibSp") < 0.5 Then
                        score = score + 0.0011789400056978431
                    End If
                    If row.Item("SibSp") >= 0.5 Then
                        score = score + -0.00045911747713531893
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #27
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000048920798109531344
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00072504442932506085
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00012288400520461392
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00090458767504904736
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014009711645539115
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022739136246989564
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00036287742816520983
                End If
                'End of a complex loop
            End If
            ' Tree #28
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000083049689742659564
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00087990293050484126
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00023270916705243373
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010515499721161319
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014226924729962682
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023016035465460733
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00044746237768758014
                End If
                'End of a complex loop
            End If
            ' Tree #29
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000027028209256571556
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00086014241359133668
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + -0.00043669373115317689
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + -0.0011464514659216833
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0016114297259351331
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022198607881008048
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00074785015382901809
                End If
                'End of a complex loop
            End If
            ' Tree #30
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000029836340332732296
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.000793919537781505
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000045497154435678765
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010155836859427527
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0016019717417010808
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0024003604717885881
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00065531081888303667
                End If
                'End of a complex loop
            End If
            ' Tree #31
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000021461121746544636
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00073670198415571523
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014122316599621549
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.00228891938655766
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00050138726869409741
                    End If
                    If row.Item("Age") < 36 Then
                        score = score + 0.0007930298776185488
                    End If
                    If row.Item("Age") >= 36 Then
                        score = score + -0.0012484683848526105
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #32
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000056809787648828251
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00085057713723894019
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000159624767443652
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010218388357352082
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014580926050329539
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022572055138866251
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00037621666689259916
                End If
                'End of a complex loop
            End If
            ' Tree #33
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00015012264652342218
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00098642716959291958
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014946095821799228
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023836821281790752
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00053144765734750769
                    End If
                    If row.Item("Age") < 6.5 Then
                        score = score + 0.0014784068908947046
                    End If
                    If row.Item("Age") >= 6.5 Then
                        score = score + 0.000086956588539639752
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #34
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000552480270608621
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00084828444921892956
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001458259393005515
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022788648530696403
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00055896573814072
                    End If
                    If row.Item("Age") < 36.5 Then
                        score = score + 0.00090662377208004167
                    End If
                    If row.Item("Age") >= 36.5 Then
                        score = score + -0.001631279875677006
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #35
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000012986580782585777
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00090223215658444072
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00025425144554620333
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010721470985900227
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015556205218741025
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023507627323299885
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00044004786839868016
                End If
                'End of a complex loop
            End If
            ' Tree #36
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00000060021502529897835
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00072782275353561
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00013555017441948042
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0008850632612655558
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013108453031285693
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023241303258609608
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00028473388770336282
                End If
                'End of a complex loop
            End If
            ' Tree #37
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000039845798970035384
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00079496831823690326
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000077654519058269469
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00096356771547974449
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001359067073261534
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022939474804491915
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000050234503198814181
                End If
                'End of a complex loop
            End If
            ' Tree #38
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00004531453784986286
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.000777932445783917
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00019749551679140444
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010510522753050069
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015554746097385802
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022800339197595379
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00067783938914981454
                End If
                'End of a complex loop
            End If
            ' Tree #39
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000084594223584647565
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Age") Is Nothing Then
                    score = score + -0.00085678706517367757
                End If
                If row.Item("Age") < 13 Then
                    score = score + -0.00030747956439922109
                End If
                If row.Item("Age") >= 13 Then
                    score = score + -0.0010614818414056684
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013745493926647532
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.00231017206361532
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00041430507247864511
                End If
                'End of a complex loop
            End If
            ' Tree #40
            If row.Item("Sex") Is Nothing Then
                score = score + 0.0000053840695990394652
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00087278529006091924
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014956108617492723
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021958579658672762
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00061310766203891143
                    End If
                    If row.Item("SibSp") < 2.5 Then
                        score = score + 0.00090276993497513842
                    End If
                    If row.Item("SibSp") >= 2.5 Then
                        score = score + -0.0012117646574593183
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #41
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000085275463626634208
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00084574557678621673
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.0003389394138038812
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00098161276090488552
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001456357826996193
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023568618744531553
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00043839672987093167
                End If
                'End of a complex loop
            End If
            ' Tree #42
            If row.Item("Sex") Is Nothing Then
                score = score + 0.0000084639775900584072
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00071299752633067755
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00013682510777153275
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.000871507842353499
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.00138537090010545
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022599920359883639
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00034832012470142361
                End If
                'End of a complex loop
            End If
            ' Tree #43
            If row.Item("Sex") Is Nothing Then
                score = score + 0.0000068285229626311
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00073133227270857817
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + -0.00034769079834127276
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + -0.00097363215125635
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001247472269904001
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022591578334667755
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00021111144869335351
                End If
                'End of a complex loop
            End If
            ' Tree #44
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000010080860052792641
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.000769456564591722
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000081810041376603
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00093633312671087218
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015410810906175145
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023509045512540641
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000562040787459895
                End If
                'End of a complex loop
            End If
            ' Tree #45
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00004765867430227211
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00069467106183668064
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000026991530098050284
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00087885851886802693
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015223539890481112
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0023393597505236476
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00069430760917425685
                End If
                'End of a complex loop
            End If
            ' Tree #46
            If row.Item("Sex") Is Nothing Then
                score = score + 0.0000126467304673002
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.0008381327478168615
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000031970748829579373
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010415335652147308
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015280976761609633
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021349159130040038
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.0006857977354683849
                End If
                'End of a complex loop
            End If
            ' Tree #47
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000038466426174674714
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00087045375375161113
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.0001123985669073572
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010860474307440137
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015808764284738267
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021416811345742349
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000800626402594997
                End If
                'End of a complex loop
            End If
            ' Tree #48
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000003955137854833272
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00079150492105123089
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001353826752968154
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002118611771939235
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00043608473020285678
                    End If
                    If row.Item("Age") < 27.5 Then
                        score = score + 0.0008838243780471
                    End If
                    If row.Item("Age") >= 27.5 Then
                        score = score + -0.0013548738611741163
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #49
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000073305058066127241
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00092786221018013816
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014638229010823451
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022534518655697995
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00043387207783783928
                    End If
                    If row.Item("Age") < 19.5 Then
                        score = score + 0.0011263154064977713
                    End If
                    If row.Item("Age") >= 19.5 Then
                        score = score + -0.00041492942180981947
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #50
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00017439089691945843
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.0009787041142056978
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014234393870854198
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022298895058339612
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.000462814980929069
                    End If
                    If row.Item("SibSp") < 1.5 Then
                        score = score + 0.00076251801135529507
                    End If
                    If row.Item("SibSp") >= 1.5 Then
                        score = score + -0.0009357991610599853
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #51
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000031182918566369819
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00073503410755428131
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000012111701422963972
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00098522513533106531
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014790345718203276
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022012847084763396
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00046337031714781062
                End If
                'End of a complex loop
            End If
            ' Tree #52
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00002428148008160825
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00071263250691002171
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000042069032175743664
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00092730316691663935
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013894618790596918
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022261958482373842
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00046227018348441096
                End If
                'End of a complex loop
            End If
            ' Tree #53
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00011631176124903838
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00079949366766683032
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000054019062761518468
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010229454983798315
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012138569836968609
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020587556793353655
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00028681535931572355
                End If
                'End of a complex loop
            End If
            ' Tree #54
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000060223429284025471
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00079859003363005876
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000059666728626895921
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00098805754773343378
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001377391018912887
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022126017340515156
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00046097926202466984
                End If
                'End of a complex loop
            End If
            ' Tree #55
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000051200813309148711
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00073158746441104739
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000068340125143913285
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00095262008784070763
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013676202334503744
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002269281142712173
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00031356593107390572
                End If
                'End of a complex loop
            End If
            ' Tree #56
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000752673130150943
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00088279847740436979
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00024452828002607052
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010696793910511691
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013915772704008683
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022277510282961515
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00034038740333251251
                End If
                'End of a complex loop
            End If
            ' Tree #57
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000040716805536419545
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00075158820973862412
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013433639417182041
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022554920101555071
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00034255675551616324
                    End If
                    If row.Item("Age") < 7 Then
                        score = score + 0.0010167843898367997
                    End If
                    If row.Item("Age") >= 7 Then
                        score = score + -0.00013903441185571998
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #58
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000017439002291194334
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.0007736492326453012
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + -0.00032361064911708474
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + -0.0010293529732863333
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012175552200622583
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002124731825365914
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00025506296809374576
                End If
                'End of a complex loop
            End If
            ' Tree #59
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000045542576875643106
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00083843592914407549
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00012907274786725861
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010251104505327115
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014089369483046661
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021635997141395188
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00051801562752740952
                End If
                'End of a complex loop
            End If
            ' Tree #60
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00011335249994680167
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00072880443716454686
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000083158320688171228
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.000978935144559934
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014887093913239151
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022557587101368621
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00073068418214406155
                End If
                'End of a complex loop
            End If
            ' Tree #61
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000068996388774458225
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00090799514777615783
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000043307063916935489
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0011822444340300225
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014401460330776556
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020865569080417883
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00055253707044033919
                End If
                'End of a complex loop
            End If
            ' Tree #62
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000029336034332430926
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00080884249456194906
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000028385777412835987
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010437210143014815
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014935614891294035
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021458958484047177
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00082491877087220635
                End If
                'End of a complex loop
            End If
            ' Tree #63
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000027242581671165862
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.000770129534965148
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012456307956191326
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021518383634219775
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00027059733659075508
                    End If
                    If row.Item("Age") < 28 Then
                        score = score + 0.00062690954127978427
                    End If
                    If row.Item("Age") >= 28 Then
                        score = score + -0.00093690513485539934
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #64
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00015620040930382464
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00088836349315090117
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000070407951769715021
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010690364038977497
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001422363970054411
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021851904405622395
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00042193581201135753
                End If
                'End of a complex loop
            End If
            ' Tree #65
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0001077323093134069
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00080325675294673222
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0011681341860139667
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021137565030743448
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00030323572528801086
                    End If
                    If row.Item("SibSp") < 2.5 Then
                        score = score + 0.00064680275878304088
                    End If
                    If row.Item("SibSp") >= 2.5 Then
                        score = score + -0.0011139782878789876
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #66
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00000931685729929418
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.0009167901677681246
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00024619186196386084
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00110792688294905
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013392189001571802
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022153563658813247
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00030281238582496026
                End If
                'End of a complex loop
            End If
            ' Tree #67
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00015924997345975845
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00057537930663079421
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00070965496727360756
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00087807626892827569
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013821657810356486
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021139032962529643
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00048456776236907437
                End If
                'End of a complex loop
            End If
            ' Tree #68
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00017838983995637772
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00089024085163838442
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012944053566270844
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021428664800648913
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.000021713671470373834
                    End If
                    If row.Item("SibSp") < 1.5 Then
                        score = score + 0.00040855891700678995
                    End If
                    If row.Item("SibSp") >= 1.5 Then
                        score = score + -0.00131736602461722
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #69
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000083434369044172067
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00084528253636067174
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000038058408773826434
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010677176292957136
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013004290741193431
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021127895656132163
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000508377594912817
                End If
                'End of a complex loop
            End If
            ' Tree #70
            If row.Item("Sex") Is Nothing Then
                score = score + 0.0000681751431642573
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00075775393256165258
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000051921116414186911
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00094376036273177775
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001379097455217591
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021243136055651814
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00036846185406127
                End If
                'End of a complex loop
            End If
            ' Tree #71
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000073241879576674649
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00079206090207739437
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.000019859693473657266
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00097326206503299388
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013904880840680961
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021071476218706134
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00070878754810960426
                End If
                'End of a complex loop
            End If
            ' Tree #72
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000019099477497348462
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00072645837670427327
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00014370695979778412
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.000945891374604792
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001278476082831278
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002174204985051339
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00022101835104370644
                End If
                'End of a complex loop
            End If
            ' Tree #73
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00011833527969004528
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00068284341947855815
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014779112540367664
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021933933854005462
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00048245785387846364
                    End If
                    If row.Item("SibSp") < 2.5 Then
                        score = score + 0.00077099186630178156
                    End If
                    If row.Item("SibSp") >= 2.5 Then
                        score = score + -0.0012198928194191118
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #74
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000031919861914598115
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00079445023439924409
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000055821673319711679
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00099054631256195172
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013396756508565263
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002266964284213933
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00021920188554965921
                End If
                'End of a complex loop
            End If
            ' Tree #75
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000075504079174324839
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00083844927037924493
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013805743249553264
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021083804899894496
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00054000945829619856
                    End If
                    If row.Item("Age") < 1.5 Then
                        score = score + 0.0012841249928032166
                    End If
                    If row.Item("Age") >= 1.5 Then
                        score = score + 0.00024819944476403452
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #76
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000033627126119765993
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.0008680557368952311
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00017250399179827942
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010537460217853673
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013823729406507205
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021648022435790649
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00053061445898188949
                End If
                'End of a complex loop
            End If
            ' Tree #77
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000029824525052781663
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.0007386354321236902
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012832931168926835
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021223739345531049
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00016869322477660147
                    End If
                    If row.Item("SibSp") < 2.5 Then
                        score = score + 0.00048599617149808888
                    End If
                    If row.Item("SibSp") >= 2.5 Then
                        score = score + -0.0016399335715358767
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #78
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00007438000313939604
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00081879290841379453
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.0000099295063660367265
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010287531957538507
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014044536878755163
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020904910363609436
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00063021153744196256
                End If
                'End of a complex loop
            End If
            ' Tree #79
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00010820216719863199
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00087620487375744249
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00021886612663513032
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010513038413315081
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013287061224920456
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022039167665063053
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00023786387053224383
                End If
                'End of a complex loop
            End If
            ' Tree #80
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00004250807414933141
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00087232998901272233
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00040778364899601356
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00099404518727037525
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014947902168475915
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020648803316811472
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00075702653882769606
                End If
                'End of a complex loop
            End If
            ' Tree #81
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00001958463582683535
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00077615489275038288
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00019501041034025341
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00098227510326037932
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013068103438193942
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021112408718705362
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00042292988707184296
                End If
                'End of a complex loop
            End If
            ' Tree #82
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0001112976436507042
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00075123743858699656
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00011825072915458114
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0009603491193816338
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0011859952739752492
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020196577103077182
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00026896659400953328
                End If
                'End of a complex loop
            End If
            ' Tree #83
            If row.Item("Sex") Is Nothing Then
                score = score + 0.0000047949306423684479
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00083952919942637027
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014797562195896098
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021894356189080711
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00071548609724665147
                    End If
                    If row.Item("SibSp") < 0.5 Then
                        score = score + 0.0012050106982647475
                    End If
                    If row.Item("SibSp") >= 0.5 Then
                        score = score + 0.0000819836723997036
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #84
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000034164077568126932
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00076705832922466
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000059070052542421262
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00096441789307855845
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014112792031675968
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021379547920491026
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.0005634910161391736
                End If
                'End of a complex loop
            End If
            ' Tree #85
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000010573645697113509
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00078516960744395338
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.0000080604153891731138
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00099679309278029988
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014279913153546389
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021501194756831984
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00047561939376190111
                End If
                'End of a complex loop
            End If
            ' Tree #86
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00010704327041871762
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00089853486901363892
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014653158784678373
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0022295249254003788
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00047772264858578364
                    End If
                    If row.Item("Age") < 6.5 Then
                        score = score + 0.0013810916211881392
                    End If
                    If row.Item("Age") >= 6.5 Then
                        score = score + -0.00024999124601055852
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #87
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00016050252148983873
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00087631819618569178
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00012550723319399365
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0010775994330728279
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012906068054446115
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.00211181885382185
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.0003872735522296491
                End If
                'End of a complex loop
            End If
            ' Tree #88
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00023401265477891327
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.000905237542402944
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.0000025352507433655865
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0011183987650850733
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.001228298707544868
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020526434983502437
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.0002493892684634845
                End If
                'End of a complex loop
            End If
            ' Tree #89
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000498793380268211
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00078151395801580878
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00012200740542710973
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00099272674427519224
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012533448288285631
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021143815784636808
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00039230807919344565
                End If
                'End of a complex loop
            End If
            ' Tree #90
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00007704606932934975
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00075451425866907224
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00023463402580941304
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00091304276016887867
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012031048598775283
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021090767087649982
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00024881451238272661
                End If
                'End of a complex loop
            End If
            ' Tree #91
            If row.Item("Sex") Is Nothing Then
                score = score + 0.00010466651486571352
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00072443168492891013
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0014716915228604203
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002176851025593255
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00065804594278407228
                    End If
                    If row.Item("SibSp") < 2.5 Then
                        score = score + 0.00091042827535252053
                    End If
                    If row.Item("SibSp") >= 2.5 Then
                        score = score + -0.00087919190104193028
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #92
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000016628187832129964
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00075949985682366547
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012937789798299576
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020860058555839125
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("Age") Is Nothing Then
                        score = score + 0.00026388404134981651
                    End If
                    If row.Item("Age") < 5.5 Then
                        score = score + 0.0010817047188237943
                    End If
                    If row.Item("Age") >= 5.5 Then
                        score = score + -0.00021937363170298856
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #93
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000013647327337760933
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.0007116645896167778
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00024294994719597894
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00097471392864962637
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013311442904134106
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0019717299015048896
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00058525693503292135
                End If
                'End of a complex loop
            End If
            ' Tree #94
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000033057659460344187
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00071179762609189829
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.000014443499909317645
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0008801244841359693
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013994163998364323
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021608231739173017
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.000500533402657628
                End If
                'End of a complex loop
            End If
            ' Tree #95
            If row.Item("Sex") Is Nothing Then
                score = score + 0.000032646214725583294
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.000643198956158614
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012483174026053344
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021645041856606945
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.0000834513498635196
                    End If
                    If row.Item("SibSp") < 2.5 Then
                        score = score + 0.00044000642783369556
                    End If
                    If row.Item("SibSp") >= 2.5 Then
                        score = score + -0.0013427689620171841
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #96
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000062923314889116268
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00084790431061982751
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00028870644068989149
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00098830897060223576
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013913042989966244
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020566892468727197
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00061502185980784677
                End If
                'End of a complex loop
            End If
            ' Tree #97
            If row.Item("Sex") Is Nothing Then
                score = score + -0.0000188851767278634
            End If
            If row.Item("Sex") = "male" Then
                score = score + -0.00085532039683999328
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0015004623433492333
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020727100550998138
                End If
                If row.Item("Pclass") >= 2.5 Then
                    'Start of a complex loop
                    If row.Item("SibSp") Is Nothing Then
                        score = score + 0.00072323037664322079
                    End If
                    If row.Item("SibSp") < 0.5 Then
                        score = score + 0.0016681214169032871
                    End If
                    If row.Item("SibSp") >= 0.5 Then
                        score = score + -0.00025029372544290834
                    End If
                    'End of a complex loop
                End If
                'End of a complex loop
            End If
            ' Tree #98
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00004991978001792126
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00071770688892634315
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + 0.00013235400878056414
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.00095746765494624008
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0013317087211719171
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0020030537098096948
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00040723365485104292
                End If
                'End of a complex loop
            End If
            ' Tree #99
            If row.Item("Sex") Is Nothing Then
                score = score + -0.00016171128940797088
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00085854540679101532
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00018996730811355006
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.001059118836394255
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012653668003011407
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.0021261168651833858
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00038070701139438851
                End If
                'End of a complex loop
            End If
            ' Tree #100
            If row.Item("Sex") Is Nothing Then
                score = score + -0.000020479204640614792
            End If
            If row.Item("Sex") = "male" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + -0.00076457757973424629
                End If
                If row.Item("Pclass") < 1.5 Then
                    score = score + -0.00014334105076879638
                End If
                If row.Item("Pclass") >= 1.5 Then
                    score = score + -0.0009368295264019391
                End If
                'End of a complex loop
            End If
            If row.Item("Sex") = "female" Then
                'Start of a complex loop
                If row.Item("Pclass") Is Nothing Then
                    score = score + 0.0012544698404893268
                End If
                If row.Item("Pclass") < 2.5 Then
                    score = score + 0.002017230420087634
                End If
                If row.Item("Pclass") >= 2.5 Then
                    score = score + 0.00032678805449138547
                End If
                'End of a complex loop
            End If
            Console.WriteLine(" score  = " & CStr(score))
            Console.WriteLine(" score delta  = " & CStr(score - row.Item("mdl_pred")))
        Next row
    End Function



End Module

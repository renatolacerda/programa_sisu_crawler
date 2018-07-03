Public Class Dates

    Private Sub Dates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t As New ArrayList
        Dim d_ini As Date = New DateTime(2012, 1, 1)
        Dim d_fim As Date = New DateTime(2012, 12, 31)

        Do Until (d_ini.Equals(d_fim))
            t.Add(d_ini)
            d_ini = d_ini.AddDays(1)
        Loop
        dg.DataSource = t

        'dg.Columns.remo
    End Sub

End Class
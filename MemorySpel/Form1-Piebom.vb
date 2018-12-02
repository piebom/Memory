Imports System.IO
Imports System.TimeSpan

Public Class Form1
    '//////////////////////////////////////////////////////////////////////////////
    Dim aantal As Integer = 63
    Dim buttons As New List(Of Button)
    Dim knopMarge As Integer = 10
    Private Const lengte As Integer = 85
    Dim index As New List(Of Integer)
    Dim knoppen As New List(Of Button)
    Dim nummer As Integer = 0
    Dim tags As New List(Of Integer)
    Dim geklikt As Boolean = False
    Dim Games As New ComboBox
    Dim groote As New ComboBox
    Dim button As New Button
    Dim Aantalcorrect As Integer = 0
    '//////////////////////////////////////////////////////////////////////////////

    'Laad het spel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartGame()
    End Sub

    'Maakt KeuzeMenu
    Private Function StartGame() As ComboBox
        Games.Items.Add("Smileys")
        Games.Items.Add("Vlaggen")
        groote.Items.Add("4x4")
        groote.Items.Add("8x8")
        button.Text = "play"
        button.Left = 165
        Games.Left = 20
        Games.Top = 15
        groote.Left = 20
        groote.Top = 40
        button.Top = 15
        button.FlatStyle = FlatStyle.Flat
        Me.Text = "Memory"
        Me.Size = New Size(300, 110)
        Me.Controls.Add(button)
        Me.Controls.Add(Games)
        Me.Controls.Add(groote)
        AddHandler button.Click, AddressOf play_click
    End Function

    'Start het spel
    Private Sub play_click(sender As Object, e As EventArgs)
        Me.Controls.Remove(button)
        Me.Controls.Remove(Games)
        Me.Controls.Remove(groote)
        Me.BackColor = Color.Gray
        If Games.SelectedItem = "Smileys" Then
            If groote.SelectedItem = "4x4" Then
                Me.Size = New Size(410, 425)
                aantal = 15
                maakRij(knopMarge, 3, RandomArray(aantal, aantal + 1))
                smileys(knopMarge, ImageList1, 3, tags)
            ElseIf groote.SelectedItem = "8x8" Then
                Me.Size = New Size(785, 805)
                aantal = 63
                maakRij(knopMarge, 7, RandomArray(aantal, aantal + 1))
                smileys(knopMarge, ImageList1, 7, tags)
            End If

        ElseIf Games.SelectedItem = "Vlaggen" Then
            If groote.SelectedItem = "4x4" Then
                Me.Size = New Size(410, 425)
                aantal = 15
                maakRij(knopMarge, 3, RandomArray(aantal, aantal + 1))
                smileys(knopMarge, ImageList2, 3, tags)
            ElseIf groote.SelectedItem = "8x8" Then
                Me.Size = New Size(785, 805)
                aantal = 63
                maakRij(knopMarge, 7, RandomArray(aantal, aantal + 1))
                smileys(knopMarge, ImageList2, 7, tags)
            End If
        End If
    End Sub

    'Kijkt of de kaarten hetzelfde is
    Private Async Function GoedeKaarten() As Task(Of String)
        If nummer = 1 Then
            geklikt = True
            If knoppen(0).Tag = knoppen(1).Tag Then
                nummer = 0
                knoppen.Clear()
                geklikt = False
                Aantalcorrect += 1
            Else
                Await Task.Delay(750)
                knoppen(0).Visible = True
                knoppen(1).Visible = True
                knoppen.Clear()
                geklikt = False
                nummer = 0
            End If
        Else
            nummer += 1
        End If
        If Aantalcorrect = (aantal + 1) / 2 Then
            MessageBox.Show("YOU WON", "WINNAAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Restart()
        End If
        Return Nothing
    End Function

    'Maakt array aan
    Private Function RandomArray(aantal As Integer, totaal As Integer) As List(Of Integer)
        index.Clear()
        For x As Integer = 0 To totaal / 2 - 1
            index.Add(x)
            tags.Add(x)
        Next
        For i As Integer = totaal / 2 To aantal
            index.Add(i - totaal / 2)
            tags.Add(i - totaal / 2)
        Next
        Return RandomizeArray(index)
    End Function

    'Random volgorde array
    Private Function RandomizeArray(items As List(Of Integer)) As List(Of Integer)
        Dim max_index As Integer = items.Count - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            Dim getal As Integer = rnd.Next(i, max_index + 1)

            Dim x As Integer = items(i)
            items(i) = items(getal)
            items(getal) = x
        Next i
        tags.Clear()
        For x As Integer = 0 To aantal
            tags.Add(items(x))
        Next
        Return items.ToList
    End Function

    'Knop klikken actie
    Private Sub knop_click(sender As Object, e As EventArgs)
        If geklikt = False Then
            Dim geklikteknop As Button = CType(sender, Button)
            knoppen.Add(geklikteknop)
            geklikteknop.Visible = False
            GoedeKaarten()
        End If
    End Sub

    'ADD RASTER
    Private Function maakRij(hoogte As Integer, aantal As Integer, array As List(Of Integer)) As Button
        Dim getal As Integer = -1
        For i As Integer = 0 To aantal
            For x As Integer = 0 To aantal
                Dim knop As New Button
                getal += 1
                buttons.Add(knop)
                knop.BackColor = Color.IndianRed
                Me.Controls.Add(knop)

                knop.Height = lengte
                knop.Width = lengte
                knop.Left = 10 + x * (lengte + 10)
                knop.Top = hoogte
                knop.Tag = array(getal)
                AddHandler knop.Click, AddressOf knop_click
            Next
            hoogte += 95
        Next
        Return Nothing
    End Function

    'ADD SMILEYS
    Private Function smileys(hoogte As Integer, images As ImageList, aantal As Integer, array As List(Of Integer)) As Image
        Dim getallen(31) As Integer
        Dim getal As Integer = 0
        For i As Integer = 0 To aantal
            For x As Integer = 0 To aantal
                Dim picture As New PictureBox
                picture.Image = images.Images(array(getal))
                Me.Controls.Add(picture)
                picture.Left = 10 + x * (lengte + 10)
                picture.Height = 105
                picture.Width = 105
                picture.Top = hoogte
                getal += 1
            Next
            hoogte += 95
        Next
        Return Nothing
    End Function

End Class

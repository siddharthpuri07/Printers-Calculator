Imports System.IO
Public Class Form1


#Region "Variables"
    'To keep track of what standard was selected for the print
    Dim small = False
    Dim med = False
    Dim large = False

    'Holds the base cost of standard print
    Dim smallbase = 30
    Dim medbase = 50
    Dim largebase = 110

    'To keep track of total cost
    Dim total As Integer
    Dim newtotal As Double

#End Region

#Region "Add button to add user"
    Private Sub addlb_Click(sender As Object, e As EventArgs) Handles addlb.Click
        'When "add" button is clicked it display the current customer.
        displayFirst.Text = firstName.Text
        displayLast.Text = lastName.Text
        displayEmail.Text = email.Text
    End Sub
#End Region

#Region "Listview to add Printers"
    Private Sub listview1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listview1.MouseDoubleClick
        'Holds the selected index values
        Dim name As String = listview1.SelectedItems(0).Text
        Dim cost As String = listview1.SelectedItems(0).SubItems(1).Text
        Dim id As String = listview1.SelectedItems(0).SubItems(2).Text

        'Adds the selected index to the quote view
        Dim items = quoteListview.Items.Add(name)
        With items
            .SubItems.Add(cost)
            .SubItems.Add(id)
        End With

        'for the printers
        If listview1.SelectedItems(0).SubItems(2).Text = "#001" Then
            total += 799
        ElseIf listview1.SelectedItems(0).SubItems(2).Text = "#002" Then
            total += 3999

        End If
        totalCost.Text = total

    End Sub
#End Region

#Region "First ListView"
    Private Sub partsListView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles partsListView.MouseDoubleClick
        partsListView.Visible = False
        listview2.Visible = True
        ' This finds out which standard print was selected and using a boolean 
        ' I can use it for other listview to determine which standard print it is
        If partsListView.SelectedItems.Item(0).SubItems(2).Text = "#003" Then
            small = True

        End If
        If partsListView.SelectedItems.Item(0).SubItems(2).Text = "#004" Then
            med = True

        End If

        If partsListView.SelectedItems.Item(0).SubItems(2).Text = "#005" Then
            large = True

        End If
    End Sub
#End Region

#Region "Second Listview"
    ' Handles the second listview
    Private Sub listview2_DoubleClick(sender As Object, e As EventArgs) Handles listview2.DoubleClick
        'Small
        If listview2.SelectedItems.Item(0).SubItems(2).Text = "#006" And small = True Then
            listview2.Visible = False
            listview3.Visible = True
            newtotal += 110 / 100 * smallbase + smallbase


        ElseIf listview2.SelectedItems.Item(0).SubItems(2).Text = "#007" And small = True Then
            small = False
            newtotal += 210 / 100 * smallbase + smallbase
            addItems("Basic small print + High quality SLA print", smallbase)
            restart()
        End If

        'Medium
        If listview2.SelectedItems.Item(0).SubItems(2).Text = "#006" And med = True Then
            listview2.Visible = False
            listview3.Visible = True
            newtotal += 110 / 100 * medbase + medbase


        ElseIf listview2.SelectedItems.Item(0).SubItems(2).Text = "#007" And med = True Then
            med = False
            newtotal += 210 / 100 * medbase + medbase

            addItems("Basic medium print + High quality SLA print", medbase)
            restart()
        End If

        'Large
        If listview2.SelectedItems.Item(0).SubItems(2).Text = "#006" And large = True Then
            listview2.Visible = False
            listview3.Visible = True
            largebase += (110 * 110) / 100

        ElseIf listview2.SelectedItems.Item(0).SubItems(2).Text = "#007" And large = True Then
            large = False
            totalCost.Text = 7
            largebase += (110 * 210) / 100
            addItems("Basic large print + High quality SLA print", largebase)
            restart()
        End If
    End Sub
#End Region

#Region "Request fees"
    Private Sub requestCb_CheckedChanged(sender As Object, e As EventArgs) Handles requestCb.CheckedChanged
        If requestCb.Checked = True Then
            Dim items = quoteListview.Items.Add("Request Prioritised Fee")
            With items
                .SubItems.Add("$20")
            End With
            total += 20
            totalCost.Text = total.ToString
        Else
            For Each listItem As ListViewItem In quoteListview.Items
                If listItem.SubItems.Item(1).Text = "$20" Then
                    listItem.Remove()
                    total -= 20
                    totalCost.Text = total.ToString
                End If
            Next
        End If
    End Sub
#End Region

#Region "Restart to defaul listview"
    Private Sub restart()
        partsListView.Visible = True
        listview2.Visible = False
        listview3.Visible = False


    End Sub
#End Region

#Region "Third Listview"
    Private Sub listview3_DoubleClick(sender As Object, e As EventArgs) Handles listview3.DoubleClick
        'Small
        If listview3.SelectedItems.Item(0).SubItems(2).Text = "#008" And small = True Then
            newtotal += 20 / 100 * smallbase

            'smallbase += (20 / 100) * smallbase
            addItems("Basic small print + High quality FDM print + FDM print using ABS", newtotal)

        ElseIf listview3.SelectedItems.Item(0).SubItems(2).Text = "#009" And small = True Then
            newtotal += 30 / 100 * smallbase
            addItems("Basic small print + High quality FDM print + FDM print using ASA", newtotal)
        End If

        'Medium
        If listview3.SelectedItems.Item(0).SubItems(2).Text = "#008" And med = True Then
            newtotal += 20 / 100 * medbase

            addItems("Basic medium  print + High quality FDM print + FDM print using ASA", newtotal)

        ElseIf listview3.SelectedItems.Item(0).SubItems(2).Text = "#009" And med = True Then
            newtotal += 30 / 100 * medbase

            addItems("Basic small print + High quality FDM print + FDM print using ASA", newtotal)
        End If

        'Large
        If listview3.SelectedItems.Item(0).SubItems(2).Text = "#008" And large = True Then
            newtotal += 20 / 100 * largebase

            addItems("Basic large print + High quality FDM print + FDM print using ASA", newtotal)

        ElseIf listview3.SelectedItems.Item(0).SubItems(2).Text = "#009" And large = True Then
            newtotal += 30 / 100 * largebase

            addItems("Basic large print + High quality FDM print + FDM print using ASA", newtotal)
        End If
        restart()
        total = total + newtotal
        totalCost.Text = total.ToString
        newtotal = 0
        small = False
        med = False
        large = False

    End Sub
#End Region

#Region "add item to quotelistview"
    Private Sub addItems(name As String, cost As String)
        Dim items = quoteListview.Items.Add(name)
        With items
            .SubItems.Add(cost)
        End With
    End Sub



#End Region

    Private Sub removeQuote_Click(sender As Object, e As EventArgs) Handles removeQuote.Click
        quoteListview.Items.Clear()
        total = 0
        totalCost.Text = ""
        restart()


    End Sub

    Private Sub contractBtn_CheckedChanged(sender As Object, e As EventArgs) Handles contractBtn.CheckedChanged
        If contractBtn.Checked = True Then
            Dim items = quoteListview.Items.Add("Contract")
            items.SubItems.Add("-15%")
            Dim finalTotal
            finalTotal = total - total * 0.15
            totalCost.Text = finalTotal.ToString
        ElseIf contractBtn.Checked = False Then
            contract()
        End If


    End Sub

    Private Sub contract()

        For Each listItem As ListViewItem In quoteListview.Items
            If listItem.SubItems.Item(0).Text = "Contract" Then
                listItem.Remove()
                totalCost.Text = total.ToString
                contractBtn.CheckState = CheckState.Unchecked
            End If
        Next
    End Sub


    Private Sub removeItem_Click(sender As Object, e As EventArgs) Handles removeItem.Click
        Dim cost As Double
        'Dim Contract = quoteListview.SelectedItems.Item(0).Text
        If quoteListview.SelectedItems.Item(0).Text = "Contract" Then
            contract()
        Else
            cost = quoteListview.SelectedItems(0).SubItems(1).Text
            total = total - cost
            quoteListview.SelectedItems(0).Remove()
            totalCost.Text = total

        End If

    End Sub

    'Private Sub Save()
    '    Using csv As New System.IO.StreamWriter("C:\Users\Damber\Desktop")
    '        For Each oItem As ListViewItem In quoteListview.Items
    '            csv.WriteLine(String.Format("""{0}"",""{1}"",{2},{3}", oItem.Text, oItem.SubItems(0).Text, oItem.SubItems(1).Text, oItem.SubItems(2).Text))
    '        Next
    '    End Using
    'End Sub

    'Private Sub quoteBtn_Click(sender As Object, e As EventArgs) Handles quoteBtn.Click
    '    Save()
    'End Sub


End Class

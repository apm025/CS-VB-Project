Public Class Form1
    Dim iOrderNumber As Integer = 1000


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With clbFlavors.Items
            .Add("Regular", False)
            .Add("Vanilla", False)
            .Add("Mocha", False)
            .Add("Hazelnut", False)
            .Add("Funny", False)
            .Add("Pepermint", False)
        End With

        With clbStyles.Items
            .Add("Regular Coffee", False)
            .Add("Cappuccino", False)
            .Add("Espresso", False)
            .Add("Frappuccino", False)
            .Add("Iced Coffee", False)
        End With
        txtTotalFlavors.Text = clbFlavors.Items.Count
        txtTotalStyles.Text = clbStyles.Items.Count
    End Sub

    Private Sub btnSubmitOrder_Click(sender As Object, e As EventArgs) Handles btnSubmitOrder.Click
        'varables for order
        Dim sFlavor As String
        Dim sStyle As String
        Dim sSize As String = cbSize.SelectedItem
        Dim i As Integer

        ' *** Flavor:  Get Checked Item Value/Text ***
        If (clbFlavors.CheckedItems.Count > 0) Then

            For i = 0 To clbFlavors.SelectedItems.Count

                sFlavor = clbFlavors.CheckedItems.Item(i)
                i = i + 1

            Next
            ' MsgBox("Flavor:  " & sFlavor)
        End If

        ' *** Style:  Get Checked Item Value/Text ***
        If (clbStyles.CheckedItems.Count > 0) Then

            For i = 0 To clbStyles.SelectedItems.Count

                sStyle = clbStyles.CheckedItems.Item(i)
                i = i + 1

            Next
            'MsgBox("Style:  " & sStyle)
        End If


        'Check selectoins and add to confirmation if quantity is 1+
        If numQuantity.Value > 0 Then
            txtFlavor.Text = sFlavor
            txtStyle.Text = sStyle
            txtQuantity.Text = numQuantity.Value.ToString
            txtSize.Text = cbSize.SelectedItem
            'llll
            MsgBox("Flavor:  " & sFlavor & vbNewLine & "Style:  " & sStyle & vbNewLine & "Size:  " & sSize, MsgBoxStyle.Information)
        Else
            MsgBox("Quantity not selected, Please select quantity", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Flavors Selected and Checked
        clbFlavors.ClearSelected()
        Dim iFlavors As Integer 'integer for looping through Flavors collection
        For iFlavors = 0 To clbFlavors.Items.Count - 1
            clbFlavors.SetItemCheckState(iFlavors, False)
        Next

        'Clear Style Selected and Checked
        clbStyles.ClearSelected()
        Dim iStyles As Integer 'integer for looping through Styles collection
        For iStyles = 0 To clbStyles.Items.Count - 1
            clbStyles.SetItemCheckState(iStyles, False)
        Next

        'Size Reset
        cbSize.ResetText()
        'Quantity set to 0
        numQuantity.Value = 0

    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        iOrderNumber = iOrderNumber + 1
        MsgBox("Order number " & iOrderNumber & " received")

    End Sub
End Class

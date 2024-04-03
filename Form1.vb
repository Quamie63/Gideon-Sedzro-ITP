Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlgorithmComboBox.Items.AddRange({"Bubble Sort", "Insertion Sort", "Linear Search", "Binary Search"})
        RandomRadioButton.Checked = True
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim algorithm As String = AlgorithmComboBox.SelectedItem.ToString()
        Dim dataInput As String = If(RandomRadioButton.Checked, "Random", "File")
        Dim inputData As List(Of Integer) = If(dataInput = "Random", GenerateRandomData(), If(File.Exists(FilePathTextBox.Text), ReadDataFromFile(FilePathTextBox.Text), Nothing))

        If algorithm = "Linear Search" OrElse algorithm = "Binary Search" Then
            Dim itemToSearch As Integer
            If Not Integer.TryParse(ItemToSearchTextBox.Text, itemToSearch) Then
                MessageBox.Show("Please enter a valid integer to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            PerformAndDisplayAlgorithm(algorithm, inputData, itemToSearch)
        Else
            PerformAndDisplayAlgorithm(algorithm, inputData)
        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim openFileDialog As New OpenFileDialog()
        If openFileDialog.ShowDialog() = DialogResult.OK Then FilePathTextBox.Text = openFileDialog.FileName
    End Sub

    Private Function GenerateRandomData() As List(Of Integer)
        Return Enumerable.Range(1, 10).Select(Function(x) New Random().Next(0, 20)).ToList()
    End Function

    Private Function ReadDataFromFile(filePath As String) As List(Of Integer)
        Dim data As New List(Of Integer)()
        Try
            data = File.ReadLines(filePath).Select(Function(line) If(Integer.TryParse(line, Nothing), Integer.Parse(line), 0)).ToList()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return data
    End Function

    Private Sub PerformAndDisplayAlgorithm(algorithm As String, inputData As List(Of Integer), Optional itemToSearch As Integer = 0)
        Dim algorithmSteps As List(Of String) = PerformAlgorithm(algorithm, inputData, itemToSearch)
        Dim stepsForm As New Form2
        stepsForm.DisplaySteps(algorithmSteps)
        stepsForm.ShowDialog()
        MessageBox.Show(GetFinalResult(algorithmSteps), "Final Result")
    End Sub

    Private Function PerformAlgorithm(algorithm As String, inputData As List(Of Integer), Optional itemToSearch As Integer = 0) As List(Of String)
        Dim algorithmSteps As New List(Of String)
        Select Case algorithm
            Case "Bubble Sort" : algorithmSteps.AddRange(BubbleSort(inputData))
            Case "Insertion Sort" : algorithmSteps.AddRange(InsertionSort(inputData))
            Case "Linear Search" : algorithmSteps.AddRange(LinearSearch(inputData, itemToSearch))
            Case "Binary Search" : algorithmSteps.AddRange(BinarySearch(inputData, itemToSearch))
            Case Else : algorithmSteps.Add("Selected algorithm not implemented yet")
        End Select
        Return algorithmSteps
    End Function

    Private Function BubbleSort(data As List(Of Integer)) As List(Of String)
        Dim steps As New List(Of String)()
        If data.Count = 0 Then Return steps
        steps.Add($"Before: {String.Join(" ", data)}")
        For i As Integer = 0 To data.Count - 2
            For j As Integer = 0 To data.Count - i - 2
                If data(j) > data(j + 1) Then
                    Dim temp As Integer = data(j)
                    data(j) = data(j + 1)
                    data(j + 1) = temp
                End If
            Next
            steps.Add($"Step {i + 1}: {String.Join(" ", data)}")
        Next
        Return steps
    End Function

    Private Function InsertionSort(data As List(Of Integer)) As List(Of String)
        Dim steps As New List(Of String)()
        If data.Count = 0 Then Return steps
        steps.Add($"Before: {String.Join(" ", data)}")
        For i As Integer = 1 To data.Count - 1
            Dim key As Integer = data(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso data(j) > key
                data(j + 1) = data(j)
                j -= 1
            End While
            data(j + 1) = key
            steps.Add($"Step {i}: {String.Join(" ", data)}")
        Next
        Return steps
    End Function

    Private Function LinearSearch(data As List(Of Integer), itemToSearch As Integer) As List(Of String)
        Dim steps As New List(Of String) From {"Linear Search algorithm steps:", $"Data: {String.Join(" ", data)}"}
        Dim index As Integer = data.IndexOf(itemToSearch)
        If index <> -1 Then
            steps.Add($"Item {itemToSearch} found at index {index}")
        Else
            steps.Add($"Item {itemToSearch} not found")
        End If
        Return steps
    End Function

    Private Function BinarySearch(data As List(Of Integer), itemToSearch As Integer) As List(Of String)
        Dim steps As New List(Of String) From {"Binary Search algorithm steps:", $"Data: {String.Join(" ", data)}"}
        Dim low As Integer = 0, high As Integer = data.Count - 1
        While low <= high
            Dim mid As Integer = (low + high) \ 2
            Dim guess As Integer = data(mid)
            If guess = itemToSearch Then
                steps.Add($"Item {itemToSearch} found at index {mid}")
                Return steps
            End If
            If guess > itemToSearch Then high = mid - 1 Else low = mid + 1
        End While
        steps.Add($"Item {itemToSearch} not found")
        Return steps
    End Function

    Private Function GetFinalResult(algorithmSteps As List(Of String)) As String
        Return "Algorithm completed successfully"
    End Function
End Class

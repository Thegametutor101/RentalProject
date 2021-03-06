﻿Imports System.Text.RegularExpressions

Public Class IModifyPerson

    Dim mainForm As MainForm
    Dim data As DataTable

    Sub New(main As MainForm, items As DataTable)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        data = items
    End Sub

    Private Sub IModifyPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
    End Sub

    Private Function setDefaults()
        For Each it As DataRow In data.Rows
            'Inserting values into textBoxes
            ID.Text = it.Item(0)
            LastName.Text = it.Item(1)
            FirstName.Text = it.Item(2)
            Status.Text = it.Item(3)
            Department.Text = it.Item(4)
            Service.Text = it.Item(5)
            Office.Text = it.Item(6)
            Phone.Text = it.Item(7)
            Extension.Text = it.Item(8)
        Next
    End Function

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            setDefaults()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        FirstName.Text = Regex.Replace(FirstName.Text, "[\d-]", String.Empty)
        LastName.Text = Regex.Replace(LastName.Text, "[\d-]", String.Empty)
        Department.Text = Regex.Replace(Department.Text, "[\d-]", String.Empty)
        Service.Text = Regex.Replace(Service.Text, "[\d-]", String.Empty)
        FirstName.Text = Regex.Replace(FirstName.Text, "[^A-Za-z ]", String.Empty)
        LastName.Text = Regex.Replace(LastName.Text, "[^A-Za-z ]", String.Empty)
        Department.Text = Regex.Replace(Department.Text, "[^A-Za-z ]", String.Empty)
        Service.Text = Regex.Replace(Service.Text, "[^A-Za-z ]", String.Empty)
        LastName.Text = Trim(LastName.Text)
        FirstName.Text = Trim(FirstName.Text)
        Department.Text = Trim(Department.Text)
        Service.Text = Trim(Service.Text)
        Office.Text = Trim(Office.Text)
        Phone.Text = Trim(Phone.Text)
        Extension.Text = Trim(Extension.Text)
        If String.IsNullOrEmpty(LastName.Text) Or String.IsNullOrEmpty(FirstName.Text) Or
           String.IsNullOrEmpty(Status.Text) Or String.IsNullOrEmpty(Department.Text) Or
           String.IsNullOrEmpty(Service.Text) Or
           String.IsNullOrEmpty(Phone.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs avant de soumettre.")
        ElseIf Not Status.Text = "Étudiant" And Office.Text.Length < 6 Then
            MessageBox.Show("Veuillez entrer un Bureau valide.")
        ElseIf MessageBox.Show($"Voulez-vous vraiment sauvegarder ces modifications?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            ModelPerson.getInstance().modifyPerson(ID.Text, LastName.Text, FirstName.Text, Status.Text, Department.Text, Service.Text, Office.Text, Phone.Text, Extension.Text)
            Me.SendToBack()
        End If
    End Sub

    Private Sub Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status.SelectedIndexChanged
        If Status.SelectedIndex = 0 Then
            Department.Enabled = False
            Service.Enabled = False
            Office.Enabled = False
        Else
            Department.Enabled = True
            Service.Enabled = True
            Office.Enabled = True
        End If
    End Sub
End Class

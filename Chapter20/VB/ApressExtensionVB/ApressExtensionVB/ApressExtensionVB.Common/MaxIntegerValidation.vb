﻿'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2015 by Tim Leung, published by Apress, ISBN 978-1-4842-0767-3".

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports System.Linq
Imports Microsoft.LightSwitch
Imports Microsoft.LightSwitch.Model
Imports Microsoft.LightSwitch.Runtime.Rules


Public Class MaxIntegerValidation
    Implements IAttachedPropertyValidation

    Public Sub New(attributes As IEnumerable(Of IAttribute))
        Me.attributes = attributes
    End Sub

    Private attributes As IEnumerable(Of IAttribute)

    Public Sub Validate(value As Object,
       results As IPropertyValidationResultsBuilder) Implements Microsoft.LightSwitch.Runtime.Rules.IAttachedPropertyValidation.Validate
        If value IsNot Nothing Then

            ' Ensure the value type is integer.
            If GetType(Integer) IsNot value.GetType() Then
                Throw New InvalidOperationException("Unsupported data type.")
            End If

            Dim intValue As Integer = DirectCast(value, Integer)

            Dim validationAttribute As IAttribute =
            Me.attributes.FirstOrDefault()
            If validationAttribute IsNot Nothing AndAlso
                validationAttribute.Class IsNot Nothing AndAlso
                validationAttribute.Class.Id =
                   "ApressExtensionVB:@MaxIntegerValidationId" Then

                Dim intMaxDays =
                   DirectCast(validationAttribute("MaxDays"), Integer)

                'There are 1440 minutes in a day
                If intMaxDays > 0 AndAlso intValue > (intMaxDays * 1440) Then
                    results.AddPropertyResult(
                        "Max value must be less than " &
                          intMaxDays.ToString & " days", ValidationSeverity.Error)
                End If
            End If
        End If
    End Sub
End Class


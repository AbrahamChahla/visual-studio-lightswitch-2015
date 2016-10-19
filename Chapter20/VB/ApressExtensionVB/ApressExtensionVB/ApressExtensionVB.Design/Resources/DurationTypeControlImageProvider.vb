'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2015 by Tim Leung, published by Apress, ISBN 978-1-4842-0767-3".

Imports System
Imports System.ComponentModel.Composition
Imports System.Globalization
Imports System.Windows.Media.Imaging

Imports Microsoft.LightSwitch.BaseServices.ResourceService

Namespace Resources

    <Export(GetType(IResourceProvider))>
    <ResourceProvider("ApressExtensionVB.DurationTypeControl")>
    Friend Class DurationTypeControlImageProvider
        Implements IResourceProvider

#Region "IResourceProvider Members"

        Public Function GetResource(ByVal resourceId As String, ByVal cultureInfo As CultureInfo) As Object Implements IResourceProvider.GetResource
            Return New BitmapImage(New Uri("/ApressExtensionVB.Design;component/Resources/ControlImages/DurationTypeControl.png", UriKind.Relative))
        End Function

#End Region

    End Class

End Namespace
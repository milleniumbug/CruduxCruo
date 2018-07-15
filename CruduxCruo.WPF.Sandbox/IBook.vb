Imports System.ComponentModel
Imports CruduxCruo.Agnostic
Imports JetBrains.Annotations
Imports [Optional]

Public MustInherit Class Book
    Inherits DataModel(Of Book)

    <Description("Book title")>
    Public MustOverride Property Title As String

    <Description("Book description")>
    Public MustOverride Property Description As [Option](Of String)

    <Description("Book description, part 2")>
    <CanBeNull>
    Public MustOverride Property Description2 As String

    <Description("Book's release date")>
    Public MustOverride Property ReleaseDate As DateTime?


End Class

Public Interface IAuthor
    Inherits IDataModel(Of IAuthor)

    Property FirstName As String

    Property LastName As String

    Property 
End Interface
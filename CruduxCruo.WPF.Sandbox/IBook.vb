Imports System.ComponentModel
Imports CruduxCruo.Agnostic
Imports JetBrains.Annotations
Imports [Optional]

Public MustInherit Class Book
    Inherits DataModel(Of Book)

    <Description("Book title")>
    <UserFauxKey>
    Public MustOverride Property Title As String

    <Description("Book description")>
    Public MustOverride Property Description As [Option](Of String)

    <Description("Book description, part 2")>
    <CanBeNull>
    Public MustOverride Property Description2 As String

    <Description("Book's release date")>
    Public MustOverride Property ReleaseDate As DateTime?


End Class

Public MustInherit Class IAuthor
    Inherits DataModel(Of IAuthor)

    <Description("First name")>
    <UserFauxKey>
    Public MustOverride Property FirstName As String

    <Description("Last name")>
    <UserFauxKey>
    Public MustOverride Property LastName As String

    ' only for demonstration purposes, please suggest a better example
    <Description("Age")>
    Public MustOverride Property Age As Integer
End Class
' <auto-generated />
Imports System.CodeDom.Compiler
Imports System.Data.Entity.Migrations
Imports System.Data.Entity.Migrations.Infrastructure
Imports System.Resources

Namespace Migrations
    <GeneratedCode("EntityFramework.Migrations", "6.0.0-20911")>
    Public NotInheritable Partial Class addPriceModel
        Implements IMigrationMetadata
    
        Private ReadOnly Resources As New ResourceManager(GetType(addPriceModel))
        
        Private ReadOnly Property IMigrationMetadata_Id() As String Implements IMigrationMetadata.Id
            Get
                Return "201808311312041_addPriceModel"
            End Get
        End Property
        
        Private ReadOnly Property IMigrationMetadata_Source() As String Implements IMigrationMetadata.Source
            Get
                Return Nothing
            End Get
        End Property
        
        Private ReadOnly Property IMigrationMetadata_Target() As String Implements IMigrationMetadata.Target
            Get
                Return Resources.GetString("Target")
            End Get
        End Property
    End Class
End Namespace

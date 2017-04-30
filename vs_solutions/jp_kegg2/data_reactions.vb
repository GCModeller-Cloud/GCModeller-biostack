REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @4/30/2017 10:46:32 AM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `data_reactions`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `data_reactions` (
'''   `uid` int(11) NOT NULL,
'''   `KEGG` varchar(45) DEFAULT NULL,
'''   `name` varchar(45) DEFAULT NULL,
'''   `definition` varchar(45) DEFAULT NULL,
'''   `comment` varchar(45) DEFAULT NULL,
'''   PRIMARY KEY (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("data_reactions", Database:="jp_kegg2", SchemaSQL:="
CREATE TABLE `data_reactions` (
  `uid` int(11) NOT NULL,
  `KEGG` varchar(45) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `definition` varchar(45) DEFAULT NULL,
  `comment` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class data_reactions: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uid"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid")> Public Property uid As Long
    <DatabaseField("KEGG"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="KEGG")> Public Property KEGG As String
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
    <DatabaseField("definition"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="definition")> Public Property definition As String
    <DatabaseField("comment"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="comment")> Public Property comment As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `data_reactions` (`uid`, `KEGG`, `name`, `definition`, `comment`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `data_reactions` (`uid`, `KEGG`, `name`, `definition`, `comment`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `data_reactions` WHERE `uid` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `data_reactions` SET `uid`='{0}', `KEGG`='{1}', `name`='{2}', `definition`='{3}', `comment`='{4}' WHERE `uid` = '{5}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `data_reactions` WHERE `uid` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, uid)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `data_reactions` (`uid`, `KEGG`, `name`, `definition`, `comment`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, uid, KEGG, name, definition, comment)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{uid}', '{KEGG}', '{name}', '{definition}', '{comment}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `data_reactions` (`uid`, `KEGG`, `name`, `definition`, `comment`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, uid, KEGG, name, definition, comment)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `data_reactions` SET `uid`='{0}', `KEGG`='{1}', `name`='{2}', `definition`='{3}', `comment`='{4}' WHERE `uid` = '{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, KEGG, name, definition, comment, uid)
    End Function
#End Region
Public Function Clone() As data_reactions
                  Return DirectCast(MyClass.MemberwiseClone, data_reactions)
              End Function
End Class


End Namespace

REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/3/2017 9:51:53 AM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 代谢途径的参考文献
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `xref_pathway_references`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `xref_pathway_references` (
'''   `pathway` int(11) NOT NULL,
'''   `reference` int(11) NOT NULL,
'''   `title` varchar(45) DEFAULT NULL COMMENT '文献的标题',
'''   PRIMARY KEY (`pathway`,`reference`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='代谢途径的参考文献';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping events for database 'jp_kegg2'
''' --
''' 
''' --
''' -- Dumping routines for database 'jp_kegg2'
''' --
''' /*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
''' 
''' /*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
''' /*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
''' /*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
''' /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
''' /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
''' /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
''' /*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
''' 
''' -- Dump completed on 2017-06-03  9:51:08
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("xref_pathway_references", Database:="jp_kegg2", SchemaSQL:="
CREATE TABLE `xref_pathway_references` (
  `pathway` int(11) NOT NULL,
  `reference` int(11) NOT NULL,
  `title` varchar(45) DEFAULT NULL COMMENT '文献的标题',
  PRIMARY KEY (`pathway`,`reference`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='代谢途径的参考文献';")>
Public Class xref_pathway_references: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("pathway"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="pathway")> Public Property pathway As Long
    <DatabaseField("reference"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="reference")> Public Property reference As Long
''' <summary>
''' 文献的标题
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("title"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="title")> Public Property title As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `xref_pathway_references` (`pathway`, `reference`, `title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `xref_pathway_references` (`pathway`, `reference`, `title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `xref_pathway_references` WHERE `pathway`='{0}' and `reference`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `xref_pathway_references` SET `pathway`='{0}', `reference`='{1}', `title`='{2}' WHERE `pathway`='{3}' and `reference`='{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `xref_pathway_references` WHERE `pathway`='{0}' and `reference`='{1}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, pathway, reference)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `xref_pathway_references` (`pathway`, `reference`, `title`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, pathway, reference, title)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{pathway}', '{reference}', '{title}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `xref_pathway_references` (`pathway`, `reference`, `title`) VALUES ('{0}', '{1}', '{2}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, pathway, reference, title)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `xref_pathway_references` SET `pathway`='{0}', `reference`='{1}', `title`='{2}' WHERE `pathway`='{3}' and `reference`='{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, pathway, reference, title, pathway, reference)
    End Function
#End Region
Public Function Clone() As xref_pathway_references
                  Return DirectCast(MyClass.MemberwiseClone, xref_pathway_references)
              End Function
End Class


End Namespace

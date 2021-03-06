REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/3/2017 9:51:53 AM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' KEGG的基因同源分类
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `class_ko00001_orthology`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `class_ko00001_orthology` (
'''   `Orthology` int(11) NOT NULL COMMENT '``data_orthology``基因同源数据表之中的唯一数字编号',
'''   `KEGG` varchar(45) DEFAULT NULL COMMENT '当前的这个基因同源的KO编号',
'''   `name` varchar(45) DEFAULT NULL COMMENT '基因名',
'''   `function` varchar(45) DEFAULT NULL COMMENT '功能描述',
'''   `level_A` varchar(45) DEFAULT NULL COMMENT '代谢途径大分类',
'''   `level_B` varchar(45) DEFAULT NULL COMMENT '代谢途径小分类',
'''   `level_C` varchar(45) DEFAULT NULL COMMENT 'KEGG pathway.当前的这个参考基因同源所处的代谢途径',
'''   PRIMARY KEY (`Orthology`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='KEGG的基因同源分类';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("class_ko00001_orthology", Database:="jp_kegg2", SchemaSQL:="
CREATE TABLE `class_ko00001_orthology` (
  `Orthology` int(11) NOT NULL COMMENT '``data_orthology``基因同源数据表之中的唯一数字编号',
  `KEGG` varchar(45) DEFAULT NULL COMMENT '当前的这个基因同源的KO编号',
  `name` varchar(45) DEFAULT NULL COMMENT '基因名',
  `function` varchar(45) DEFAULT NULL COMMENT '功能描述',
  `level_A` varchar(45) DEFAULT NULL COMMENT '代谢途径大分类',
  `level_B` varchar(45) DEFAULT NULL COMMENT '代谢途径小分类',
  `level_C` varchar(45) DEFAULT NULL COMMENT 'KEGG pathway.当前的这个参考基因同源所处的代谢途径',
  PRIMARY KEY (`Orthology`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='KEGG的基因同源分类';")>
Public Class class_ko00001_orthology: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' ``data_orthology``基因同源数据表之中的唯一数字编号
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("Orthology"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="Orthology")> Public Property Orthology As Long
''' <summary>
''' 当前的这个基因同源的KO编号
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("KEGG"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="KEGG")> Public Property KEGG As String
''' <summary>
''' 基因名
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
''' <summary>
''' 功能描述
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("function"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="function")> Public Property [function] As String
''' <summary>
''' 代谢途径大分类
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("level_A"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level_A")> Public Property level_A As String
''' <summary>
''' 代谢途径小分类
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("level_B"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level_B")> Public Property level_B As String
''' <summary>
''' KEGG pathway.当前的这个参考基因同源所处的代谢途径
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("level_C"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="level_C")> Public Property level_C As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `class_ko00001_orthology` (`Orthology`, `KEGG`, `name`, `function`, `level_A`, `level_B`, `level_C`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `class_ko00001_orthology` (`Orthology`, `KEGG`, `name`, `function`, `level_A`, `level_B`, `level_C`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `class_ko00001_orthology` WHERE `Orthology` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `class_ko00001_orthology` SET `Orthology`='{0}', `KEGG`='{1}', `name`='{2}', `function`='{3}', `level_A`='{4}', `level_B`='{5}', `level_C`='{6}' WHERE `Orthology` = '{7}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `class_ko00001_orthology` WHERE `Orthology` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, Orthology)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `class_ko00001_orthology` (`Orthology`, `KEGG`, `name`, `function`, `level_A`, `level_B`, `level_C`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, Orthology, KEGG, name, [function], level_A, level_B, level_C)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{Orthology}', '{KEGG}', '{name}', '{[function]}', '{level_A}', '{level_B}', '{level_C}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `class_ko00001_orthology` (`Orthology`, `KEGG`, `name`, `function`, `level_A`, `level_B`, `level_C`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, Orthology, KEGG, name, [function], level_A, level_B, level_C)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `class_ko00001_orthology` SET `Orthology`='{0}', `KEGG`='{1}', `name`='{2}', `function`='{3}', `level_A`='{4}', `level_B`='{5}', `level_C`='{6}' WHERE `Orthology` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, Orthology, KEGG, name, [function], level_A, level_B, level_C, Orthology)
    End Function
#End Region
Public Function Clone() As class_ko00001_orthology
                  Return DirectCast(MyClass.MemberwiseClone, class_ko00001_orthology)
              End Function
End Class


End Namespace

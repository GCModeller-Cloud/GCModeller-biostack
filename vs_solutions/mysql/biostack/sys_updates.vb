REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/8/6 15:35:35


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports System.Xml.Serialization

Namespace mysql

''' <summary>
''' ```SQL
''' 网站更新记录
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `sys_updates`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `sys_updates` (
'''   `uid` int(11) NOT NULL AUTO_INCREMENT,
'''   `date` datetime NOT NULL,
'''   `title` varchar(45) NOT NULL,
'''   `details` mediumtext NOT NULL,
'''   `app` int(11) NOT NULL DEFAULT '-1' COMMENT '如果这个字段不为-1，则表示更新的内容为某一个app的内容更新',
'''   PRIMARY KEY (`uid`),
'''   UNIQUE KEY `uid_UNIQUE` (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='网站更新记录';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("sys_updates", Database:="smrucc-cloud", SchemaSQL:="
CREATE TABLE `sys_updates` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `title` varchar(45) NOT NULL,
  `details` mediumtext NOT NULL,
  `app` int(11) NOT NULL DEFAULT '-1' COMMENT '如果这个字段不为-1，则表示更新的内容为某一个app的内容更新',
  PRIMARY KEY (`uid`),
  UNIQUE KEY `uid_UNIQUE` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='网站更新记录';")>
Public Class sys_updates: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uid"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid"), XmlAttribute> Public Property uid As Long
    <DatabaseField("date"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="date")> Public Property [date] As Date
    <DatabaseField("title"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="title")> Public Property title As String
    <DatabaseField("details"), NotNull, DataType(MySqlDbType.Text), Column(Name:="details")> Public Property details As String
''' <summary>
''' 如果这个字段不为-1，则表示更新的内容为某一个app的内容更新
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("app"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app")> Public Property app As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `sys_updates` (`date`, `title`, `details`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `sys_updates` (`date`, `title`, `details`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `sys_updates` WHERE `uid` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `sys_updates` SET `uid`='{0}', `date`='{1}', `title`='{2}', `details`='{3}', `app`='{4}' WHERE `uid` = '{5}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `sys_updates` WHERE `uid` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, uid)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `sys_updates` (`date`, `title`, `details`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, DataType.ToMySqlDateTimeString([date]), title, details, app)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{[date]}', '{title}', '{details}', '{app}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `sys_updates` (`date`, `title`, `details`, `app`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, DataType.ToMySqlDateTimeString([date]), title, details, app)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `sys_updates` SET `uid`='{0}', `date`='{1}', `title`='{2}', `details`='{3}', `app`='{4}' WHERE `uid` = '{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, DataType.ToMySqlDateTimeString([date]), title, details, app, uid)
    End Function
#End Region
Public Function Clone() As sys_updates
                  Return DirectCast(MyClass.MemberwiseClone, sys_updates)
              End Function
End Class


End Namespace

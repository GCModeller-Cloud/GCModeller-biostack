REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @5/27/2017 9:26:50 AM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' Task executing errors log
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `task_errors`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `task_errors` (
'''   `uid` int(11) NOT NULL,
'''   `app` int(11) NOT NULL COMMENT 'The task app name',
'''   `exception` longtext,
'''   `solved` int(11) DEFAULT NULL COMMENT '这个bug是否已经解决了？ 默认是0未解决，1为已经解决了',
'''   PRIMARY KEY (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Task executing errors log';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("task_errors", Database:="smrucc-cloud", SchemaSQL:="
CREATE TABLE `task_errors` (
  `uid` int(11) NOT NULL,
  `app` int(11) NOT NULL COMMENT 'The task app name',
  `exception` longtext,
  `solved` int(11) DEFAULT NULL COMMENT '这个bug是否已经解决了？ 默认是0未解决，1为已经解决了',
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Task executing errors log';")>
Public Class task_errors: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uid"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid")> Public Property uid As Long
''' <summary>
''' The task app name
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("app"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app")> Public Property app As Long
    <DatabaseField("exception"), DataType(MySqlDbType.Text), Column(Name:="exception")> Public Property exception As String
''' <summary>
''' 这个bug是否已经解决了？ 默认是0未解决，1为已经解决了
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("solved"), DataType(MySqlDbType.Int64, "11"), Column(Name:="solved")> Public Property solved As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `task_errors` (`uid`, `app`, `exception`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `task_errors` (`uid`, `app`, `exception`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `task_errors` WHERE `uid` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `task_errors` SET `uid`='{0}', `app`='{1}', `exception`='{2}', `solved`='{3}' WHERE `uid` = '{4}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `task_errors` WHERE `uid` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, uid)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `task_errors` (`uid`, `app`, `exception`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, uid, app, exception, solved)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{uid}', '{app}', '{exception}', '{solved}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `task_errors` (`uid`, `app`, `exception`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, uid, app, exception, solved)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `task_errors` SET `uid`='{0}', `app`='{1}', `exception`='{2}', `solved`='{3}' WHERE `uid` = '{4}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, app, exception, solved, uid)
    End Function
#End Region
Public Function Clone() As task_errors
                  Return DirectCast(MyClass.MemberwiseClone, task_errors)
              End Function
End Class


End Namespace

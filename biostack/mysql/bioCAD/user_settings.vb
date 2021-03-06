REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/18/2018 5:37:20 PM


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports MySqlScript = Oracle.LinuxCompatibility.MySQL.Scripting.Extensions

Namespace MySql.bioCAD

''' <summary>
''' ```SQL
''' 1: boolean TRUE\n0: boolean FALSE
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `user_settings`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `user_settings` (
'''   `user_id` int(11) NOT NULL,
'''   `email_notify.login` int(11) NOT NULL DEFAULT '1',
'''   `email_notify.security` int(11) NOT NULL DEFAULT '1',
'''   `email_notify.task.start` int(11) NOT NULL DEFAULT '1',
'''   `email_notify.task.success` int(11) NOT NULL DEFAULT '1',
'''   `email_notify.task.error` int(11) NOT NULL DEFAULT '1',
'''   `update_time` datetime NOT NULL,
'''   PRIMARY KEY (`user_id`),
'''   UNIQUE KEY `user_id_UNIQUE` (`user_id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='1: boolean TRUE\n0: boolean FALSE';
''' /*!40101 SET character_set_client = @saved_cs_client */;
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
''' -- Dump completed on 2018-06-18 17:37:16
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("user_settings", Database:="biocad", SchemaSQL:="
CREATE TABLE `user_settings` (
  `user_id` int(11) NOT NULL,
  `email_notify.login` int(11) NOT NULL DEFAULT '1',
  `email_notify.security` int(11) NOT NULL DEFAULT '1',
  `email_notify.task.start` int(11) NOT NULL DEFAULT '1',
  `email_notify.task.success` int(11) NOT NULL DEFAULT '1',
  `email_notify.task.error` int(11) NOT NULL DEFAULT '1',
  `update_time` datetime NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `user_id_UNIQUE` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='1: boolean TRUE\n0: boolean FALSE';")>
Public Class user_settings: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("user_id"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id"), XmlAttribute> Public Property user_id As Long
    <DatabaseField("email_notify.login"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.login")> Public Property email_notify_login As Long
    <DatabaseField("email_notify.security"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.security")> Public Property email_notify_security As Long
    <DatabaseField("email_notify.task.start"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.task.start")> Public Property email_notify_task_start As Long
    <DatabaseField("email_notify.task.success"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.task.success")> Public Property email_notify_task_success As Long
    <DatabaseField("email_notify.task.error"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="email_notify.task.error")> Public Property email_notify_task_error As Long
    <DatabaseField("update_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="update_time")> Public Property update_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `user_settings` WHERE `user_id` = '{0}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `user_settings` SET `user_id`='{0}', `email_notify.login`='{1}', `email_notify.security`='{2}', `email_notify.task.start`='{3}', `email_notify.task.success`='{4}', `email_notify.task.error`='{5}', `update_time`='{6}' WHERE `user_id` = '{7}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `user_settings` WHERE `user_id` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, user_id)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
        Else
        Return String.Format(INSERT_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{user_id}', '{email_notify_login}', '{email_notify_security}', '{email_notify_task_start}', '{email_notify_task_success}', '{email_notify_task_error}', '{update_time}')"
        Else
            Return $"('{user_id}', '{email_notify_login}', '{email_notify_security}', '{email_notify_task_start}', '{email_notify_task_success}', '{email_notify_task_error}', '{update_time}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `user_settings` (`user_id`, `email_notify.login`, `email_notify.security`, `email_notify.task.start`, `email_notify.task.success`, `email_notify.task.error`, `update_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
        Else
        Return String.Format(REPLACE_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time))
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `user_settings` SET `user_id`='{0}', `email_notify.login`='{1}', `email_notify.security`='{2}', `email_notify.task.start`='{3}', `email_notify.task.success`='{4}', `email_notify.task.error`='{5}', `update_time`='{6}' WHERE `user_id` = '{7}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, user_id, email_notify_login, email_notify_security, email_notify_task_start, email_notify_task_success, email_notify_task_error, MySqlScript.ToMySqlDateTimeString(update_time), user_id)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As user_settings
                         Return DirectCast(MyClass.MemberwiseClone, user_settings)
                     End Function
End Class


End Namespace

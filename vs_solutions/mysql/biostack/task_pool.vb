REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @5/14/2017 1:13:26 AM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `task_pool`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `task_pool` (
'''   `uid` int(11) NOT NULL COMMENT '由md5计算出来的hash值',
'''   `md5` varchar(32) NOT NULL COMMENT '用户查询任务状态结果所使用的唯一标识符字符串',
'''   `workspace` mediumtext COMMENT '保存数据文件的工作区文件夹',
'''   `time_create` datetime DEFAULT NULL COMMENT '这个用户任务所创建的时间',
'''   `time_complete` datetime DEFAULT NULL COMMENT '这个用户任务所完成的时间',
'''   `result_url` mediumtext COMMENT '结果页面的url',
'''   `email` varchar(45) DEFAULT NULL COMMENT '任务完成之后通知的目标对象的e-mail,如果不存在，则不发送email',
'''   `title` varchar(128) DEFAULT NULL COMMENT '任务的标题（可选）',
'''   `description` mediumtext COMMENT '任务的描述(可选)',
'''   `status` int(11) DEFAULT NULL COMMENT '任务的结果状态\n\n-100 任务执行失败\n1 任务成功执行完毕',
'''   PRIMARY KEY (`uid`),
'''   UNIQUE KEY `md5_UNIQUE` (`md5`),
'''   UNIQUE KEY `uid_UNIQUE` (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("task_pool", Database:="smrucc_webcloud", SchemaSQL:="
CREATE TABLE `task_pool` (
  `uid` int(11) NOT NULL COMMENT '由md5计算出来的hash值',
  `md5` varchar(32) NOT NULL COMMENT '用户查询任务状态结果所使用的唯一标识符字符串',
  `workspace` mediumtext COMMENT '保存数据文件的工作区文件夹',
  `time_create` datetime DEFAULT NULL COMMENT '这个用户任务所创建的时间',
  `time_complete` datetime DEFAULT NULL COMMENT '这个用户任务所完成的时间',
  `result_url` mediumtext COMMENT '结果页面的url',
  `email` varchar(45) DEFAULT NULL COMMENT '任务完成之后通知的目标对象的e-mail,如果不存在，则不发送email',
  `title` varchar(128) DEFAULT NULL COMMENT '任务的标题（可选）',
  `description` mediumtext COMMENT '任务的描述(可选)',
  `status` int(11) DEFAULT NULL COMMENT '任务的结果状态\n\n-100 任务执行失败\n1 任务成功执行完毕',
  PRIMARY KEY (`uid`),
  UNIQUE KEY `md5_UNIQUE` (`md5`),
  UNIQUE KEY `uid_UNIQUE` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;")>
Public Class task_pool: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
''' <summary>
''' 由md5计算出来的hash值
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("uid"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid")> Public Property uid As Long
''' <summary>
''' 用户查询任务状态结果所使用的唯一标识符字符串
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("md5"), NotNull, DataType(MySqlDbType.VarChar, "32"), Column(Name:="md5")> Public Property md5 As String
''' <summary>
''' 保存数据文件的工作区文件夹
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("workspace"), DataType(MySqlDbType.Text), Column(Name:="workspace")> Public Property workspace As String
''' <summary>
''' 这个用户任务所创建的时间
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("time_create"), DataType(MySqlDbType.DateTime), Column(Name:="time_create")> Public Property time_create As Date
''' <summary>
''' 这个用户任务所完成的时间
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("time_complete"), DataType(MySqlDbType.DateTime), Column(Name:="time_complete")> Public Property time_complete As Date
''' <summary>
''' 结果页面的url
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("result_url"), DataType(MySqlDbType.Text), Column(Name:="result_url")> Public Property result_url As String
''' <summary>
''' 任务完成之后通知的目标对象的e-mail,如果不存在，则不发送email
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("email"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="email")> Public Property email As String
''' <summary>
''' 任务的标题（可选）
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("title"), DataType(MySqlDbType.VarChar, "128"), Column(Name:="title")> Public Property title As String
''' <summary>
''' 任务的描述(可选)
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("description"), DataType(MySqlDbType.Text), Column(Name:="description")> Public Property description As String
''' <summary>
''' 任务的结果状态\n\n-100 任务执行失败\n1 任务成功执行完毕
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("status"), DataType(MySqlDbType.Int64, "11"), Column(Name:="status")> Public Property status As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `task_pool` (`uid`, `md5`, `workspace`, `time_create`, `time_complete`, `result_url`, `email`, `title`, `description`, `status`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `task_pool` (`uid`, `md5`, `workspace`, `time_create`, `time_complete`, `result_url`, `email`, `title`, `description`, `status`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `task_pool` WHERE `uid` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `task_pool` SET `uid`='{0}', `md5`='{1}', `workspace`='{2}', `time_create`='{3}', `time_complete`='{4}', `result_url`='{5}', `email`='{6}', `title`='{7}', `description`='{8}', `status`='{9}' WHERE `uid` = '{10}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `task_pool` WHERE `uid` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, uid)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `task_pool` (`uid`, `md5`, `workspace`, `time_create`, `time_complete`, `result_url`, `email`, `title`, `description`, `status`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, uid, md5, workspace, DataType.ToMySqlDateTimeString(time_create), DataType.ToMySqlDateTimeString(time_complete), result_url, email, title, description, status)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{uid}', '{md5}', '{workspace}', '{time_create}', '{time_complete}', '{result_url}', '{email}', '{title}', '{description}', '{status}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `task_pool` (`uid`, `md5`, `workspace`, `time_create`, `time_complete`, `result_url`, `email`, `title`, `description`, `status`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, uid, md5, workspace, DataType.ToMySqlDateTimeString(time_create), DataType.ToMySqlDateTimeString(time_complete), result_url, email, title, description, status)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `task_pool` SET `uid`='{0}', `md5`='{1}', `workspace`='{2}', `time_create`='{3}', `time_complete`='{4}', `result_url`='{5}', `email`='{6}', `title`='{7}', `description`='{8}', `status`='{9}' WHERE `uid` = '{10}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, md5, workspace, DataType.ToMySqlDateTimeString(time_create), DataType.ToMySqlDateTimeString(time_complete), result_url, email, title, description, status, uid)
    End Function
#End Region
Public Function Clone() As task_pool
                  Return DirectCast(MyClass.MemberwiseClone, task_pool)
              End Function
End Class


End Namespace

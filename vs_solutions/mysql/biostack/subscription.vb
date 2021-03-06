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
''' 向订阅了网站更新的用户发送产品的更新信息
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `subscription`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `subscription` (
'''   `uid` int(11) NOT NULL AUTO_INCREMENT,
'''   `email` varchar(128) NOT NULL,
'''   `hash` varchar(64) NOT NULL,
'''   `app` int(11) NOT NULL,
'''   `active` int(11) NOT NULL DEFAULT '0' COMMENT '1(active) OR 0(inactive)',
'''   `add_time` datetime NOT NULL,
'''   PRIMARY KEY (`email`),
'''   UNIQUE KEY `uid_UNIQUE` (`uid`),
'''   KEY `fk_subscription_app1_idx` (`app`),
'''   CONSTRAINT `fk_subscription_app1` FOREIGN KEY (`app`) REFERENCES `app` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='向订阅了网站更新的用户发送产品的更新信息';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("subscription", Database:="smrucc-cloud", SchemaSQL:="
CREATE TABLE `subscription` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(128) NOT NULL,
  `hash` varchar(64) NOT NULL,
  `app` int(11) NOT NULL,
  `active` int(11) NOT NULL DEFAULT '0' COMMENT '1(active) OR 0(inactive)',
  `add_time` datetime NOT NULL,
  PRIMARY KEY (`email`),
  UNIQUE KEY `uid_UNIQUE` (`uid`),
  KEY `fk_subscription_app1_idx` (`app`),
  CONSTRAINT `fk_subscription_app1` FOREIGN KEY (`app`) REFERENCES `app` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='向订阅了网站更新的用户发送产品的更新信息';")>
Public Class subscription: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uid"), AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid")> Public Property uid As Long
    <DatabaseField("email"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="email"), XmlAttribute> Public Property email As String
    <DatabaseField("hash"), NotNull, DataType(MySqlDbType.VarChar, "64"), Column(Name:="hash")> Public Property hash As String
    <DatabaseField("app"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app")> Public Property app As Long
''' <summary>
''' 1(active) OR 0(inactive)
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("active"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="active")> Public Property active As Long
    <DatabaseField("add_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="add_time")> Public Property add_time As Date
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `subscription` (`email`, `hash`, `app`, `active`, `add_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `subscription` (`email`, `hash`, `app`, `active`, `add_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `subscription` WHERE `email` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `subscription` SET `uid`='{0}', `email`='{1}', `hash`='{2}', `app`='{3}', `active`='{4}', `add_time`='{5}' WHERE `email` = '{6}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `subscription` WHERE `email` = '{0}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, email)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `subscription` (`email`, `hash`, `app`, `active`, `add_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, email, hash, app, active, DataType.ToMySqlDateTimeString(add_time))
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{email}', '{hash}', '{app}', '{active}', '{add_time}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `subscription` (`email`, `hash`, `app`, `active`, `add_time`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, email, hash, app, active, DataType.ToMySqlDateTimeString(add_time))
    End Function
''' <summary>
''' ```SQL
''' UPDATE `subscription` SET `uid`='{0}', `email`='{1}', `hash`='{2}', `app`='{3}', `active`='{4}', `add_time`='{5}' WHERE `email` = '{6}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, email, hash, app, active, DataType.ToMySqlDateTimeString(add_time), email)
    End Function
#End Region
Public Function Clone() As subscription
                  Return DirectCast(MyClass.MemberwiseClone, subscription)
              End Function
End Class


End Namespace

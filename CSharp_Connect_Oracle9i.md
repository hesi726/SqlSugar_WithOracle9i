
## WINDOWS
* 下载 oracle instantclient 10.2 的压缩包
* 解压到类似 D:\Oracle\instantclient_10_2 目录
    

* 设置如下环境变量
  > 不能在 dos 窗口下使用 set 去设置;
  > 不能在代码中设置

  * LD_LIBRARY_PATH=D:\Oracle\instantclient_10_2
  * NLS_LANG =SIMPLIFIED CHINESE_CHINA.ZHS16GBK
  * OCI_HOME=D:\Oracle\instantclient_10_2
  * OCI_LIB_DIR =D:\Oracle\instantclient_10_2
  * ORACLE_HOME=D:\Oracle\instantclient_10_2
  * PATH=%PATH%;D:\Oracle\instantclient_10_2

## Linux 或者 Unix
* 下载 oracle instantclient 10.2 的压缩包
* 解压到类似 /usr/share/oracle_instantclient 目录
* 在 Linux环境下：（修改  /etc/profile 文件) 增加如下环境变量设置:
  * export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/share/oracle_instantclient
  * export NLS_LANG="SIMPLIFIED CHINESE_CHINA.ZHS16GBK"
  * export OCI_HOME=/usr/share/oracle_instantclient
  * export OCI_LIB_DIR=/usr/share/oracle_instantclient
  * export ORACLE_HOME=/usr/share/oracle_instantclient

* 增加 liboci.so 的链接文件
  *（因为加载的是 liboci库而不是 libociei 库;
  > ln -s /usr/share/oracle_instantclient/libociei.so /usr/share/oracle_instantclient/liboci.so 

## 使用 FreeSql 包;
## 引入 FreeSql.Provider.Odbc 项目:

* 使用 FreeSql 去访问 Oracle数据库
```
 private static IFreeSql Fsql = new FreeSql.FreeSqlBuilder()
            .UseConnectionString(FreeSql.DataType.OdbcOracle, conn)            
            .UseAutoSyncStructure(false)
            .Build();
```


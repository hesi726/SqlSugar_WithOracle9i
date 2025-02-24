﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public partial interface IInsertable<T> where T :class,new()
    {
        InsertBuilder InsertBuilder { get; set; }
        int ExecuteCommand();
        Task<int> ExecuteCommandAsync();
        List<Type> ExecuteReturnPkList<Type>();
        Task<List<Type>> ExecuteReturnPkListAsync<Type>();
        long ExecuteReturnSnowflakeId();
        List<long> ExecuteReturnSnowflakeIdList();
        Task<long> ExecuteReturnSnowflakeIdAsync();
        Task<List<long>> ExecuteReturnSnowflakeIdListAsync();
        int ExecuteReturnIdentity();
        Task<int> ExecuteReturnIdentityAsync();
        T ExecuteReturnEntity();
        Task<T> ExecuteReturnEntityAsync();
        bool ExecuteCommandIdentityIntoEntity();
        Task<bool> ExecuteCommandIdentityIntoEntityAsync();
        long ExecuteReturnBigIdentity();
        Task<long> ExecuteReturnBigIdentityAsync();
        IInsertable<T> AS(string tableName);
        IInsertable<T> AsType(Type tableNameType);
        IInsertable<T> With(string lockString);
        IInsertable<T> InsertColumns(Expression<Func<T, object>> columns);
        IInsertable<T> InsertColumns(params string[] columns);

        IInsertable<T> IgnoreColumns(Expression<Func<T, object>> columns);
        IInsertable<T> IgnoreColumns(params string[]columns);
        IInsertable<T> IgnoreColumns(bool ignoreNullColumn, bool isOffIdentity = false);

        ISubInsertable<T> AddSubList(Expression<Func<T, object>> subForeignKey);
        ISubInsertable<T> AddSubList(Expression<Func<T, SubInsertTree>> tree);
        IParameterInsertable<T> UseParameter();
        IInsertable<T> CallEntityMethod(Expression<Action<T>> method);

        IInsertable<T> EnableDiffLogEvent(object businessData = null);
        IInsertable<T> EnableDiffLogEventIF(bool isDiffLogEvent, object businessData=null);
        IInsertable<T> RemoveDataCache();
        IInsertable<T> RemoveDataCache(string likeString);
        KeyValuePair<string, List<SugarParameter>> ToSql();
        string ToSqlString();
        SqlServerBlukCopy UseSqlServer();
        MySqlBlukCopy<T> UseMySql();
        OracleBlukCopy UseOracle();

        SplitInsertable<T> SplitTable();
        SplitInsertable<T> SplitTable(SplitType splitType);
        void AddQueue();

    }
}

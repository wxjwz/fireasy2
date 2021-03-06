﻿// -----------------------------------------------------------------------
// <copyright company="Fireasy"
//      email="faib920@126.com"
//      qq="55570729">
//   (c) Copyright Fireasy. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
using System;
using System.Data;
using Fireasy.Data.RecordWrapper;

namespace Fireasy.Data
{
    /// <summary>
    /// 一个抽象类，使用 <see cref="IDataReader"/> 或 <see cref="DataRow"/> 的相关列索引位置进行映射。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class FieldRowMapperBase<T> : IDataRowMapper<T>
    {
        /// <summary>
        /// 将一个 <see cref="IDataReader"/> 转换为一个 <typeparamref name="T"/> 的对象。
        /// </summary>
        /// <param name="database">当前的 <see cref="IDatabase"/> 对象。</param>
        /// <param name="reader">一个 <see cref="IDataReader"/> 对象。</param>
        /// <returns>由当前 <see cref="IDataReader"/> 对象中的数据转换成的 <typeparamref name="T"/> 对象实例。</returns>
        public abstract T Map(IDatabase database, IDataReader reader);

        /// <summary>
        /// 将一个 <see cref="DataRow"/> 转换为一个 <typeparamref name="T"/> 的对象。
        /// </summary>
        /// <param name="database">当前的 <see cref="IDatabase"/> 对象。</param>
        /// <param name="row">一个 <see cref="DataRow"/> 对象。</param>
        /// <returns>由 <see cref="DataRow"/> 中数据转换成的 <typeparamref name="T"/> 对象实例。</returns>
        public abstract T Map(IDatabase database, DataRow row);

        /// <summary>
        /// 获取或设置 <see cref="IRecordWrapper"/>。
        /// </summary>
        public IRecordWrapper RecordWrapper { get; set; }

        /// <summary>
        /// 获取或设置对象的初始化器。
        /// </summary>
        public Action<object> Initializer { get; set; }

        object IDataRowMapper.Map(IDatabase database, IDataReader reader)
        {
            return Map(database, reader);
        }

        object IDataRowMapper.Map(IDatabase database, DataRow row)
        {
            return Map(database, row);
        }

        /// <summary>
        /// 获取 <see cref="IDataRecord"/> 对象中的所有列。
        /// </summary>
        /// <param name="reader">当前实例中的 <see cref="IDataRecord"/> 对象。</param>
        /// <returns><see cref="IDataRecord"/> 对象中所包含的字段名称的数组。</returns>
        protected string[] GetDataReaderFields(IDataRecord reader)
        {
            var fieldLength = reader.FieldCount;
            var fields = new string[fieldLength];
            for (var i = 0; i < fieldLength; i++)
            {
                fields[i] = reader.GetName(i);
            }

            return fields;
        }

        /// <summary>
        /// 获取 <see cref="DataRow"/> 对象中的所有列。
        /// </summary>
        /// <param name="row">当前实例中的 <see cref="DataRow"/> 对象。</param>
        /// <returns><see cref="DataRow"/> 对象中所包含的字段名称的数组。</returns>
        protected string[] GetDataRowFields(DataRow row)
        {
            var fieldLength = row.Table.Columns.Count;
            var fields = new string[fieldLength];
            for (var i = 0; i < fieldLength; i++)
            {
                fields[i] = row.Table.Columns[i].ColumnName;
            }

            return fields;
        }

        /// <summary>
        /// 获取列在列数组中的索引位置。
        /// </summary>
        /// <param name="fields">包含的列数组。</param>
        /// <param name="fieldName">要检查的列名称。</param>
        /// <returns>如果列存在于数组中，则为大于或等于 0 的值，否则为 -1。</returns>
        protected int IndexOf(string[] fields, string fieldName)
        {
            for (var i = 0; i < fields.Length; i++)
            {
                var fieldName1 = fields[i];
                var p = fieldName1.IndexOf('.');
                if (p != -1)
                {
                    fieldName1 = fieldName1.Substring(p + 1);
                }

                if (fieldName.Equals(fieldName1, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

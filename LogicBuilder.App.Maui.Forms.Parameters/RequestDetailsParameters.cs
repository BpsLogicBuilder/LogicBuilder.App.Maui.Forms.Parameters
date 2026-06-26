using LogicBuilder.Attributes;
using System;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
    public class RequestDetailsParameters(
        [Comments("The model element type for the queryable i.e. T in IQueryable<T>. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type modelType,

        [Comments("The data element type for the queryable i.e. T in IQueryable<T>. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type dataType,

        [Comments("The model collection type being returned e.g. IEnumerable<StudentModel>. Click the function button and use the configured GetType function.  Auto complete to System.Collections.Generic.IEnumerable`1.  Finally right-click and select 'Add/Update Generic Arguments'")]
        Type modelReturnType,

        [Comments("The data collection type being returned e.g. IEnumerable<Student>. Click the function button and use the configured GetType function.  Auto complete to System.Collections.Generic.IEnumerable`1.  Finally right-click and select 'Add/Update Generic Arguments'")]
        Type dataReturnType,

        [Comments("API endpoint for the request e.g. api/List/GetList.")]
        string dataSourceUrl
    )
    {
        public Type ModelType { get; } = modelType;
        public Type DataType { get; } = dataType;
        public Type ModelReturnType { get; } = modelReturnType;
        public Type DataReturnType { get; } = dataReturnType;
        public string DataSourceUrl { get; } = dataSourceUrl;
    }
}
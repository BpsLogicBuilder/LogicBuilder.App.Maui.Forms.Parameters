using LogicBuilder.Attributes;
using LogicBuilder.Forms.Parameters.Expansions;
using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.App.Maui.Forms.Parameters
{
#pragma warning disable S107 //Parameters used to configure a request with several settings
    public class FormRequestDetailsParameters(
        [Comments("API end point to get the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Entity/GetEntity")]
        string getUrl,

        [Comments("API end point to add the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Student/Save")]
        string addUrl,

        [Comments("API end point to update the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Student/Save")]
        string updateUrl,

        [Comments("API end point to update the entity.")]
        [NameValue(AttributeNames.DEFAULTVALUE, "api/Student/Delete")]
        string deleteUrl,

        [Comments("The model type for the object being requested. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type modelType,

        [Comments("The data type for the object being requested. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
        Type dataType,

        [Comments("Defines the filter for the single object being edited - only applicable when the edit type is update.")]
        FilterLambdaOperatorParameters? filter = null,

        [Comments("Defines and navigation properties to include in the edit model")]
        SelectExpandDefinitionParameters? selectExpandDefinition = null
    )
#pragma warning restore S107
    {
        public string GetUrl { get; } = getUrl;
        public string AddUrl { get; } = addUrl;
        public string UpdateUrl { get; } = updateUrl;
        public string DeleteUrl { get; } = deleteUrl;
        public Type ModelType { get; } = modelType;
        public Type DataType { get; } = dataType;
        public FilterLambdaOperatorParameters? Filter { get; } = filter;
        public SelectExpandDefinitionParameters? SelectExpandDefinition { get; } = selectExpandDefinition;
    }
}
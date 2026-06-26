using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.App.Maui.Forms.Parameters.SearchForm
{
    public class SearchFilterGroupParameters(
        [Comments("List of filters - maximum of 2.  For additional filters use add a filter group instead of a filter.")]
        ICollection<ISearchFilterParameters> filters
    ) : ISearchFilterParameters
    {
        public ICollection<ISearchFilterParameters> Filters { get; } = filters;
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CruduxCruo.Agnostic
{
    public interface IAutocompleteProvider<T>
    {
        Task<IReadOnlyCollection<T>> ProvideSuggestions(string initialText);
    }
}

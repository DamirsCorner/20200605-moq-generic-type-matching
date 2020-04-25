using FreshMvvm;
using Moq;
using System;

namespace MoqGenericTypeMatching
{
    [TypeMatcher]
    public class IsFreshBasePageModel<T> : FreshBasePageModel, ITypeMatcher
        where T: FreshBasePageModel
    {
        bool ITypeMatcher.Matches(Type typeArgument)
        {
            return typeof(T).IsAssignableFrom(typeArgument);
        }
    }
}

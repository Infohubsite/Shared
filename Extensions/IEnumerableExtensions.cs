using Shared.Interface;

namespace Shared.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<TTo> ConvertFrom<TTo, TFrom>(this IEnumerable<TFrom> from) where TTo : IConverterFrom<TTo, TFrom> => from.Select(TTo.Convert);
        public static IEnumerable<TTo> ConvertTo<TTo, TFrom>(this IEnumerable<TFrom> from) where TFrom : IConverterTo<TFrom, TTo> => from.Select(TFrom.Convert);
    }

    public static class IEnumerableConverter
    {
        public static IEnumerable<TTo> ConvertFrom<TTo, TFrom>(IEnumerable<TFrom> from) where TTo : IConverterFrom<TTo, TFrom> => from.ConvertFrom<TTo, TFrom>();
        public static IEnumerable<TTo> ConvertTo<TTo, TFrom>(IEnumerable<TFrom> from) where TFrom : IConverterTo<TFrom, TTo> => from.ConvertTo<TTo, TFrom>();
    }

    public static class ListConverter
    {
        public static List<TTo> ConvertFrom<TTo, TFrom>(IEnumerable<TFrom> from) where TTo : IConverterFrom<TTo, TFrom> => [.. from.ConvertFrom<TTo, TFrom>()];
        public static List<TTo> ConvertTo<TTo, TFrom>(IEnumerable<TFrom> from) where TFrom : IConverterTo<TFrom, TTo> => [.. from.ConvertTo<TTo, TFrom>()];
    }
}

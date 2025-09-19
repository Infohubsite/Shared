namespace Shared.Interface
{
    public interface IConverterFrom<T, TFrom>
    {
        public static abstract T Convert(TFrom from);
    }
    public interface IConverterTo<T, TTo>
    {
        public static abstract TTo Convert(T from);
    }
    public interface IConverterBi<T, TOther> : IConverterFrom<T, TOther>, IConverterTo<T, TOther>;
}

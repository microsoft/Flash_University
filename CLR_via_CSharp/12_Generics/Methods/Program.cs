internal sealed class GenericType<T>
{
    private readonly T _value;

    public GenericType(T value)
    {
        _value = value;
    }

    public TOutput Converter<TOutput>()
    {
        var result = (TOutput)Convert.ChangeType(_value, typeof(TOutput));
        return result;
    }
}
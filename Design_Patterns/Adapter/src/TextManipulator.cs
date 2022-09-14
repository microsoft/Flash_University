namespace Adapter;

/**
 * A Utility for manipulating text in various ways
 *
 * This is the "Adaptee"
 *
 * The interface of this class clearly does not match
 * the ITransformer that the CLI needs. In addition,
 * this class is missing a slight piece of functionality -
 * you can change the source text, it's only set in
 * the constructor.
 *
 * The Transformer class will implement the ITransformer
 * interface in front of this class, and it will also
 * implement the missing behavior (updating the source
 * text on the fly)
 *
 * NOTE - in this example it is easy to update this class
 * to match the ITransformer interface; however, in real
 * cases this class wouldn't be able to be updated for various
 * reasons (it's 3rd-party code, the existing interface is
 * being used somewhere else, etc), and thus the "adapter"
 * is necessary.
 */
public class TextManipulator
{
    public string Source { get; }
    private readonly Random _random = new();

    /*
     * As mentioned above, the source text is set
     * at construction time and cannot be updated
     */
    public TextManipulator(string source)
    {
        Source = source;
    }

    /**
     * Manipulate the source string based on the passed options
     *
     * This is the only method exposed - it contains all of the
     * functionality that the CLI needs, but it doesn't match the
     * ITransformer interface.
     */
    public string Manipulate(Options options)
    {
        var text = Source;

        if (options.Prefix != null) text = options.Prefix + text;

        if (options.Postfix != null) text = text + options.Postfix;

        if (options.Interspersed != null) text = Intersperse(text, options.Interspersed);

        if (options.Case == TextCase.Uppercase)
            text = text.ToUpper();
        else if (options.Case == TextCase.Lowercase) text = text.ToLower();

        return text;
    }

    private string Intersperse(string text, string interspersion)
    {
        var words = new List<string>(text.Split(" "));
        var textWithInterspersion = "";

        while (words.Count > 0)
        {
            var numWords = _random.Next(1, 4);

            if (numWords >= words.Count)
            {
                textWithInterspersion += string.Join(" ", words);
                words.Clear();
            }
            else
            {
                textWithInterspersion += string.Join(" ", words.Take(numWords)) + $" {interspersion} ";
                words.RemoveRange(0, numWords);
            }
        }

        return textWithInterspersion;
    }

    #region helper classes

    public enum TextCase
    {
        Uppercase,
        Lowercase
    }

    public class Options
    {
        public TextCase? Case { get; set; }
        public string? Prefix { get; set; }
        public string? Postfix { get; set; }
        public string? Interspersed { get; set; }
    }

    #endregion
}

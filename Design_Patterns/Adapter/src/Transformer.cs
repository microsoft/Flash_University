namespace Adapter;

/**
 * A utility for transforming text
 *
 * This is the "Adapter" (specifically an "object adapter") 
 *
 * This class wraps TextManipulator to provide the
 * ITransformer interface the CLI requires. In addition,
 * it adds the "update the source text on the fly" behavior
 * that is missing in TextManipulator.
 *
 * The "Adapter" shouldn't have much (if any) actual functionality
 * in it - the brunt of the work should be passed off to
 * the "Adaptee" object.
 *
 * In this example, this class is doing a minimal amount of
 * data formatting between ITransformer and TextManipulator
 * (just creating options objects). In real uses, there is often
 * a lot more data formatting that needs to be done.
 *
 * Additionally, the functionality doesn't always line up 1-1,
 * so the "Adapter" may have to call multiple methods on the
 * "Adaptee" and/or do some more plumbing.
 */
public class Transformer : ITransformer
{
    private TextManipulator _manipulator;

    public Transformer(string text = "")
    {
        _manipulator = new TextManipulator(text);
    }

    #region ITransformer methods

    public void SetText(string text)
    {
        _manipulator = new TextManipulator(text);
    }

    public string GetBaseText()
    {
        return _manipulator.Source;
    }

    public string Uppercase()
    {
        return _manipulator.Manipulate(new TextManipulator.Options
        {
            Case = TextManipulator.TextCase.Uppercase
        });
    }

    public string Exclaim()
    {
        return _manipulator.Manipulate(new TextManipulator.Options
        {
            Postfix = "!"
        });
    }

    public string Shout()
    {
        return _manipulator.Manipulate(new TextManipulator.Options
        {
            Case = TextManipulator.TextCase.Uppercase,
            Postfix = "!"
        });
    }

    public string Whisper()
    {
        return _manipulator.Manipulate(new TextManipulator.Options
        {
            Case = TextManipulator.TextCase.Lowercase,
            Interspersed = "..."
        });
    }

    #endregion
}

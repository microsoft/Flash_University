namespace Command;

/**
 * The base Command class
 *
 * At minimum the base Command only needs to contain
 * some method to execute the command (Execute in this example).
 *
 * The Command class can have other methods/properties to add functionality.
 * Some examples:
 *  - Undo (to allow undoing all operations)
 *  - Name/Description (to allow logging info about commands)
 *  - Serialize/Deserialize (to allow saving/recording applied commands)
 */
public abstract class Command
{
    public abstract string Name { get; }
    public abstract string Description { get; }

    public abstract void Execute();
}

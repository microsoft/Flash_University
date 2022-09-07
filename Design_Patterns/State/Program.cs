/*
 * This example showcases the State design pattern.
 *
 * ## Summary
 *
 * The State pattern abstracts out the different states of an object
 * into separate classes, and encapsulates behavior specific to each
 * state in corresponding state class
 *
 * Here are the key pieces:
 *  - State Superclass:
 *      abstract class that defines the interface for the state-specific behavior
 *  - Concrete State Subclasses:
 *      concrete state subclasses that implement the state-specific behavior
 *  - Context:
 *      class that contains the state object and calls into it for state-specific behavior
 *
 * Notes:
 *  - This pattern does not explicitly specified who is responsible for
 *      performing the transition between states. It could be the Context,
 *      or the State classes themselves.
 *  - Generally, the State objects should not be exposed in Context
 *
 * ## Example
 *
 *  - Note (Note.cs)
 *      The `Context` class
 *      It is initialized with DraftState
 *
 *  - NoteState (NoteState.cs)
 *      The abstract State base class
 *
 *  - DraftState/ReviewState/PublishedState (NoteState.cs)
 *      The concrete State classes
 *      These classes control the state transitions:
 *          Draft: Publish -> Review
 *          Review: Approve(true) -> Published, Approve(false) -> Draft, UpdateContent -> Draft
 *          Published: none
 */

using State;

new Cli().Run();

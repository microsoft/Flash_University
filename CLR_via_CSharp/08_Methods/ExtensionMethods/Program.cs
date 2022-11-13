//StringBuilder has fewer methods than string for manipulation, so maybe we want to add a method to StringBuilder that exists in String
//

using System.Text;
using ExtensionMethods;


StringBuilder sb = new StringBuilder("Hello my name is not Jeff. Thank god.");
Console.WriteLine(sb);
//Int32 index = StringBuilderExtensions.IndexOf(sb.Replace('.', '!'), '!');

Int32 index = sb.Replace('.', '!').
Console.WriteLine(sb);

//not ideal b/c this requires us to know sbe exists; how dow we add a function to StringBuilder?

//how do we get to
//Int32 index = sb.Replace('.', '!').IndexOf('!');
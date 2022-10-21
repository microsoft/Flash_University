using System.Text;

var s = "Hi there.";

// Obtain an Encoding-derived object that knows how 
// to encode/decode using UTF8
var encodingUTF8 = Encoding.UTF8;

// Encode a string into an array of bytes.
var encodedBytes = encodingUTF8.GetBytes(s);

// Show the encoded byte values.
Console.WriteLine("Encoded bytes: " +
                  BitConverter.ToString(encodedBytes));

// Decode the byte array back to a string.
var decodedString = encodingUTF8.GetString(encodedBytes);

// Show the decoded string.
Console.WriteLine("Decoded string: " + decodedString);
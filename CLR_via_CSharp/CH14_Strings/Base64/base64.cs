using System.Text;

var bytes = new byte[10];
new Random().NextBytes(bytes);

// Display the bytes
Console.WriteLine(BitConverter.ToString(bytes));

// Decode the bytes into a base-64 string and show the string
var s = Convert.ToBase64String(bytes);
Console.WriteLine(s);

// Encode the base-64 string back to bytes and show the bytes
bytes = Convert.FromBase64String(s);
Console.WriteLine(BitConverter.ToString(bytes));

//This should show converting from one to th eother can work -- not sure about UTF 8 --> 64 but this is proof that the same bytes are convertible and equivalent


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
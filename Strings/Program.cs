string msg = "Hello to dot net programming!";
Console.WriteLine(msg);
// clone the string
string clonedMsg = string.Copy(msg);
Console.WriteLine("Cloned: " + clonedMsg);

// compare strings
string msg2 = "Hello to dot net programming!";
Console.WriteLine("Are the strings equal? " + msg.Equals(msg2));

string msg3 = "to be concatenated";
// concatenate strings
string concatenatedMsg = string.Concat(msg, " ", msg3);

Console.WriteLine("Concatenated: " + concatenatedMsg);

// find the length of the string
Console.WriteLine("Length of the concatenated string: " + concatenatedMsg.Length);

// index of string
int index = concatenatedMsg.IndexOf("dot");
Console.WriteLine("Index of 'dot': " + index);

// substring
string subString = concatenatedMsg.Substring(index, 3);
Console.WriteLine("Substring: " + subString);

// formatted string
string formattedMsg = string.Format("The message is: {0}", concatenatedMsg);
Console.WriteLine("Formatted: " + formattedMsg);

// padding 
string paddedMsg = formattedMsg.PadLeft(5, '*');
Console.WriteLine("Padded: " + paddedMsg);

// replacing text
string replacedMsg = concatenatedMsg.Replace("dot", "dynamic");
Console.WriteLine("Replaced: " + replacedMsg);

// splitting strings
string[] splitMsg = concatenatedMsg.Split(' ');
Console.WriteLine("Split message:");
foreach (string part in splitMsg)
{
    Console.WriteLine(part);
}

// trimming strings
string msgWithSpaces = "   Hello with spaces   ";
string trimmedMsg = msgWithSpaces.Trim();
Console.WriteLine("Trimmed message: '" + trimmedMsg + "'");


string padding_string = "Hello";
// padding with asterisks
string paddedString = padding_string.PadLeft(10, '*');
Console.WriteLine("Padded string: " + paddedString);

string paddedLeft = padding_string.PadLeft(10);
Console.WriteLine("Padded left: " + paddedLeft);
Practice Strings
1. Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways
Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction (from the last to the first) in a for-loop
Input Output
sample elpmas
24tvcoi92 29iocvt42

2. Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g. C++, a+b, and a77 are
considered valid words.
The sentences always start by word and end by separator.
C# is not C++, and PHP is not Delphi!
Delphi not is PHP, and C++ not is C#!
The quick brown fox jumps over the lazy dog /Yes! Really!!!/.
Really Yes dog lazy the over jumps fox brown /quick! The!!!/.

3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted
Hi,exe? ABBA! Hog fully a string: ExE. Bob
a, ABBA, exe, ExE

4. Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The [protocol] and [resource] parts are optional.
https://www.apple.com/iphone
[protocol] = "https"
[server] = "www.apple.com"
[resource] = "iphone"
ftp://www.example.com/employee
[protocol] = "ftp"
[server] = "www.example.com"
[resource] = "employee"
https://google.com
[protocol] = "https"
[server] = "google.com"
[resource] = ""
www.apple.com
[protocol] = ""
[server] = "www.apple.com"
[resource] = ""

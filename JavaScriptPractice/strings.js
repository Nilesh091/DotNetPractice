//string with single quote and double quote
var str1 = 'Hello, World!';
var str2 = "Hello, World!";
console.log(str1);
console.log(str2);

//using quote inside string
var str3 = "It's a nice day!";
var str4 = 'She said, "Hello!"';
console.log(str3);
console.log(str4);

//escaping quotes
var str5 = 'It\'s a nice day!';
var str6 = "She said, \"Hello!\"";
console.log(str5);
console.log(str6);

//escape sequences
var str7 = "Line 1\nLine 2\nLine 3";
var str8 = "Column 1\tColumn 2\tColumn 3";
console.log(str7);
console.log(str8);
//\\ represents a single backslash character
var str9 = "This is a backslash: \\";
console.log(str9);

// length of string
var str10 = "Hello, World!";
console.log("Length of str10: ", str10.length);

//indexof anf lastindexof
var str11 = "Hello, World!";
console.log("Index of 'o': ", str11.indexOf('o'));
console.log("Last index of 'o': ", str11.lastIndexOf('o'));

//slice and substring
var str12 = "Hello, World!";
console.log("Slice from index 0 to 5: ", str12.slice(0, 5));
console.log("Substring from index 7 to 12: ", str12.substring(7, 12));
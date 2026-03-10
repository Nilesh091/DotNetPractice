//Write a program to implement all the operators in JavaScript and print the output in console. using switch case statement.
//use switch case statement to implement all the operators in JavaScript and print the output in console.

var a = 10;
var b = 5;
var operator = "+";

switch(operator) {
    case "+":
        console.log("Addition:", a + b);
        break;
    case "-":
        console.log("Subtraction:", a - b);
        break;
    case "*":
        console.log("Multiplication:", a * b);
        break;
    case "/":
        console.log("Division:", a / b);
        break;
    case "%":
        console.log("Modulus:", a % b);
        break;
    case "++":
        console.log("Increment:", ++a);
        break;
    case "--":
        console.log("Decrement:", --b);
        break;
    default:
        console.log("Invalid operator");
}


// implement all iterators in js
var arr = [1, 2, 3, 4, 5];  
console.log("Using for loop:");
for(var i = 0; i < arr.length; i++) {
    console.log(arr[i]);
}

console.log("Using for...of loop:");
for(var num of arr) {
    console.log(num);
}

console.log("Using forEach method:");
arr.forEach(function(num) {
    console.log(num);
});

//while and dowhile loop
console.log("Using while loop:");
var i = 0;
while(i < arr.length) {
    console.log(arr[i]);
    i++;
}

console.log("Using do...while loop:");
var j = 0;
do {
    console.log(arr[j]);
    j++;
} while(j < arr.length);   
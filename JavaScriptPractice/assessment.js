//all solution qn 1 to 15


// 1 Sample  program to print a welcome message
console.log("Welcome to JavaScript Programming");
// 2 program to read a number user and display it 
var readline = require('readline').createInterface({
    input:process.stdin,
    output:process.stdout
});

readline.question('please enter a number',num=>{
    console.log(`The number entered by user is: ${num}`);
    readline.close();
});

// 3 program to read a floating point number from user
var floatnuminput = require('readline').createInterface({
    input:process.stdin,
    output:process.stdout
});
floatnuminput.question('please enter a floating point number',floatNum=>{
    console.log(`The floating point number entered by user is: ${floatNum}`);
    floatnuminput.close();
});


//4 program to read a string from user and display it on the screen 

var stringinput = require('readline').createInterface({
    input:process.stdin,
    output:process.stdout
});
stringinput.question('please enter a string',str=>{
    console.log(`The string entered by user is: ${str}`);
    stringinput.close();
});



//5 program to perform all arithmetic operations
var a = 10;
var b = 5;
console.log("Addition: " + (a + b));
console.log("Subtraction: " + (a - b));
console.log("Multiplication: " + (a * b));
console.log("Division: " + (a / b));
// 6 program to find the area of circle 

var radius = 5;
var area = Math.PI * radius * radius;
console.log("The area of the circle with radius " + radius + " is: " + area);
//7) program to find whether the given number is Even or Odd
var number = 10;
if (number % 2 === 0) {
    console.log(number + " is an Even number");
} else {
    console.log(number + " is an Odd number");
}

//8)program to find the greatest of 2 numbers 

var num1 = 10;
var num2 = 20;
if (num1 > num2) {
    console.log(num1 + " is greater than " + num2);
} else {
    console.log(num2 + " is greater than " + num1);
}
//9) program to find whether a given number is positive ,negative or zero
var num3 = -5;
if (num3 > 0) {
    console.log(num3 + " is a positive number");
} else if (num3 < 0) {
    console.log(num3 + " is a negative number");
} else {
    console.log(num3 + " is zero");
}
//10) program to find the greatest of three numbers
var n1 = 10;
var n2 = 20;
var n3 = 30;
if (n1 > n2 && n1 > n3) {
    console.log(n1 + " is greatest");
} else if (n2 > n1 && n2 > n3) {
    console.log(n2 + " is greatest");
} else {
    console.log(n3 + " is greatest");
}

//10 a program to find the greatest of three numbers using nested if

var num1 = 10;
var num2 = 20;
var num3 = 30;
if (num1 > num2) {
    if (num1 > num3) {
        console.log(num1 + " is greatest"); 
    } else {
        console.log(num3 + " is greatest");
    }
} else {
    if (num2 > num3) {
        console.log(num2 + " is greatest");    
    } else {
        console.log(num3 + " is greatest");
    }  
}




// 11 program to find the greatest of 3 numbers using conditional operator 
var n1 = 10;
var n2 = 20;
var n3 = 30;
var greatest = (n1 > n2) ? ((n1 > n3) ? n1 : n3) : ((n2 > n3) ? n2 : n3);
console.log(greatest + " is greatest");

// 12 program to read student num,name,marks and calculate total and average and print result and division 

var studentNum = 1;
var studentName = "John Doe";
var marks1 = 85;
var marks2 = 90;
var marks3 = 80;

var totalMarks = marks1 + marks2 + marks3;
var averageMarks = totalMarks / 3;
console.log("Student Number: " + studentNum);
console.log("Student Name: " + studentName);
console.log("Total Marks: " + totalMarks);
console.log("Average Marks: " + averageMarks);
if (averageMarks >= 90) {
    console.log("Division: First Division");
} else if (averageMarks >= 75) {
    console.log("Division: Second Division");
} else if (averageMarks >= 60) {
    console.log("Division: Third Division");
} else {
    console.log("Division: Fail");
}
// 13 program to read eno,ename,basic salary and calculate  pf,hra,da,net salary and gross salary and print 


var eno = 1;
var ename = "John Doe";
var basicSalary = 50000;   
var pf = 0.12 * basicSalary;
var hra = 0.20 * basicSalary;
var da = 0.15 * basicSalary;
var grossSalary = basicSalary + pf + hra + da;
var netSalary = grossSalary - pf;
console.log("Employee Number: " + eno);
console.log("Employee Name: " + ename);
console.log("Basic Salary: " + basicSalary);
console.log("Gross Salary: " + grossSalary);
console.log("Net Salary: " + netSalary);
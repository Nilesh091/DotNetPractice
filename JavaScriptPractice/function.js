console.log("js function demo")
//what is function
console.log("1 defining and calling a function\n");
function sayHello(){
    console.log("Hello world");
}
//calling function
sayHello();

//2. function with parameters
console.log("\n2. function with parameters\n"); 

function displaySum(num1,num2){
    var total = num1 + num2;
    console.log("sum:" ,total);
}
displaySum(5,10);
displaySum(-5,17);
//3 default parameters
console.log("\n3. default parameters\n");
function greet(name = "Guest"){
    console.log("Hello, " + name + "!");
}

//4 returning value
console.log("\n4. returning value\n");
function getSum(num1,num2){
    var total = num1 + num2;
    return total;
}

//4 returning value
console.log("\n4. returning value\n");
function getSum(num1,num2){
    var total = num1 + num2;
    return total;
}




//5. return multiplce value (array)
console.log("\n5. return multiple value (array)\n");
function divideNumbers(dividend,divisor){
    var quotient = dividend / divisor;
    var arr = [quotient, dividend, divisor];
    return arr;
}

var all = divideNumbers(10,2);
console.log("quotient:", all[0]);
console.log("dividend:", all[1]);
console.log("divisor:", all[2]);   





//6. return multiple values using object (recommended)
function getvalues(obj){
    return {x:20, y:30};
}
let result = getvalues();
console.log("x:", result.x);
console.log("y:", result.y);






//7. simulating c# out parameter using object reference
console.log("\n 7. simulating c# out parameter \n");
function modifyObject(obj){
    obj.a=100;
    obj.b=200;
}
let objResult = {};
modifyObject(objResult);
console.log("a:", objResult.a);
console.log("b:", objResult.b);




// destructuring 
console.log("\n 8. destructuring \n");
function getCoordinates(){
    return {x:10, y:20};
}

let {x,y} = getCoordinates();
console.log("x:", x);
console.log("y:", y);

//function expression
console.log("\n 9. function expression \n");
var sumExpression = function(num1,num2){
    return num1 + num2;
}
console.log("Sum using function expression: ", sumExpression(5,10));

var sum=sumExpression(15,25);
console.log("Sum using function expression: ", sum);

//arrow function
console.log("\n 10. arrow function \n");
var sumArrow = (num1,num2) => num1 + num2;
console.log("Sum using arrow function: ", sumArrow(5,10));
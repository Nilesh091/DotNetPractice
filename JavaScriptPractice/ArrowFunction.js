console.log("arrow function demo");
//1 normal function
console.log("1. normal function\n");
function add(a,b){
    return a + b;
}
console.log("normal function result : ",add(5,10));
   

console.log("Arrow Function Basics");
const addArrow=(a,b)=>{
  return a+b;
}
console.log("Arrow Function Result : ",addArrow(5,10));

//Short arrow function (single line)
console.log("Short Arrow Function");
const multiplyShortArrow=(a,b)=> a*b;
console.log("Short Arrow Function Result : ",multiplyShortArrow(5,10));

//Arrow function without parameters
console.log("Arrow Function with No Parameters");
const greet=()=> "Hello, World!";
console.log(greet());

//Arrow function with single parameter
console.log("Arrow Function with Single Parameter");
const square=x=> x*x;
console.log("Square of 5 : ",square(5));

//arrow function with array foreach
console.log("Arrow Function with Array");
let numbers = [1,2,3,4,5];
numbers.forEach(num => console.log("Number:", num));




//arrow function with map()
console.log("\n 7. arrow function with map()\n");
let doubled = numbers.map(num => num * 2);
console.log("Doubled arrays:", doubled);

//8.difference in this behavior
console.log("\n 8. difference in this behavior\n");
let person1 = {
    name: "Ravi",
    greet : function (){
        console.log("Hello, I am " + this.name);
    }
}
person1.greet();



//arrow function inside object (nnot recommended)
let person2 = {
    name : "Ravi",
    greet : () => {
        console.log("arrow function this.name  " + this.name);
    }
};
person2.greet();


console.log("end of the program");


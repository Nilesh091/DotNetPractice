//create 4 arrays colour,fruits,cities,persons and display them on the console
var colours = ["Red", "Green", "Blue", "Yellow"];
var fruits = ["Apple", "Banana", "Orange", "Grapes"];
var cities = ["New York", "London", "Paris", "Tokyo"];
var persons = ["Alice", "Bob", "Charlie", "David"];

console.log("Colours: ", colours);
console.log("Fruits: ", fruits);
console.log("Cities: ", cities);
console.log("Persons: ", persons);  

// using constructer array
var colours = new Array("Red", "Green", "Blue", "Yellow");
var fruits = new Array("Apple", "Banana", "Orange", "Grapes");
var cities = new Array("New York", "London", "Paris", "Tokyo");
var persons = new Array("Alice", "Bob", "Charlie", "David");

console.log("Colours: ", colours);
console.log("Fruits: ", fruits);
console.log("Cities: ", cities);
console.log("Persons: ", persons);

//accessing array elements using index
console.log("First colour: ", colours[0]);
console.log("Second fruit: ", fruits[1]);
console.log("Third city: ", cities[2]);
console.log("Fourth person: ", persons[3]);

console.log("Length of colours array: ", colours.length);

//looping through arrays using for loop
console.log("Colours:");
for (var i = 0; i < colours.length; i++) {
    console.log(colours[i]);
}

console.log("Fruits:");
for (var i = 0; i < fruits.length; i++) {
    console.log(fruits[i]);
}
//for each loop
console.log("Cities:");
cities.forEach(function(city) {
    console.log(city);
});
//for of loop
console.log("Persons:");
for (var person of persons) {
    console.log(person);
}

//adding element to array 
colours.push("Purple");
fruits.push("Mango");
cities.push("Sydney");
persons.push("Eve");
//unshift
colours.unshift("Pink");
fruits.unshift("Strawberry");
cities.unshift("Berlin");
persons.unshift("Frank");

console.log("Updated Colours: ", colours);
console.log("Updated Fruits: ", fruits);
console.log("Updated Cities: ", cities);
console.log("Updated Persons: ", persons);

//removing element from array
var lastColour = colours.pop();
console.log("Removed last colour: ", lastColour);
console.log("Colours after pop: ", colours);
console.log("Length of colours array after pop: ", colours.length);

//insert in middle
colours.splice(2, 0, "Orange");
console.log("Colours after inserting Orange at index 2: ", colours);

//remove from middle
var removedColour = colours.splice(3, 1);
console.log("Removed colour: ", removedColour);
console.log("Colours after removing element at index 3: ", colours);

//2D array
var matrix = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];
console.log("2D Array (Matrix): ", matrix);
console.log("Element at row 1, column 2: ", matrix[0][1]);

//traverse using nested loops
console.log("Traversing 2D Array:");
for (var i = 0; i < matrix.length; i++) {
  let row="";
    for (var j = 0; j < matrix[i].length; j++) {
        row += matrix[i][j] + " ";
    }
    console.log(row);
} 
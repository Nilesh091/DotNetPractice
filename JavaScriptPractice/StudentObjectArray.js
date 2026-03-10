//creating object array with name age gender display name(function)
let students = [
    {

        name : "Ravi",
        age : 20,
        gender : "Male",
        display : function(){
            console.log("Name: " + this.name + ", Age: " + this.age + ", Gender: " + this.gender);
        }
    },
];
console.log(students);

console.log(students[0].name);
console.log(students[0]["age"]);
console.log(students[0]["display"]());
console.log(students[0].display());

var student2 = {
    name : "Sita",
    age : 22,
    skills : ["JavaScript", "Python", "Java"],
    address:{
        city : "Kathmandu",
        country : "Nepal"
    }
  };

  //accessing student2 properties
  console.log(student2.name);
  console.log(student2.skills[1]);
  console.log(student2.address.city);

  //create array of objects student id ,name age grade
  let studentArray = [
    {
        id : 1,
        name : "Ravi",
        age : 20,
        grade : "A"
    },
    {
        id : 2,
        name : "Sita",
        age : 22,
        grade : "B"
    },
    {
        id : 3,
        name : "Hari",
        age : 21,
        grade : "A+"
    }
  ];

  console.log(studentArray);
  // iterate through for loop
  console.log("Iterating through studentArray using for loop");
  for(let i=0; i<studentArray.length; i++){
    console.log("ID: " + studentArray[i].id + ", Name: " + studentArray[i].name + ", Age: " + studentArray[i].age + ", Grade: " + studentArray[i].grade);
  }

  // iterate through for of loop
for(let v of studentArray){
  console.log(v.id);
  console.log(v.name);
  console.log(v.age);
  console.log(v.grade);
}

// iterate through for each loop
console.log("Iterating through studentArray using forEach loop");
studentArray.forEach(student=>{
  console.log("ID: " + student.id + ", Name: " + student.name + ", Age: " + student.age + ", Grade: " + student.grade);
})


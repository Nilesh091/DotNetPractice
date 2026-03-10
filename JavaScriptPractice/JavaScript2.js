// const { read } = require('fs');

var readline=require('readline').createInterface({
    input:process.stdin,
    output:process.stdout
});

readline.question("EnterYourName:",name=>{
    console.log("Hello",name);
    readline.close();
})
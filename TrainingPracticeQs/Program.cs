// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast");

// app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }

using System;
using mrl;
class Program
{
    static void Main()
    {
        //Console.WriteLine("Hello, World!");
        //AddProg.Add();

        // FunctionsinCSharp obj = new FunctionsinCSharp();
        // int result = obj.add(10, 20);
        // Console.WriteLine("The sum is: " + result);
        // int firstNo = Convert.ToInt32(Console.ReadLine());
        // int secondNo = Convert.ToInt32(Console.ReadLine());
        // char operatorChar = Convert.ToChar(Console.ReadLine());
        // Calcualator calc = new Calcualator();
        // int res = calc.calculate(firstNo, secondNo, operatorChar);
        // Console.WriteLine("The result is: " + res);
        // Forloop f1 = new Forloop();
        // f1.printFor();
        // Arrays arr = new Arrays();
        // arr.createArray();
        // Q22 q22 = new Q22();
        // q22.printQ22();
        // Q24 q24 = new Q24();
        // q24.printQ24();
        Console.WriteLine("Celsius to Fahrenheit Conversion:");
        CelsiustoFahrenheitConversion celsius = new CelsiustoFahrenheitConversion();
        celsius.convertTemp();
        Console.WriteLine("\nStudent Grade Calculator:\n");
        StudentGradeCalculator grade = new StudentGradeCalculator();
        grade.calculateGrade();
        Console.WriteLine("\nSum of First N Natural Numbers:\n");
        SumofFirstNNaturalNumbers sum = new SumofFirstNNaturalNumbers();
        sum.calculateSum();
        Console.WriteLine("\n Factorial Calculator with Continuous Input:\n");
        FactorialCalculatorwithContinuousInput factorial = new FactorialCalculatorwithContinuousInput();
        factorial.calculateFactorials();
        Console.WriteLine("\n Print First N Even Numbers:\n");
        PrintFirstNEvenNumbers evenNum = new PrintFirstNEvenNumbers();
        evenNum.printFirstEvenNumbers();
        Console.ReadKey(true);

    }
}

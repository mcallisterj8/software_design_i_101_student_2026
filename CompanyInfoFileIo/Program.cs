
using System.Text.Json;

EmployeeWriter writer = 
    new EmployeeWriter { DirPath = "./Employees" };


string jsonFilePath = "./company_info.json";
string json = File.ReadAllText(jsonFilePath);

Company? companyA
    = JsonSerializer.Deserialize<Company>(json);

Employee singleEmployee = companyA.Employees[1];

// Call the Write() method and pass a single Employee to it
writer.Write(singleEmployee);

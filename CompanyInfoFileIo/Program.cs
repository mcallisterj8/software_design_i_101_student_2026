using System.Text.Json;

string jsonFilePath = "./company_info.json";
string json = File.ReadAllText(jsonFilePath);

// Like JSON.parse() in JavaScript
Company? companyA
    = JsonSerializer.Deserialize<Company>(json);

Employee singleEmployee = companyA.Employees[1];

EmployeeWriter writer = new EmployeeWriter { DirPath = "./Employees" };

// Call the Write() method on writer and pass in the Employee.
writer.Write(singleEmployee);




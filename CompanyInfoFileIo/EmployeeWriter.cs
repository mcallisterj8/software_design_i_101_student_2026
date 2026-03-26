using System.Runtime.Serialization.Formatters;
using System.Text.Json;

public class EmployeeWriter {
    public required string DirPath { get; set; }

    /*
        Takes in a Employee object, and then 
        writes out its details to the directory
        given in DirPath.

        The file should named <EmployeeID>.txt
        Write out the Employee's ID, full name, and annual salary.
    */
    public void Write(Employee employee) {
        /*
             1) Create the directory DirPath
             2) Move into DirPath directory
             3) Write file contents
        */
        // Create the directory DirPath
        Directory.CreateDirectory(this.DirPath);

        // Move into DirPath directory
        Directory.SetCurrentDirectory(this.DirPath);

        // Write the file contents
        string fileName = $"{employee.Id}.txt";
        string content = $"ID: {employee.Id}\n\tFull Name: {employee.FullName}\n\tAnnual Salary: {employee.AnnualSalary}";

        // Write out to the file
        File.WriteAllText(fileName, content);
        Directory.SetCurrentDirectory("..");

    }

}
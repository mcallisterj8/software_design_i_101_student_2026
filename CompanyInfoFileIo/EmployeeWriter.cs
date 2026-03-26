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
    public void Write(Employee employee, EmployeeOptions? options = null) {
        /*
             1) Create the directory DirPath
             2) Move into DirPath directory
             3) Write file contents
        */
        // Create the directory DirPath
        Directory.CreateDirectory(this.DirPath);

        // Move into DirPath directory
        Directory.SetCurrentDirectory(this.DirPath);

        if (null == options) {
            options = new EmployeeOptions { };
        }

        // Write the file contents
        string fileName = $"{employee.Id}.txt";
        string content = $"ID: {employee.Id}\n\tFull Name: {employee.FullName}\n\tAnnual Salary: {employee.AnnualSalary}";

        if (options.IncludePosition) {
            content
                += $"\n\tPosition ID: {employee.Position.Id}\n\tPosition Description: {employee.Position.Description}";
        }

        if (options.IncludeBenefits) {
            content += "\n\tBenefits:\n";

            foreach (Benefit benefit in employee.Benefits) {
                content += @$"ID: {benefit.Id}
                    Description: {benefit.Description}
                    Additional Amount: {benefit.Additional}
                    -----------------------------------------
                ";
            }
        }

        // Write out to the file
        File.WriteAllText(fileName, content);
        Directory.SetCurrentDirectory("..");

    }

    public void WriteAll(List<Employee> employees, EmployeeOptions? options = null) {
        /**
            Write out all employees in the list
            in the same format as the Write()
            method does.
        */
        foreach (Employee singleEmployee in employees) {
            this.Write(singleEmployee, options);
        }
    }

}
using System.Text.Json;

public class EmployeeWriter {
    public required string DirPath { get; set; }

    /*
        Takes in an Employee object, and will write the details
        of the given Employee to the directory in this.DirPath.
    */
    public void Write(Employee employee) {
        Directory.CreateDirectory(this.DirPath);

        // Move into the directory
        Directory.SetCurrentDirectory(this.DirPath);

        // Create file name that is the ID of the employee. Will be a txt file.
        string fileName = $"{employee.Id}.txt";

        // Write out the contents of the employee to the file.
        string content =
            $"Selected Employee:\n\tID: {employee.Id}\n\tFull Name: {employee.FullName}\n\tAnnual Salary: {employee.AnnualSalary}";

        // Write out to file.
        File.WriteAllText(fileName, content);
        Directory.SetCurrentDirectory("..");
    }
}
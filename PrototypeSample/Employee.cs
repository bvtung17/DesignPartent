public class Employee : ICloneable
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Salary { get; set; }

    public Employee(string name, string role, string salary)
    {
        Name = name;
        Role = role;
        Salary = salary;
    }

    public object Clone()
    {
        return new Employee(Name, Role, Salary);
    }
}
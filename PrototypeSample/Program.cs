var serverConnect = new ServerConnection("1.1.1.1", 80);

var cloneServer = serverConnect.Clone();


Console.WriteLine($"Server IP: {serverConnect.IP}, Port: {serverConnect.Port}");
Console.WriteLine($"Clone Server IP: {cloneServer.IP}, Port: {cloneServer.Port}");


var employee = new Employee("John Doe", "Developer", "1000");

var coloneEmployee = employee.Clone() as Employee;

Console.WriteLine($"Employee Name: {employee.Name}, Role: {employee.Role}, Salary: {employee.Salary}");
Console.WriteLine($"Clone Employee Name: {coloneEmployee.Name}, Role: {coloneEmployee.Role}, Salary: {coloneEmployee.Salary}");
var e1 = new Employee("Mohammad_Rafiei", "2525");
var e2 = new Employee("ali_rezaiei", "2325");
e2.Deactivate();

var fixedSalary = new PaymentItem("حقوق ثابت", 150_000_000m);
var kpi = new PaymentItem("KPI", 100_000_000m);
var other = new PaymentItem("سایر پرداخت‌ها", 50_000_000m);

Console.WriteLine(fixedSalary);
Console.WriteLine(kpi);
Console.WriteLine(other);

var statement = new Statement(e1);
statement.Items.Add(fixedSalary);
statement.Items.Add(kpi);
statement.Items.Add(other);

Console.WriteLine(statement.Employee.FullName);
Console.WriteLine(statement.Items.Count);
Console.WriteLine(statement.Total());

var employees = new Dictionary<string, Employee>();
employees[e1.PersonnelNo] = e1;
employees[e2.PersonnelNo] = e2;

if (employees.TryGetValue("2525", out var found))
{
    Console.WriteLine(found.FullName);
}
else
{
    Console.WriteLine("کارمند پیدا نشد");
}

if (employees.TryGetValue("9999", out var found2))
{
    Console.WriteLine(found2.FullName);
}
else
{
    Console.WriteLine("کارمند پیدا نشد");
}
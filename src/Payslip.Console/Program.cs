// static decimal SumAmounts(decimal []a)
// {
//     decimal sum = 0m;
//     for(int i = 0 ; i < a.Length ; i++)
//     sum += a[i];
//     return sum;
// }
// static decimal ToUsdt( decimal r , decimal n)
// {
//     decimal taghsim = 0m;
//     taghsim = r/ n;
//     return taghsim;
// }
// decimal[] amounts = { 100_000_000m, 150_000_000m, 50_000_000m };
// decimal mablagh = SumAmounts(amounts);

// decimal Teter = ToUsdt(mablagh , 1_875_000m);
// Console.WriteLine(Teter);

var e1 = new Employee("Mohammad_Rafiei", "2525");

var e2 = new Employee("ali_rezaiei", "2325");
e2.Deactivate();

// Console.WriteLine($"{e1.FullName}- {e1.PersonnelNo} - {e1.IsActive}");
// Console.WriteLine($"{e2.FullName}-{e2.PersonnelNo}-{e2.IsActive}");


var fixedSalary = new PaymentItem("حقوق ثابت" , 150_000_000m);
var kpi = new PaymentItem("KPI" , 100_000_000m);
var other = new PaymentItem("سایر پرداخت‌ها" , 50_000_000m);


// Console.WriteLine(fixedSalary);
// Console.WriteLine(kpi);
// Console.WriteLine(other);

var statement = new Statement(e1);

statement.Items.Add(fixedSalary);
statement.Items.Add(kpi);
statement.Items.Add(other);

// Console.WriteLine(statement.Employee.FullName);
// Console.WriteLine(statement.Items.Count);
// Console.WriteLine(statement.Total());


var employee = new Dictionary< string , Employee>();

employee[e1.PersonnelNo] = e1;
employee[e2.PersonnelNo] = e2;
    if (employee.TryGetValue("2525" , out var found)){
        Console.WriteLine(found.FullName);
    }
        else
        {
                    Console.WriteLine("پزینده پیدا نشد");

        }

if (employee.TryGetValue("9999" , out var found2)){
        Console.WriteLine(found2.FullName);
    }
        else
        {
                    Console.WriteLine("پزینده پیدا نشد");

        }






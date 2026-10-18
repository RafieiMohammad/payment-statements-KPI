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
e2.IsActive = false;

Console.WriteLine($"{e1.FullName}- {e1.PersonnelNo} - {e1.IsActive}");
Console.WriteLine($"{e2.FullName}-{e2.PersonnelNo}-{e2.IsActive}");

// var e3 = new Employee();
// e3.FullName = "test";
// Console.WriteLine($"{e3.FullName} - {e3.PersonnelNo} - {e3.IsActive}");


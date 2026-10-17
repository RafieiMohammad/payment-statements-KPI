static decimal SumAmounts(decimal []a)
{
    decimal sum = 0m;
    for(int i = 0 ; i < a.Length ; i++)
    sum += a[i];
    return sum;
}
static decimal ToUsdt( decimal r , decimal n)
{
    decimal taghsim = 0m;
    taghsim = r/ n;
    return taghsim;
}
decimal[] amounts = { 100_000_000m, 150_000_000m, 50_000_000m };
decimal mablagh = SumAmounts(amounts);

decimal Teter = ToUsdt(mablagh , 1_875_000m);
Console.WriteLine(Teter);
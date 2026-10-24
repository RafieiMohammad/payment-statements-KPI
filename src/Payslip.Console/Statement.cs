public class Statement
{
    public  Employee Employee { get ; }

    public List<PaymentItem> Items {get ; } = new();
    public Statement(Employee employee)
    {
        Employee = employee;
    }

    public decimal Total()
    {
        decimal sum = 0m;
        foreach( var item in Items)
        {
            sum += item.Amount;
        }
        return sum;

    }

}
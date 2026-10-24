public class StatementTests
{
    [Fact]
    public void Total_SumsAllItems()
    {

        var employee = new Employee("Test User", "1001");

        var statement = new Statement(employee);

        statement.Items.Add(new PaymentItem("حقوق ثابت", 150_000_000m));
        statement.Items.Add(new PaymentItem("پرداخت ثابت", 100_000_000m));
        statement.Items.Add(new PaymentItem("kpi", 50_000_000m));

        decimal total = statement.Total();

        Assert.Equal(300_000_000m, total);




    }
}
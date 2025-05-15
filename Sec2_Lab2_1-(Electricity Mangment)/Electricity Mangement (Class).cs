namespace ElectricityMangement;

public class ElectricityBill
{
    ulong ConsumerNo { get; set; }
    string ConsumerName { get; set; }
    decimal PMonth { get; set; }
    decimal CMonth { get; set; }
    string EB { get; set; }
    public ElectricityBill(ulong ConsumerNo, string ConsumerName, decimal PMonth, decimal CMonth, string EB)
    {
        this.ConsumerName = ConsumerName;
        this.CMonth = CMonth;
        this.PMonth = PMonth;
        this.EB = EB;
        this.ConsumerNo = ConsumerNo;
    }
    public decimal CalculateBill()
    {
        decimal Count = CMonth - PMonth;
        if (EB.ToLower() == "domestic")
        {
            return (Count <= 100) ? 100 * 1
            : (Count <= 200) ? 100 * 1 + (Count - 100) * 2.5m
            : (Count <= 500) ? 100 * 1 + 100 * 2.5m + (Count - 200) * 4
            : 100 * 1 + 100 * 2.5m + 300 * 4 + (Count - 500) * 6;
        }
        else if (EB.ToLower() == "commercial")
        {
            return (Count <= 100) ? 100 * 2
            : (Count <= 200) ? 100 * 2 + (Count - 100) * 4.5m
            : (Count <= 500) ? 100 * 2 + 100 * 4.5m + (Count - 200) * 6
            : 100 * 2 + 100 * 4.5m + 300 * 6 + (Count - 500) * 7;
        }
        else
        {
            Console.WriteLine("invaild connection type.");
            return 0;
        }
    }
    public void DispalyInfo()
    {
        Console.WriteLine($"\tThe info");
        Console.WriteLine($"The Number : {ConsumerNo}");
        Console.WriteLine($"The Name : {ConsumerName}");
        Console.WriteLine($"The Previos Month : {PMonth}");
        Console.WriteLine($"The Current Month : {CMonth}");
        Console.WriteLine($"The Bill : {CalculateBill()}");
    }

}

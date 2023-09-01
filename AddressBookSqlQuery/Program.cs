using AddressBookSystem_ADO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" AddressBookSystem ");
        AddressBookOperation Operation = new AddressBookOperation();
        Operation.CreateingTable();
    }
}

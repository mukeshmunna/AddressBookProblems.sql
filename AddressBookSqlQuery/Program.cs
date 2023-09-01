using AddressBookSystem_ADO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" AddressBookSystem ");
        AddressBookOperation Operation = new AddressBookOperation();
        AddressModel data = new AddressModel()
        {
            FirstName = "Mukesh",
            LastName = "Mukkara",
            Address = "sullurpeta",
            City = "thirupathi",
            State = "Andhrapradhesh",
            Zip = 524121,
            PhoneNumber = "8765432190",
            Email = "abcd@gmail.com",

        };
        Operation.exuctedorNot(Operation.AddEmployee(data));
    }
}

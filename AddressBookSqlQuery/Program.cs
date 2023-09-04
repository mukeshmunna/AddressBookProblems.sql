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
            Address = "Sullurpeta",
            City = "thirupathi",
            State = "Andhrapradhesh",
            Zip = 524121,
            PhoneNumber = "9876543210",
            Email = "mukesh@gmail.com",

        };
        AddressModel edit = new AddressModel()
        {
            FirstName = "Mukesh",
            LastName = "Mukkara",
            Address = "Sullurpeta",
            City = "thirupathi",
            State = "Andhrapradhesh",
            Zip = 524121,
            PhoneNumber = "9876543210",
            Email = "mukesh@gmail.com",

        };

        AddressModel delete = new AddressModel()
        {
            FirstName = "hello",
        };

        string citysearch = "processor";
        string statesearch = "Hardware";
        Operation.GetAllEmployeeDetailsByState(statesearch);
        Operation.DisplayAllDataByState(statesearch);

    }
}

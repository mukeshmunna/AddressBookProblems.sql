using AddressBookSystem_ADO;
using System.Threading;

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
        Operation.PersonAsTwoRelation("kanha", "Profession");

        //MultiThreading concept
        List<AddressModel> list = new List<AddressModel>();
        list.Add(new AddressModel()
        {
            FirstName = "hello",
            LastName = "haiii",
            Address = "abcdefghij",
            City = "hellohii",
            State = "Hiihello",
            Zip = 567432,
            PhoneNumber = "1234567890",
            Email = "abcd@gmail.com",
            Relation = "Others"
        });
        list.Add(new AddressModel()
        {
            FirstName = "hello",
            LastName = "haiii",
            Address = "abcdefghij",
            City = "hellohii",
            State = "Hiihello",
            Zip = 567432,
            PhoneNumber = "1234567890",
            Email = "abcd@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "hello",
            LastName = "haiii",
            Address = "abcdefghij",
            City = "hellohii",
            State = "Hiihello",
            Zip = 567432,
            PhoneNumber = "1234567890",
            Email = "abcd@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "hello",
            LastName = "haiii",
            Address = "abcdefghij",
            City = "hellohii",
            State = "Hiihello",
            Zip = 567432,
            PhoneNumber = "1234567890",
            Email = "abcd@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "hello",
            LastName = "haiii",
            Address = "abcdefghij",
            City = "hellohii",
            State = "Hiihello",
            Zip = 567432,
            PhoneNumber = "1234567890",
            Email = "abcd@gmail.com",
            Relation = "Others"
        });
        WithAndWithOutThread thread = new WithAndWithOutThread();


    }
}

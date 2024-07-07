public class Contact
{
    protected string? firstName;
    protected string? lastName;
    protected string? phoneNumber;
    protected string? email;

    public virtual void PrintDetails()
    {
        Console.WriteLine(firstName + " " + lastName);
        Console.WriteLine($"\tPhone: {phoneNumber}");
        Console.WriteLine($"\tEmail: {email}");
        Console.WriteLine("\n");
    }

    public Contact(string fName, string lName, string pNumber, string eMail)
    {
        firstName = fName;
        lastName = lName;
        phoneNumber = pNumber;
        email = eMail;
    }

    public string? GetFirstName()
    {
        return firstName;
    }

    public string? GetLastName()
    {
        return lastName;
    }

    public string? GetPhoneNumber()
    {
        return phoneNumber;
    }

    public string? GetEmail()
    {
        return email;
    }
}
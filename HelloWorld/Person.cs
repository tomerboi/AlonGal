public class Person
{
    public Name FullName { get; set; }
    public Address Address { get; set; }

    public Person(Name name, Address address)
    {
        FullName = name;
        Address = address;
    }
}

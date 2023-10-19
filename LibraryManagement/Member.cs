public class Member
{
    // Properties
    public string MemberID{get; set;}
    public string Name { get; set; }
    public string Age { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }

    // Constructor
    public Member(string MemberID, string name, string age, string contactNumber, string email)
    {
        this.MemberID = MemberID;
        this.Name = name;
        this.Age = age;
        this.ContactNumber = contactNumber;
        this.Email = email;
    }
}

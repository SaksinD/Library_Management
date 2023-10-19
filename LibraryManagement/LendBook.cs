public class LendBook{
    // Properties
    public string BookID {get; set;}
    public string MemberID { get; set; }
    public DateTime LendDate{get;set;}
    public DateTime ExpectedReturnDate{get;set;}
    public bool Returned{get; set;}
    public bool FinePaid { get; set; }

    // Constructor
    public LendBook(string BookID, string MemberID, DateTime LendDate, DateTime ExpectedReturnDate, bool Returned, bool FinePaid)
    {
        this.BookID = BookID;
        this.MemberID = MemberID;
        this.LendDate = LendDate;
        this.ExpectedReturnDate = ExpectedReturnDate;
        this.Returned = Returned;
        this.FinePaid = FinePaid;
    }
}
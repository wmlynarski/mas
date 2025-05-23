namespace mas_mp1
{
	public class Membership
	{
		public Borrower Borrower { get; set; }
		public Library Library { get; set; }
		public DateTime Since { get; set; }
		public Membership(Borrower borrower, Library library, DateTime since)
		{
			Borrower = borrower;
			Library = library;
			Since = since;
		}
	}
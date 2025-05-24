namespace mas_mp1
{
	public class Membership
	{
		//Klasa asocjacji
		public Borrower Borrower { get; }
		public Library Library { get; }
		public DateTime Since { get; set; }
		public Membership(Borrower borrower, Library library, DateTime since)
		{
			Borrower = borrower ?? throw new ArgumentNullException(nameof(borrower));
			Library = library ?? throw new ArgumentNullException(nameof(library));
			Since = since;
			borrower.Memberships.Add(this);
			library.Memberships.Add(this);
		}
	}
}
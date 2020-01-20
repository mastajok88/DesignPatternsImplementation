namespace DoFacatedBuilder
{
    public class Person
    {
        public string CompanyName { get; set; }

        public string Position { get; set; }

        public int AnnualIncome { get; set; }

        public string StreetAddress { get; set; }

        public string Postcode { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"{nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}, {nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}";
        }
    }
}
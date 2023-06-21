namespace PenaltyCalculationApp.Datas
{
    public class Holiday
    {
        public int Id { get; set; } //HolidayId For Db
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public int CountryId { get; set; }// This and underlines are added for one to mant releations beteem holiday and Country. 
        public Country Country { get; set; }
    }
}

namespace PYP_DynamicPartialView.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}

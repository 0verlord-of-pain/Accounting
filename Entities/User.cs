namespace Accounting.Entities
{
    public class User
    {
        public int userId { get; set; }
        public int nameId { get; set; }
        public int lastNameId { get; set; }
        public int fatherNameId { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public int departmentId { get; set; }
        public int positionId { get; set; }
        public int salaryId { get; set; }
        public int premiumFactorId { get; set; }
    }
}
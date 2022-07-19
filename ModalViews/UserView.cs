using System.ComponentModel;
using Accounting.Enums;

namespace Accounting.ModalViews
{
    public class UserView
    {
        [DisplayName("Номер")]
        public int UserId { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [DisplayName("Отчество")]
        public string FatherName { get; set; }
        [DisplayName("Отдел")]
        public string Department { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        [DisplayName("Ставка")]
        public decimal Salary { get; set; }
        [DisplayName("Оценка")]
        public PremiumType PremiumType { get; set; }
        [DisplayName("Премия")]
        public decimal Premium { get; set; }
    }
}
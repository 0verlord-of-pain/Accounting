using System.ComponentModel;

namespace Accounting.ModalViews
{
    public class PayoutView
    {
        [DisplayName("Отдел")]
        public string Department { get; set; }
        [DisplayName("Сумма")]
        public decimal Money { get; set; }
    }
}

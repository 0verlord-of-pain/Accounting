using System.ComponentModel;

namespace Accounting.ModalViews
{
    public class UserInfoView : UserView
    {
        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }
    }
}
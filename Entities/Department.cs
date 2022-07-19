using System.ComponentModel;

namespace Accounting.Entities
{
    public class Department
    {
        [DisplayName("Номер")]
        public int departmentId { get; set; }
        [DisplayName("Название отдела")]
        public string name { get; set; }

        public static Department Create(string name)
        {
            return new Department
            {
                name = name
            };
        }
    }
}
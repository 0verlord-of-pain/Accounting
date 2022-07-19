using System.ComponentModel;

namespace Accounting.Entities
{
    public class Position
    {
        [DisplayName("Номер")]
        public int positionId { get; set; }
        [DisplayName("Название должности")]
        public string name { get; set; }

        public static Position Create(string name)
        {
            return new Position
            {
                name = name
            };
        }
    }
}
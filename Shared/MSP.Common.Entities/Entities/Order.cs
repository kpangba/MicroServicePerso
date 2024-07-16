using MSP.Common.Entities.ValueObjects;

namespace MSP.Common.Entities.Entities
{
    public class Order: EntityBase
    {
        public OrderDetails OrderDetails { get; set; }
    }
}

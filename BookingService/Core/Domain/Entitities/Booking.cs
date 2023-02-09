using Domain.Enums;

namespace Domain.Entitities
{
    public class Booking
    {
        public Guid? Id { get; set;}
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        private Status Status { get; set; }
        public Status GetCurretStaus { get { return Status; } }
    }
}

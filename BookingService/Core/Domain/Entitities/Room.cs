using Domain.ValueObjects;

namespace Domain.Entitities
{
    public class Room
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool InMaintenance { get; set; }
        public bool HasGuest { get { return true; } }
        public Price Price { get; set; }
        public bool IsAvalilable
        {
            get { return InMaintenance != true && HasGuest != true; }
        }
    }
}

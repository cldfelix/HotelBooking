using Domain.Enums;

namespace Domain.Entitities
{
    public class Booking
    {
        public Booking()
        {
            Status= Status.Created;
        }
        public Guid? Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        private Status Status { get; set; }
        public Status GetCurretStaus { get { return Status; } }

        public void ChangeState(Actions action)
        {
            Status = (Status, action) switch
            {
                (Status.Created, Actions.Pay) => Status.Paid,
                (Status.Created, Actions.Cancel) => Status.Canceled,
                (Status.Paid, Actions.Finish) => Status.Finished,
                (Status.Paid, Actions.Refound) => Status.Refounded,
                (Status.Canceled, Actions.Reopen) => Status.Created,
                _ => Status
            };
        }
    }
}

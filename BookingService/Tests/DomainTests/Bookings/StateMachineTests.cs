using Domain.Entitities;
using Domain.Enums;
using NUnit.Framework;


namespace DomainTests.Bookings
{
    public class StateMachineTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void DeveReceberStatusCreatedParaBookingCreated()
        {
            var b = new Booking();
            Assert.That(b.GetCurretStaus, Is.EqualTo(Status.Created));

        }

        [Test]
        public void DeveSetarStatusParaPagoParaBookingComStatusCreated()
        {
           var b = new Booking();
            b.ChangeState(Actions.Pay);
            Assert.That(b.GetCurretStaus, Is.EqualTo(Status.Paid));

        }

        [Test]
        public void DeveSetarStatusParaCancelParaBookingComStatusCreated()
        {
            var b = new Booking();
            b.ChangeState(Actions.Cancel);
            Assert.That(b.GetCurretStaus, Is.EqualTo(Status.Canceled));
        }



        [Test]
        public void DeveSetarStatusParaFinishedParaBookingComStatusPaid()
        {
            var b = new Booking();
            b.ChangeState(Actions.Pay);
            b.ChangeState(Actions.Finish);
            Assert.That(b.GetCurretStaus, Is.EqualTo(Status.Finished));

        }

        [Test]
        public void DeveSetarStatusParaRefoundParaBookingComStatusPaid()
        {
            var b = new Booking();
            b.ChangeState(Actions.Pay);
            b.ChangeState(Actions.Refound);
            Assert.That(b.GetCurretStaus, Is.EqualTo(Status.Refounded));
        }

        [Test]
        public void DeveSetarStatusParaReopenParaBookingComStatusCanceled()
        {
            var b = new Booking();
            b.ChangeState(Actions.Cancel);
            b.ChangeState(Actions.Reopen);
            Assert.That(b.GetCurretStaus, Is.EqualTo(Status.Created));
        }
    }
}

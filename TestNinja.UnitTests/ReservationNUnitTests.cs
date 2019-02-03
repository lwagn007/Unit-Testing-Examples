using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    // Using the NUnit Framework
    // What should you test?
    // Test queries and commands
    // Don't test language features, properties, or third party code, only test your code

    // Should name the test projects by name of project they are testing example: TestNinja.UnitTests
    // Should have a test class for each class you are testing. 
    // Test Methods should be named in this convention [MethodName]_[Scenario]_[Expected]
    // Amount of TestMethods are determined by method execution paths
    [TestFixture]
    public class ReservationNUnitTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            // Where we initialize our objects
            var reservation = new Reservation();

            // Act
            // We are going to act on the object. What method we are going to test
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            // Verify that result is correct
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdminNorMadeReservation_ReturnsFalse()
        {
            // Arrange
            var user = new User { IsAdmin = false };
            var reservation = new Reservation { };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result == false);
        }
    }
}

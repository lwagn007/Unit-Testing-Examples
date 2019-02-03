using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    // Using the MSTest Framework
    // No Logic in Unit Tests
    // Tests should be clean, readable, maintainable, and isolated(isolated meaning that each test should run with a clean fresh state as if it is the only test in the project)
    // Tests should not be to specific or to general
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
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
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminNorMadeReservation_ReturnsFalse()
        {
            // Arrange
            var user = new User { IsAdmin = false };
            var reservation = new Reservation { };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

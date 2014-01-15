using System;
using ITI.Teaching.Interface.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ITI.Teaching.Interface.Tests
{
    [TestClass]
    public class NotifierTests
    {
        private INotifier theNotifier;
        private Worker theWorker;

        [TestInitialize]
        public void Init()
        {
            theWorker = new Worker();
        }

        [TestMethod]
        public void TestSmsNotifier()
        {
            // Arrange
            string address = "123-4567";
            string message = "Want to go to the mall";
            string expected = "SMS:123-4567|Want to go to the mall";

            theNotifier = new SmsNotifier();
            theNotifier.Address = address;
            theNotifier.Message = message;
            
            // Act
            string actual = theWorker.Execute(theNotifier);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmailNotifier()
        {
            // Arrange
            string address = "123-4567";
            string message = "I like cake";
            string expected = "EMAIL:123-4567|I like cake";

            theNotifier = new EmailNotifier();
            theNotifier.Address = address;
            theNotifier.Message = message;

            // Act
            string actual = theWorker.Execute(theNotifier);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

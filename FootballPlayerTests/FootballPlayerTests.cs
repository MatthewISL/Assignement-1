using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FootballPlayer.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        FootballPlayer badPlayer = new FootballPlayer() { Id = -1, Name = "B", Age = 13, ShirtNumber = 765 };
        FootballPlayer goodPlayer = new FootballPlayer() { Id = 3, Name = "George", Age = 24, ShirtNumber = 47 };

        [TestMethod()]
        public void ValidateIdTest()
        {
            goodPlayer.ValidateId();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => badPlayer.ValidateId());

            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => goodPlayer.ValidateId());
        }
        [TestMethod()]
        public void ValidateName()
        {
            goodPlayer.ValidateName();
            FootballPlayer player1 = new FootballPlayer() { Id = 7, Name = null, Age = 32, ShirtNumber = 39 };
            Assert.ThrowsException<ArgumentNullException>(() => player1.ValidateName());

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => badPlayer.ValidateName());

            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => goodPlayer.ValidateName());

        }
        [TestMethod()]
        public void ValidateAge()
        {
            goodPlayer.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => badPlayer.ValidateAge());

            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => goodPlayer.ValidateAge());
        }
        [TestMethod()]
        public void ValidateShirtNumber()
        {
            goodPlayer.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => badPlayer.ValidateShirtNumber());

            FootballPlayer player2 = new FootballPlayer() { Id = 4, Name = "Bob", Age = 43, ShirtNumber = -3 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player2.ValidateShirtNumber());

            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => goodPlayer.ValidateAge());

        }
    }
}
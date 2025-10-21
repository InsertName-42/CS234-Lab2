using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;
using MMABooksDBClasses;

using MySql.Data.MySqlClient;
using NUnit.Framework.Legacy;

namespace MMABooksTests
{
    [TestFixture]
    public class StateDBTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void TestGetStates()
        {
            List<State> states = StateDB.GetStates();
            ClassicAssert.AreEqual(53, states.Count);
            ClassicAssert.AreEqual("Alaska", states[0].StateName);
        }

        [Test]
        public void TestGetStatesDBUnavailable()
        {
            Assert.Throws<MySqlException>(() => StateDB.GetStates());
        }
    }
}

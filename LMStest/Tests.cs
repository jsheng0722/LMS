namespace LMStest
{
    using System;
    using System.Data;
    using System.Reflection;
    using LMS;
    using NUnit.Framework;

    /// <summary>
    /// Test for LMS.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// test setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test reflection.
        /// </summary>
        [Test]
        public void TestReflection()
        {
            TestsHelper th = new TestsHelper();
            Type type = typeof(TestsHelper);
            BindingFlags instance = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo info = type.GetField("id", instance);
            info.SetValue(th, "try");
            var name = info.GetValue(th);
            Assert.AreEqual(name, "try");
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeAndAagram;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "anna";
            Assert.AreEqual(Res.Palindrome, Solution.IsPalindromeOrAnaPalidrome(str));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string str = "aaaaaaaa";
            Assert.AreEqual(Res.Palindrome, Solution.IsPalindromeOrAnaPalidrome(str));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string str = "aaaaaaaab";
            Assert.AreEqual(Res.AnaPalindrome, Solution.IsPalindromeOrAnaPalidrome(str));
        }
        [TestMethod]
        public void TestMethod4()
        {
            string str = "caaaaaaaab";
            Assert.AreEqual(Res.None, Solution.IsPalindromeOrAnaPalidrome(str));
        }
        [TestMethod]
        public void TestMethod5()
        {
            string str = "donotbobtonod";
            Assert.AreEqual(Res.Palindrome, Solution.IsPalindromeOrAnaPalidrome(str));
        }

        [TestMethod]
        public void TestMethod6()
        {
            string str = "owefhijpfwai";
            Assert.AreEqual(Res.None, Solution.IsPalindromeOrAnaPalidrome(str));
        }

        [TestMethod]
        public void TestMethod7()
        {
            string str = "igdedgide";
            Assert.AreEqual(Res.AnaPalindrome, Solution.IsPalindromeOrAnaPalidrome(str));
        }

        [TestMethod]
        public void TestMethod10()
        {
            string str = "caaaaaaaabd";
            Assert.AreEqual(Res.None, Solution.IsPalindromeOrAnaPalidrome(str));
        }
    }
}

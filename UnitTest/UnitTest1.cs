using Resheto;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool authorized = true;
            string login = "user";
            string password = "123";
            DBManager dBManager = new
                DBManager(("D:\\DataBase\\users.db"));
            Assert.AreEqual(authorized, dBManager.CheckUser(login, password));
        }
        [TestMethod]
        public void AuthorizationUnSuccessfull()
        {
            bool authorized = false;
            string login = "APFsfpgaq";
            string password = "1246765157ahhjt";
            DBManager dBManager = new
                DBManager("D:\\DataBase\\users.db");
            Assert.AreEqual(authorized, dBManager.CheckUser(login, password));
        }
        [TestMethod]
        public void RegistrationSuccessful()
        {
            bool registered = true;
            string login = "nikita2";
            string password = "024159";
            DBManager dBManager = new DBManager("D:\\DataBase\\users.db");
            Assert.AreEqual(registered, dBManager.AddUser(login, password));
        }
        public void Find10()
        {
            var n = 10;
            string output = "2, 3, 5, 7";
            Form1 form = new Form1();
            var n1 = Convert.ToUInt32(n);
            var primeNumbers = form.SieveEratosthenes(n1);
            string reqv = string.Join(", ", primeNumbers);
            Assert.AreEqual(output, reqv);
        }
        [TestMethod]
        public void Find140()
        {
            var n = 40;
            string output = "2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37";
            Form1 form = new Form1();
            var n1 = Convert.ToUInt32(n);
            var primeNumbers = form.SieveEratosthenes(n1);
            string reqv = string.Join(", ", primeNumbers);
            Assert.AreEqual(output, reqv);
        }
    }
}
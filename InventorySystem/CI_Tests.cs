using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InventorySystem
{
    class CI_Tests
    {
        private SqlConnection _TestDatabase_conn;

        private SqlConnection _InventoryDatabase_conn;
  
        Int32 ExpectedCustomersCount;

        Int32 ExpectedLoginsCount;

        Int32 ExpectedVendorsCount;

        Int32 ExpectedProductsCount;

        Int32 ExpectedStocksCount;

        [SetUp]
        public void Setup()
        {
            _TestDatabase_conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CI_TestDataBase.mdf;Integrated Security=True;Connect Timeout=30");

            _InventoryDatabase_conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

            _TestDatabase_conn.Open();

            SqlCommand TestCommandCustomer = new SqlCommand();
            TestCommandCustomer.Connection = _TestDatabase_conn;
            TestCommandCustomer.CommandText = "SELECT COUNT(*) FROM Test_Customers";
            ExpectedCustomersCount = (Int32)TestCommandCustomer.ExecuteScalar();

            SqlCommand TestCommandLogin = new SqlCommand();
            TestCommandLogin.Connection = _TestDatabase_conn;
            TestCommandLogin.CommandText = "SELECT COUNT(*) FROM Test_Login";
            ExpectedLoginsCount = (Int32)TestCommandLogin.ExecuteScalar();

            SqlCommand TestCommandProducts = new SqlCommand();
            TestCommandProducts.Connection = _TestDatabase_conn;
            TestCommandProducts.CommandText = "SELECT COUNT(*) FROM Test_Products";
            ExpectedProductsCount = (Int32)TestCommandProducts.ExecuteScalar();

            SqlCommand TestCommandVendors = new SqlCommand();
            TestCommandVendors.Connection = _TestDatabase_conn;
            TestCommandVendors.CommandText = "SELECT COUNT(*) FROM Test_Vendors";
            ExpectedVendorsCount = (Int32)TestCommandVendors.ExecuteScalar();

            SqlCommand TestCommandStocks = new SqlCommand();
            TestCommandStocks.Connection = _TestDatabase_conn;
            TestCommandStocks.CommandText = "SELECT COUNT(*) FROM Test_Stocks";
            ExpectedStocksCount = (Int32)TestCommandStocks.ExecuteScalar();


            _TestDatabase_conn.Close();
        }

        [Test]
        public void TestCustomersCountInTable()
        {
            _InventoryDatabase_conn.Open();

            SqlCommand TestCommandCustomer = new SqlCommand();
            TestCommandCustomer.CommandText = "SELECT COUNT(*) FROM customers";
            TestCommandCustomer.Connection = _InventoryDatabase_conn;
            Int32 ActualCustomersCount = (Int32)TestCommandCustomer.ExecuteScalar();
            

            _InventoryDatabase_conn.Close();


            Assert.AreEqual(ExpectedCustomersCount, ActualCustomersCount);

        }
        [Test]
        public void TestLoginTable()
        {
            _InventoryDatabase_conn.Open();

            SqlCommand TestCommandLogin = new SqlCommand();
            TestCommandLogin.CommandText = "SELECT COUNT(*) FROM login";
            TestCommandLogin.Connection = _InventoryDatabase_conn;
            Int32 ActualloginsCount = (Int32)TestCommandLogin.ExecuteScalar();


            _InventoryDatabase_conn.Close();


            Assert.AreEqual(ExpectedLoginsCount, ActualloginsCount);

        }

        [Test]
        public void TestProductsTable()
        {
            _InventoryDatabase_conn.Open();

            SqlCommand TestCommandProducts = new SqlCommand();
            TestCommandProducts.CommandText = "SELECT COUNT(*) FROM Products";
            TestCommandProducts.Connection = _InventoryDatabase_conn;
            Int32 ActualProductsCount = (Int32)TestCommandProducts.ExecuteScalar();


            _InventoryDatabase_conn.Close();


            Assert.AreEqual(ExpectedProductsCount, ActualProductsCount);
        }

        [Test]
        public void TestVendorsTable()
        {
            _InventoryDatabase_conn.Open();

            SqlCommand TestCommandVendors = new SqlCommand();
            TestCommandVendors.CommandText = "SELECT COUNT(*) FROM vendors";
            TestCommandVendors.Connection = _InventoryDatabase_conn;
            Int32 ActualVendorsCount = (Int32)TestCommandVendors.ExecuteScalar();


            _InventoryDatabase_conn.Close();


            Assert.AreEqual(ExpectedVendorsCount, ActualVendorsCount);
        }

        [Test]
        public void TestStocksTable()
        {
            _InventoryDatabase_conn.Open();

            SqlCommand TestCommandStocks = new SqlCommand();
            TestCommandStocks.CommandText = "SELECT COUNT(*) FROM Stocks";
            TestCommandStocks.Connection = _InventoryDatabase_conn;
            Int32 ActualStocksCount = (Int32)TestCommandStocks.ExecuteScalar();


            _InventoryDatabase_conn.Close();


            Assert.AreEqual(ExpectedStocksCount, ActualStocksCount);
        }

    }
}

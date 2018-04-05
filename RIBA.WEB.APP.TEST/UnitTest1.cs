using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RIBA_BASE_Library;

namespace RIBA.WEB.APP.TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Getdiscount_If_Quantity_Less_Or_Equal_10()
        {
            //item.price = cal.CalculateDiscount(item.price, item.quantity);
            //Arrange
            Order obj = new Order();
            CalculateUtil cal = new CalculateUtil();
            obj.quantity = 5;
            //Act
            decimal result = cal.CalculateDiscount(obj.price, obj.quantity);
            //Assert
            Assert.AreEqual(Convert.ToDecimal(5.0), result);

        }
        [TestMethod]
        public void Getdiscount_If_Quantity_More_than_10_Less_Than_20()
        {
            //item.price = cal.CalculateDiscount(item.price, item.quantity);
            //Arrange
            Order obj = new Order();
            CalculateUtil cal = new CalculateUtil();
            obj.quantity = 15;
            //Act
            decimal result = cal.CalculateDiscount(obj.price, obj.quantity);
            //Assert
            Assert.AreEqual(Convert.ToDecimal(14.25), result);
            }
        [TestMethod]
        public void Getdiscount_If_Quantity_More_than_20_Less_Than_30()
        {
            //item.price = cal.CalculateDiscount(item.price, item.quantity);
            //Arrange
            Order obj = new Order();
            CalculateUtil cal = new CalculateUtil();
            obj.quantity = 25;
            //Act
            decimal result = cal.CalculateDiscount(obj.price, obj.quantity);
            //Assert
            Assert.AreEqual(Convert.ToDecimal(22.5), result);
        }

        [TestMethod]
        public void Getdiscount_If_Quantity_More_than_30()
        {
            //item.price = cal.CalculateDiscount(item.price, item.quantity);
            //Arrange
            Order obj = new Order();
            CalculateUtil cal = new CalculateUtil();
            obj.quantity = 40;
            //Act
            decimal result = cal.CalculateDiscount(obj.price, obj.quantity);
            //Assert
            Assert.AreEqual(Convert.ToDecimal(33.5), result);
        }


    }
}

using System;
using Xunit;

namespace CSharpNewfeatures
{
    public class CsharpFeaturesTest
    {
        [Fact]
        public void RecordValueEquality_AssertTrue()
        {
            //Arrange
            var employee1 = new Employee
            {
                Id = 1,
                Name = "abc",
                City = "xyz",
                State = "pqr"
            };

            var employee2 = new Employee
            {
                Id = 1,
                Name = "abc",
                City = "xyz",
                State = "pqr"
            };

            //Act

            //Assert
            Assert.True(employee1.Equals(employee2));
            Assert.True(employee1 == employee2);
            Assert.False(ReferenceEquals(employee1, employee2));
        }

        [Fact]
        public void RecordImmutable_ReturnTrue()
        {
            // var employee = new Employee
            // {
            //     City = "äbc"
            // };
            //// employee2.City = "xyz";
            ///
            XyzOrder xyzOrder = new(id:1,orderDetails:"abc",price:1);

            //Below line throws an error as setter is assigned to init.
            //xyzOrder.price = 1;

            //Below immutable property can be changed using with keyword
            xyzOrder = xyzOrder with { id = 2, orderDetails = "xyz" };

            Assert.True(xyzOrder.id == 2 && xyzOrder.orderDetails == "xyz");
        }

        [Fact]
        public void XyzOrder_Return()
        {
            Order xyzOrder = new XyzOrder(3, "abc", 10);
            var (id, orderDetails) = xyzOrder;
        }
    }
}

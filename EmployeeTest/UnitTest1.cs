using NUnit.Framework;
using EmployeePayRollADO;
using System;
using EmployeePayRollADO;

namespace EmployeeTest
{
    public class Tests
    {
        Employee employee;
        EmployeeDetail employeeDetail;
        [SetUp]
        public void Setup()
        {
            employee = new Employee();
            employeeDetail = new EmployeeDetail();
        }
        //<summary>
        //TC 2 : Insert Details
        //</summary>
        [Test]
        public void AddingEmployeeDetails()
        {
            int expected = 1;
            employee.Name = "Hari";
            employee.StartDate = Convert.ToDateTime("2021-10-11");
            employee.Gender = "M";
            employee.PhoneNumber = 9678983451;
            employee.Address = "Valsad";
            employee.Department = "comp";
            employee.BasicPay = 43300;
            employee.Deduction = 5400;
            employee.TaxablePay = 1000;
            employee.IncomeTax = 1200;
            employee.NetPay = 25000;
            var actual = employeeDetail.InsertEmployeeData(employee);
            Assert.AreEqual(expected, actual);
        }
    }
}
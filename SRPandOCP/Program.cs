using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    /// <summary>
    /// This namespace describes the Single Responsibilty Principle (SRP)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Report Generated");
        }
    }
    public class Employee
    {

        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoEmployeeTable(Employee em)
        {
            try
            {
                // to create an exception
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            // Insert into employee table.
            return true;
        }

    }
    public class ReportGeneration
    {
        /// <summary>
        /// Method to compile generated report
        /// </summary>
        /// <param name="em"></param>
        public void CompileReport(List<ReportGeneration> reports)
        {
            // Compile all EmployeeData Reports.
        }
    }
}



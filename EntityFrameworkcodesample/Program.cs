using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkcodesample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperation o = new EmployeeOperation();
            o.InsertData();
        }
    }
    public class EmployeeOperation
    {
        public void InsertData()
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "praveen";
            emp.Address = "Albany";
            EmployeeContext op = new EmployeeContext();
            op.Employees.Add(emp);
            op.SaveChanges();
        }
        //public void UpdateData()
        //{
        //    Employee emp = new Employee();
        
        //

        //}
        public void add()
        {
            //added sample method
        }
    }
}

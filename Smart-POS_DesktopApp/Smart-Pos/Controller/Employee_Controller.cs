using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_Pos;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
using Smart_Pos.Class;
using System.Web.Http;
using System.IO;
using System.Web;

namespace Smart_Pos.Controller
{
    class Employee_Controller
    {
        //Get all Employees
        public IEnumerable<Employee> getEmp() {
            IEnumerable<Employee> emp;
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Employees").Result;
            emp = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
            return emp;
        }

        [HttpPost]
        public string addOrEditEmp(Employee emp)
        {
            if (emp.EmpId == 0)
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PostAsJsonAsync("Employees", emp).Result;
                return ("Employee Record Added Successfully");
            }
            else
            {
                HttpResponseMessage response = GlobalHttp.WebApiClient.PutAsJsonAsync("Employees/" + emp.EmpId, emp).Result;
                return ("Employee Record Updated Successfully");
            }
        }

        public Employee get(int id = 0)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.GetAsync("Employees/" + id.ToString()).Result;
            Employee emp = response.Content.ReadAsAsync<Employee>().Result;
            return emp;
        }

        public  string deleteEmp(int id)
        {
            HttpResponseMessage response = GlobalHttp.WebApiClient.DeleteAsync("Employees/" + id.ToString()).Result;
            return ("Employee Record Deleted Successfully");
        }

    }
}

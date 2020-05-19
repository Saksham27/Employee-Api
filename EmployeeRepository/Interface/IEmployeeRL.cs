using EmployeeCommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRepository.Interface
{
    public interface IEmployeeRL
    {
        //Interface method for Employee Registration
        int RegisterEmployee(EmployeeModel model);
        //Interface method for Employee Login
        int EmployeeLogin(LoginModel loginData);
        //Interface method for delete Employee detail
        int DeleteEmployee(EmployeeId Data);
        //Interface method for update Employee detail
        int UpdateEmployeeDetails(UpdateModel data);
        //Interface method for get Employee detail 
        IEnumerable<EmployeeModel> GetEmployeeDetails(string inputData);
        //Interface method for get Employee detail 
        IEnumerable<EmployeeModel> GetEmployeeDetailsWithId(EmployeeId inputData);
        //Interface method for get all Employee detail
        IEnumerable<EmployeeModel> GetAllEmployeeDetails();
    }
}

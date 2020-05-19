using EmployeeCommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessLayer.Interface
{
    public interface IEmployeeBL
    {
        ResponseMessage GetAllEmployeeDetails();
        ResponseMessage RegisterEmployee(EmployeeModel model);
        ResponseMessage EmployeeLoginBL(LoginModel loginData);
        ResponseMessage GetEmployeeDetails(string inputData);
        ResponseMessage GetEmployeeDetailsWithId(EmployeeId inputData);
        ResponseMessage UpdateEmployeeDetails(UpdateModel data);
        ResponseMessage DeleteEmployee(EmployeeId id);
    }
}

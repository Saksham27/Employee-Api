﻿/// ================================================
/// File    : EmployeeController.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
namespace Employee.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using EmployeeBusinessLayer.Interface;
    using EmployeeCommonLayer.Model;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IConfiguration configuration;
        IEmployeeBL businessLayer;
        ResponseMessage response;


        public EmployeeController(IEmployeeBL businessDI, IConfiguration config)
        {
            businessLayer = businessDI;
            configuration = config;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetEmployees()
        {
            try
            {
                response = businessLayer.GetAllEmployeeDetails();

                if (response.Status == true)
                {
                    return Ok(new { response.Status, response.Message, response.Data });
                }
                else
                {
                    return BadRequest(new { response.Status, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

        [HttpGet("data={inputData}")]
        public ActionResult GetEmployeeDetails(string inputData)
        {
            try
            {
                response = businessLayer.GetEmployeeDetails(inputData);
                if (response.Status == true)
                {
                    return Ok(new { response.Status, response.Message, response.Data });
                }
                else
                {
                    return BadRequest(new { response.Status, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetEmployeeDetailsWithId(EmployeeId id)
        {
            try
            {
                response = businessLayer.GetEmployeeDetailsWithId(id);
                if (response.Status == true)
                {
                    return this.Ok(new { response.Status, response.Message, response.Data });
                }
                else
                {
                    return BadRequest(new { response.Status, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

        [HttpPost]
        public ActionResult Register([FromBody] EmployeeModel model)
        {
            try
            {
                response = businessLayer.RegisterEmployee(model);
                if (response.Status == true)
                {
                    return this.Ok(new { response.Status, response.Message });
                }
                else
                {
                    return BadRequest(new { response.Status, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(EmployeeId id)
        {
            try
            {
                response = businessLayer.DeleteEmployee(id);
                if (response.Status == true)
                {
                    return this.Ok(new { response.Status, response.Message });
                }
                else
                {
                    return BadRequest(new { response.Status, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

        [HttpPost("{login}")]
        public ActionResult Login(LoginModel loginData)
        {
            try
            {
                response = businessLayer.EmployeeLogin(loginData);
                if (response.Status == true)
                {
                    return this.Ok(new { response.Status, response.Message });
                }
                else
                {
                    return BadRequest(new { response.Status, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

        [HttpPatch]
        public ActionResult Update(UpdateModel data)
        {
            try
            {
                response = businessLayer.UpdateEmployeeDetails(data);
                if (response.Status == true)
                {
                    return Ok(new { response.Status, response.Message });
                }
                else
                {
                    return BadRequest(new { response.Status, response.Message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }

    }
}
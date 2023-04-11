using DepartmentAPI.Models;
using DepartmentAPI.Services;
using Microsoft.AspNetCore.Mvc;


namespace DepartmentAPI.Controller;

[ApiController]
public class DepartmentController : ControllerBase
{

    private readonly IDepartmentService _service;

    public DepartmentController(IDepartmentService service)
    {

        this._service = service;
    }

    [HttpGet("/api/departments")]

    public IActionResult GetAllDepartments()
    {
        try
        {
            var message = _service.AllDepartments();
            if (message == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(message);
            }
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }


    [HttpGet("/api/departments/{id}")]
    public IActionResult GetById(int id)
    {
        try
        {

            var message = _service.GetDepartmentById(id);
            if (message == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(message);
            }

        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }


    [HttpPost("/api/departments/insert")]
    public IActionResult InsertDepartment([FromBody] Department department)
    {
        try
        {
            bool status = _service.InsertDepartment(department);

            if (status)
            {
                return Ok("Record Inserted sucessfully");
            }
            else
            {
                return BadRequest();
            }
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }


    [HttpPut("/api/departments/update")]

    public IActionResult UpdateDepartment ( [FromBody] Department department)
    {
        try
        {
            bool status = _service.UpdateDepartment(department);
            if (status)
            {
                return Ok("Record Updated sucessfully");
            }
            else
            {
                return BadRequest();
            }
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }

    [HttpDelete("/api/departments/delete/{id}")]
    public IActionResult DeleteDepartment(int id)
    {
        try
        {
            bool status = _service.DeleteDepartment(id);
            if (status)
            {
                return Ok("Record deleted sucessfully");
            }
            else
            {
                return BadRequest();
            }
        }
        catch (Exception e)
        {
            return BadRequest();
        }
    }
}



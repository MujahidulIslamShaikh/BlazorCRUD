using BlazorCRUD.API.Data;
using BlazorCRUD.Library;
using BlazorCRUD.Library.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public EmployeeController(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmpData()
        {
            return Ok(_dbContext.tbl_Employee.ToList());
        }
        [HttpPost]
        public IActionResult AddEmpData(Employee employee)
        {
            var empEntity = new Employee()
            {
                Username = employee.Username,
                Email = employee.Email,
                Phone = employee.Phone
            };
            _dbContext.tbl_Employee.Add(empEntity);
            _dbContext.SaveChanges();
            return Ok(empEntity);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetSingleEmpData(int id) 
        {
            var employee = _dbContext.tbl_Employee.Find(id);
            if(employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }




        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEmpdata(int id, Employee employee)
        {
            var empFindData = _dbContext.tbl_Employee.Find(id);
            if(empFindData is null)
            {
                return NotFound();
            }
            empFindData.Username = employee.Username;
            empFindData.Email = employee.Email;
            empFindData.Phone = employee.Phone;

            _dbContext.SaveChanges();
            return Ok(empFindData);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEmpdata(int id)
        {
            var empFindData = _dbContext.tbl_Employee.Find(id);
            if(empFindData is null)
            {
                return NotFound();
            };

            _dbContext.tbl_Employee.Remove(empFindData);
            _dbContext.SaveChanges();

            return Ok();  // empty bhi pass karsakte 

        }


    }

}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return NotFound(new { message = $"Student with ID {id} not found." });
            return Ok(student);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            if (student == null  || student.Age <= 0)
            {
                return BadRequest(new { message = "Invalid student data." });
            }

            _context.Students.Add(student);
            _context.SaveChanges();

            return CreatedAtAction(
                nameof(GetById),
                new { id = student.Id },
                new
                {
                    message = "Student created successfully.",
                    data = student
                });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Student student)
        {
            if (student == null || string.IsNullOrWhiteSpace(student.Name) || student.Age <= 0)
            {
                return BadRequest(new { message = "Invalid student data." });
            }

            var existingStudent = _context.Students.Find(id);
            if (existingStudent == null)
            {
                return NotFound(new { message = $"Student with ID {id} not found." });
            }

            existingStudent.Name = student.Name;
            existingStudent.Age = student.Age;

            _context.Students.Update(existingStudent);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Student updated successfully.",
                data = existingStudent
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound(new { message = $"Student with ID {id} not found." });
            }

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Ok(new { message = "Student deleted successfully." });
        }

    }
}

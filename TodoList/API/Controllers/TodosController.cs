
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _repository;
        public TodosController(ITodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Todo>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Todo> GetById(int id) => _repository.GetById(id);

        [Route("Remove{id}")]
        public void Remove(int id)
        {
            _repository.Remove(_repository.GetById(id));
        }


        [Route("Update{id}")]
        public void Update(int id)
        {
            _repository.SaveChanges();
        }

        [Route("ActiveTodos")]
        public ActionResult<List<Todo>> GetAllActive()
        {
            List<Todo> activeTodos = new List<Todo>();

            foreach (Todo todo in _repository.GetAll())
            {
                if (todo.IsDone == false)
                {
                    activeTodos.Add(todo);
                }
            }
            return activeTodos.ToList();
        }

        [Route("DoneTodos")]
        public ActionResult<List<Todo>> GetAllDone()
        {
            List<Todo> activeTodos = new List<Todo>();

            foreach (Todo todo in _repository.GetAll())
            {
                if (todo.IsDone == true)
                {
                    activeTodos.Add(todo);
                }
            }
            return activeTodos.ToList();
        }

    }
}
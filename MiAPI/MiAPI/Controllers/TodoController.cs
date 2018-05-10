﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiAPI.Models;
using MiAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Todo")]
    public class TodoController : Controller
    {
        ITodoService _service;
        public TodoController(ITodoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IList<TodoList> GetLists()
        {
            return _service.GetTodoLists();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetList(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_service.ExistList(id))
                return NotFound(new { info = "No existe ninguna lista con el ID especificado" });

            var result = _service.GetTodoList(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult PostTodoList([FromBody]TodoList list)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            int createdId;

            try
            {
                createdId = _service.CreateList(list);
            }
            catch
            {
                return BadRequest();
            }

            return CreatedAtAction("PostTodoList", new { id = createdId }, list);
        }
    }
}
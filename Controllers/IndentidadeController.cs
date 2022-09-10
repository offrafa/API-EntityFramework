using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndentidadeController : ControllerBase
    {
        private readonly DataContext _Context;
        public IndentidadeController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IEnumerable<IndentidadeModel> Get()
        {
            return _Context.Indentidades;
        }

        [HttpGet("{id}")]
        public IndentidadeModel GetById(int id)
        {
            return _Context.Indentidades.FirstOrDefault(IndentidadeModel => IndentidadeModel.Id == id);
        }
    }
}

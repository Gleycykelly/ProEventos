using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Goiânia",
                Lote = "1º Lote",
                QtdaPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
                },
                new Evento() {
                EventoId = 2,
                Tema = "Typescript",
                Local = "Goiânia",
                Lote = "1º Lote",
                QtdaPessoas = 150,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto2.png"
                },

            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _evento.FirstOrDefault(m => m.EventoId == id);
        }

    }
}

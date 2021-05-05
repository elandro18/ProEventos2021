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
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento(){
                EventoId = 1,
                Tema = "Angular",
                Local = "Alegrete",
                Lote = "1° lote" ,
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular2",
                Local = "Alegrete2",
                Lote = "1° lote2" ,
                QtdPessoas = 2500,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto2.png"
            }
        };

        [HttpGet]
        public  IEnumerable<Evento> AllGet()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public  IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(Evento => Evento.EventoId == id );
        }
    }
}

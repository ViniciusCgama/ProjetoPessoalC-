using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProjetoPessoal.Models;
using ProjetoPessoal.Models.Enuns;
namespace ProjetoPessoal.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TarefasController : ControllerBase
    {
        private static List<Tarefa> tarefas = new List<Tarefa>()
        {
            new Tarefa() { IdTarefa = 1, Titulo = "Lavar louça", Descricao = "Lavar a louça", Horario = "21:00", Dia = DiaEnum.SegundaFeira},
            new Tarefa() { IdTarefa = 2, Titulo = "Lavar louça", Descricao = "Lavar a louça", Horario = "21:00", Dia = DiaEnum.TercaFeira},
            new Tarefa() { IdTarefa = 3, Titulo = "Lavar louça", Descricao = "Lavar a louça", Horario = "21:00", Dia = DiaEnum.QuartaFeira},
            new Tarefa() { IdTarefa = 4, Titulo = "Lavar louça", Descricao = "Lavar a louça", Horario = "21:00", Dia = DiaEnum.QuintaFeira},
            new Tarefa() { IdTarefa = 5, Titulo = "Lavar louça", Descricao = "Lavar a louça", Horario = "21:00", Dia = DiaEnum.SextaFeira},
            new Tarefa() { IdTarefa = 6, Titulo = "Lavar louça", Descricao = "Lavar a louça", Horario = "21:00", Dia = DiaEnum.Sabado},
            new Tarefa() { IdTarefa = 7, Titulo = "Lavar louça", Descricao = "Lavar a louça", Horario = "21:00", Dia = DiaEnum.Domingo},
        };
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(tarefas);
        }

        [HttpPost("NovaTarefa")]
        public IActionResult AddTarefa(Tarefa novaTarefa)
        {
            tarefas.Add(novaTarefa);
            return Ok(tarefas);
        }
        [HttpPut]
        public IActionResult UpdateTarefa(Tarefa t)
        {
            Tarefa tarefaAlterada = tarefas.Find(tarefa => tarefa.IdTarefa == t.IdTarefa);
            tarefaAlterada.Titulo= t.Titulo;
            tarefaAlterada.Descricao = t.Descricao;
            tarefaAlterada.Dia = t.Dia;
            tarefaAlterada.Horario = t.Horario;

            return Ok(tarefas);
        }
         [HttpDelete("{id}")]
         public IActionResult DeleteTarefa(int id)
         {
        var tarefa = tarefas.Find(tarefa => tarefa.IdTarefa == id);
        if (tarefa == null)
        {
            return NotFound();
        }

        tarefas.Remove(tarefa);
        return Ok(tarefas);
    }
}
}
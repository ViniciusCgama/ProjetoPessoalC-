using ProjetoPessoal.Models.Enuns;

namespace ProjetoPessoal.Models
{

       public class Tarefa 
    {
        public int IdTarefa { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Horario { get; set; }
        public DiaEnum Dia { get; set; }
    }
}

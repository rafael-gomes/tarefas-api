using SistemaTarefas.Enums;

namespace SistemaTarefas.Models
{
    public class MTarefa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
    }
}

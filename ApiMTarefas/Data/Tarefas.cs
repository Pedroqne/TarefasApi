using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMTarefas.Data
{
    [Table("TAREFAS")]
    public record Tarefa(int Id, string Atividade, string Status);
}




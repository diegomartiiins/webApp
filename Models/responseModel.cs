using webApp.Migrations;

namespace webApp.Models
{

    public class ResponseModel<T>
    {   
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
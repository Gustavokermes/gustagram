using System;
namespace GustagramApi.Model
{
	public class Mensagem
	{
		public Mensagem()
		{
		}
		public string Content { get; set; }
        public string From { get; set; }
        public string To { get; set; }
		public int? Id { get; set; }
		public DateTime? Data_msg { get; set; }
    }
}


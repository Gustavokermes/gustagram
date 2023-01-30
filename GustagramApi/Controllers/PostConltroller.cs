using GustagramApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace GustagramApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
   
    private readonly ILogger<PostController> _logger;
    private readonly GustagramDb _Db;
    public PostController(ILogger<PostController> logger, GustagramDb db )
    {
        _logger = logger;
        _Db = db;
    }

    [HttpPost(Name = "PostaMensagewm")]
    public Mensagem PostaMensagem(Mensagem mensagem)
    {
        Mensagem mensagemResposta = new Mensagem();
        mensagemResposta.From = mensagem.From;
        mensagemResposta.Content = mensagem.Content;
        mensagemResposta.To = mensagem.To;
        mensagemResposta.Data_msg = DateTime.Now;
        _Db.Add(mensagemResposta);
        _Db.SaveChanges();
        return mensagemResposta;
    }

    [HttpGet(Name = "LerMensagem")]
    public List<Mensagem> GetMensagems()
    {
        return _Db.mensagens.OrderBy(o => o.Data_msg).ToList();
    }
}


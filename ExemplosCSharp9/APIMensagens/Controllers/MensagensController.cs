using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIMensagens.Records;

namespace APIMensagens.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MensagensController : ControllerBase
    {
        private readonly ILogger<MensagensController> _logger;
        private static readonly List<Mensagem> _MENSAGENS = new List<Mensagem>();

        public MensagensController(ILogger<MensagensController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Mensagem> Get()
        {
            _logger.LogInformation($"{_MENSAGENS.Count} mensagem(ns) registrada(s)");
            return _MENSAGENS;
        }

        [HttpPost]
        public IActionResult Post(Mensagem mensagem)
        {
            _logger.LogInformation(mensagem.ToString());
            _MENSAGENS.Add(mensagem);
            return new OkResult();
        }
    }
}
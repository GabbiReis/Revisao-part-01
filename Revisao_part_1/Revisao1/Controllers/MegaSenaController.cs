using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Revisao1.Models.Request;

namespace Revisao1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {

        private readonly string _megacaminhoArquivo;

        public MegaSenaController()
        {
            _megacaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "Data", "MegaSena.json");
        }

        #region Operaçoes arquivo
        private List<RegistroJogoViewModel> LerjogosDoArquivo()
        {
            if (!System.IO.File.Exists(_megacaminhoArquivo))
            {
                return new List<RegistroJogoViewModel>();
            }

            string json = System.IO.File.ReadAllText(_megacaminhoArquivo);
            return JsonConvert.DeserializeObject<List<RegistroJogoViewModel>>(json);
        }

        private void EscreverJogosNoArquivo(List<RegistroJogoViewModel> jogos)
        {
            string json = JsonConvert.SerializeObject(jogos);
            System.IO.File.WriteAllText(_megacaminhoArquivo, json);
        }

        #endregion


        [HttpPost]
        public IActionResult Post(RegistroJogoViewModel registroJogoViewModel)
        {
            
            var jogosRealizaddos = LerjogosDoArquivo();

            registroJogoViewModel.DataJogo = DateTime.Now;

            if (
                registroJogoViewModel.PrimeiroNumero != registroJogoViewModel.SegundoNumero
                && registroJogoViewModel.SegundoNumero != registroJogoViewModel.TerceiroNumero
                && registroJogoViewModel.TerceiroNumero != registroJogoViewModel.QuartoNumero
                && registroJogoViewModel.QuartoNumero != registroJogoViewModel.QuintoNumero
                && registroJogoViewModel.QuintoNumero != registroJogoViewModel.SextoNumero
               )
            {
                jogosRealizaddos.Add(registroJogoViewModel);

                EscreverJogosNoArquivo(jogosRealizaddos);

                return Ok("Jogo registrado com sucesso");
            }
            else
                throw new Exception("O jogo não pode ser registrado pois exite numeros repetidos");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(LerjogosDoArquivo());

        }
    }
}

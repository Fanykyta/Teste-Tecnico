using Microsoft.AspNetCore.Mvc;
using PessoasApi.Models;
using Bogus;
using Bogus.Extensions.Brazil; 

namespace PessoasApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class PessoasController : ControllerBase
    {
        private static List<Pessoa>? _pessoasMockadas; 

        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> GetPessoas()
        {
            if (_pessoasMockadas == null)
            {
                _pessoasMockadas = GerarPessoasMockadas(30);
            }
            return Ok(_pessoasMockadas);
        }

        private List<Pessoa> GerarPessoasMockadas(int quantidade)
        {
            var faker = new Faker<Pessoa>("pt_BR")
                .RuleFor(p => p.Cpf, f => f.Person.Cpf(false)) 
                .RuleFor(p => p.Nome, f => f.Name.FullName())
                .RuleFor(p => p.Genero, f => f.PickRandom("Masculino", "Feminino", "Outro"))
                .RuleFor(p => p.Idade, f => f.Random.Number(18, 90))
                .RuleFor(p => p.Endereco, f => f.Address.StreetAddress())
                .RuleFor(p => p.Municipio, f => f.Address.City())
                .RuleFor(p => p.Estado, f => f.Address.StateAbbr());

            return faker.Generate(quantidade);
        }
    }
}

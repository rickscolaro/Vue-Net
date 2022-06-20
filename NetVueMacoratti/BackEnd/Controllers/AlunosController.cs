using BackEnd.Db;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers {


    [ApiController]
    [Route("[controller]")]
    public class AlunosController : Controller {

        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context) {
            _context = context;
        }

        // Alunos
        [HttpGet]
        // Poderia usar List em ves de IEnumerable
        public ActionResult<IEnumerable<Aluno>> Get() {

            var aluno = _context.Alunos.AsNoTracking().ToList();

            if (aluno == null) {
                return NotFound("Alunos não encontrados.");
            }

            return aluno;
        }

        //Alunos/1
        [HttpGet("{id}", Name = "ObterAluno")]
        public ActionResult<Aluno> Get(int id) {

            var aluno = _context.Alunos.AsNoTracking().FirstOrDefault(p => p.AlunoId == id);

            if (aluno == null) {
                return NotFound($"Aluno id={id} não encontrado");
            }
            return aluno;
        }

        //Alunos
        [HttpPost]
        public ActionResult Post(Aluno aluno) {
           
            if (aluno is null) {
                return BadRequest();
            }

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            // Resposta padrão
            // Aciona a rota "ObterAluno"
            return new CreatedAtRouteResult("ObterAluno",
                new { id = aluno.AlunoId }, aluno);
        }


        // Alunos/id
        [HttpPut("{id}")]
        public ActionResult Put(int id, Aluno aluno) {


            if (id != aluno.AlunoId) {
                return BadRequest();
            }

            // Precisa informar a _context que o aluno esta em um estado modificado
            _context.Entry(aluno).State = EntityState.Modified; // Alterar o estado da entidade pa modified
            _context.SaveChanges();
            return Ok(aluno);

        }


        // Alunos/1
        [HttpDelete("{id}")]
        public ActionResult<Aluno> Delete(int id) {


            var aluno = _context.Alunos.FirstOrDefault(p => p.AlunoId == id);

            if (aluno == null) {
                return NotFound("Aluno não existe");
            }

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }
    }
}

using Crazy_Musicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crazy_Musicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        public static List<Musician> _musicians = [
            new Musician() { Id = 1 , FullName = "Ahmet Çalgı", Job = "Ünlü Çalgı Çalar", FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new Musician() { Id = 2 , FullName = "Zeynep Melodi", Job = "Popüler Melodi Yazarı", FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new Musician() { Id = 3 , FullName = "Cemil Akor", Job = "Çılgın Akorist", FunFeature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new Musician() { Id = 4 , FullName = "Fatma Nota", Job = "Sürpriz Nota Üreticisi", FunFeature = "Nota üretirken sürekli sürprizler hazırlar" },
            new Musician() { Id = 5 , FullName = "Hasan Ritim", Job = "Ritim Canavarı", FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new Musician() { Id = 6 , FullName = "Elif Armoni", Job = "Armoni Ustası", FunFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
            new Musician() { Id = 7 , FullName = "Ali Perde", Job = "Perde Uygulayıcı", FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
            new Musician() { Id = 8 , FullName = "Ayşe Rezonans", Job = "Rezonans Uzmanı", FunFeature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new Musician() { Id = 9 , FullName = "Murat Ton", Job = "Tonlama Meraklısı", FunFeature = "Tonlamadaki farklılıklar bazen komik, ama oldukça ilginç" },
            new Musician() { Id = 10 , FullName = "Selin Akor", Job = "Akor Sihirbazı", FunFeature = "Akorları değiştirdiğinde bazen sihirli hava yaratır" },
        ];

        [HttpGet]
        public ActionResult<List<Musician>> GetAll()
        {
            return Ok(_musicians);
        }

        [HttpGet("{id:int:min(1)}")]
        public ActionResult<Musician> GetById(int id)
        {
            Musician? musician = _musicians.FirstOrDefault(m => m.Id == id);

            if (musician is null) return NotFound($"Musician with the Id {id} could not be found!");

            return Ok(musician);
        }

        [HttpGet("search")]
        public ActionResult<List<Musician>> Search([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return BadRequest("Name parameter is required!");

            var musicians = _musicians.Where(m => m.FullName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            
            if (musicians.Count == 0) return NotFound($"Musician with the name {name} could not be found!");
            
            return Ok(musicians);
        }

        [HttpPost]
        public IActionResult CreateMusician([FromBody] CreateMusicianRequest request)
        {
            if (!ModelState.IsValid) return BadRequest();

            var newMusician = new Musician()
            {
                Id = _musicians.Max(m => m.Id) + 1,
                FullName = request.FullName,
                Job = request.Job,
                FunFeature = request.FunFeature
            };

            _musicians.Add(newMusician);

            return Created();
        }

        [HttpDelete("{id:int:min(1)}")]
        public IActionResult DeleteById(int id)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);

            if (musician is null) return NotFound($"Musician with the Id {id} could not be found!");

            _musicians.Remove(musician);

            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateMusician([FromBody] Musician musician)
        {
            var existingMusician = _musicians.FirstOrDefault(m => m.Id == musician.Id);
            if (existingMusician is null) return NotFound($"Musician with the Id {musician.Id} could not be found!");
         
            existingMusician.FullName = musician.FullName;
            existingMusician.Job = musician.Job;
            existingMusician.FunFeature = musician.FunFeature;
            
            return NoContent();
        }

        [HttpPatch("change-fun-feature/{id:int:min(1)}/{funFeature:alpha}")]
        public IActionResult ChangeFunFeature(int id, string funFeature)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician is null) return NotFound($"Musician with the Id {id} could not be found!");
            musician.FunFeature = funFeature;
            return NoContent();
        }

    }
}

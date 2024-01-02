using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Streams.Data.Context;
using Streams.Entites;
using System.Reflection.Metadata;

using Document = Streams.Entites.Document;

namespace Streams.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DocumentController : ControllerBase
	{

        private readonly StreamContext _streamContext;
		private readonly ILogger<DocumentController> _logger;

		public DocumentController(StreamContext streamContext, ILogger<DocumentController> logger)
        {
            _streamContext = streamContext; 
			_logger = logger;	
        }

        [HttpPost]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]
		public ActionResult Insert(Document document) {

              _streamContext.Set<Document>().Add(document);
              _streamContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        
        }


        [HttpPost]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]
		public ActionResult Update(Document document) {
			_streamContext.Set<Document>().Update(document);    
            _streamContext.SaveChanges();   
            return Ok();    

		}


		[HttpGet("{id}")]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]

		public ActionResult Getdocument(int id)
		{
			var document = _streamContext.Set<Document>().FirstOrDefault(x => x.DocumentId == id);

			if (document is null)
			{
				return NotFound();
			}
		

			return Ok(document);
		}



		[HttpGet("{id}")]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]

		public ActionResult Delete(int? id) {

			var found = _streamContext.Set<Document>().First(f => f.DocumentId == id);

			if (found is null)
			{
				return NotFound();
			}
			_streamContext.Remove(found);
			return StatusCode(StatusCodes.Status204NoContent, "Deleted");



		}	




















	}
}

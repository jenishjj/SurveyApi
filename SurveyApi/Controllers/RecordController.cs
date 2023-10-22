using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survey.Models.ResponseModels;
using Survey.Services.Abstraction;

namespace SurveyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IRecordService recordService;

        public RecordController(IRecordService recordService)
        {
            this.recordService = recordService;
        }

        [HttpGet("{Id}")]
        public ActionResult GetRecordById(int Id)
        {
            try
            {
                return Ok(recordService.GetFormRecordById(Id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult SaveRecord(FormRecordModel model)
        {
            try
            {
                return Ok(recordService.AddFormRecord(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

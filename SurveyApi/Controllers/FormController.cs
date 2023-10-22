using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survey.Services.Abstraction;

namespace SurveyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormService formService;

        public FormController(IFormService formService)
        {
            this.formService = formService;
        }

        [HttpGet]
        public ActionResult GetForms()
        {
            try
            {
                return Ok(formService.GetAllForms());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public ActionResult GetFormById(int Id)
        {
            try
            {
                return Ok(formService.GetFormById(Id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

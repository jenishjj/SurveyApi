using Survey.Models.DataModels;
using Survey.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Services.Abstraction
{
    public interface IFormService
    {
        List<Form> GetAllForms();
        FormModel GetFormById(int Id);
    }
}

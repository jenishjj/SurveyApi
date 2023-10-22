using Survey.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Services.Abstraction
{
    public interface IQuestionService
    {
        List<QuestionModel> GetQuestionByPageId(int pageId);
    }
}

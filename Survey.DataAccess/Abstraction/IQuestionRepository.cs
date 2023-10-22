using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess.Abstraction
{
    public interface IQuestionRepository
    {
        List<Question> GetByPageId(int pageId);
    }
}

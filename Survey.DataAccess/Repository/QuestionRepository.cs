using Microsoft.EntityFrameworkCore;
using Survey.DataAccess.Abstraction;
using Survey.DataAccess.Data;
using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext context;
        public QuestionRepository(DataContext context)
        {
            this.context = context;
        }

        public List<Question> GetByPageId(int pageId)
        {
            return context.Questions.Where(x => x.PageId == pageId && x.IsDeleted == false).Include(x => x.QuestionType).OrderBy(x => x.SeqNo).ToList();
        }
    }
}

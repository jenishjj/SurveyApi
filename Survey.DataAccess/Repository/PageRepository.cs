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
    public class PageRepository : IPageRepository
    {
        private readonly DataContext context;
        public PageRepository(DataContext context)
        {
            this.context = context;
        }

        public List<Page> GetByFormId(int formId)
        {
            return context.Pages.Where(x => x.FormId == formId && x.IsDeleted == false).ToList();
        }
    }
}

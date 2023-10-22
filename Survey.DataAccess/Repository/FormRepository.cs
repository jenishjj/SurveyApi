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
    public class FormRepository : IFormRepository
    {
        private readonly DataContext context;
        public FormRepository(DataContext context)
        {
            this.context = context;
        }

        public List<Form> GetAll()
        {
            return context.Forms.ToList();
        }

        public Form GetById(int Id)
        {
            return context.Forms.FirstOrDefault(x => x.Id == Id);
        }

        public List<Page> GetPagesByFormId(int formId)
        {
            return context.Pages.ToList();
        }
    }
}

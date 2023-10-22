using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.ResponseModels
{
    public class FormModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<PageModel> Pages { get; set; } = new();
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}

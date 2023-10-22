using Survey.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.DataModels
{
    public class Form : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public List<Page> Pages { get; set; } = new();
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}

using Survey.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.DataModels
{
    public class Page : BaseModel
    {
        public string PageTitle { get; set; } = string.Empty;
        public int FormId { get; set; }
        public bool IsDeleted { get; set; }
    }
}

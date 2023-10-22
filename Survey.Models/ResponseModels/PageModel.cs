using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.ResponseModels
{
    public class PageModel
    {
        public int Id { get; set; }
        public string PageTitle { get; set; } = string.Empty;
        public int FormId { get; set; }
        public List<QuestionModel> Questions { get; set; } = new();
        public bool IsDeleted { get; set; }
    }
}

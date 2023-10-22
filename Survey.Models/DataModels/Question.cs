using Survey.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.DataModels
{
    public class Question : BaseModel
    {
        public int SeqNo { get; set; }
        public string Title { get; set; } = string.Empty;
        public int PageId { get; set; }
        public string Options { get; set; } = string.Empty;
        public bool IsRequired { get; set; } = true;
        public string TooltipText { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }

        public int QuestionTypeId { get; set; }
        public virtual QuestionType QuestionType { get; set; } = new();
    }
}

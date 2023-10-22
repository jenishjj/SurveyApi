using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.ResponseModels
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public int SeqNo { get; set; }
        public string Title { get; set; } = string.Empty;
        public int QuestionTypeId { get; set; }
        public QuestionType QuestionType { get; set; } = new();
        public int PageId { get; set; }
        public string Options { get; set; } = string.Empty;
        public List<string> OptionsArr { get; set; } = new();
        public bool IsRequired { get; set; } = true;
        public string TooltipText { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.ResponseModels
{
    public class FormRecordModel
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public List<QuestionRecordModel> records { get; set; } = new();
    }

    public class QuestionRecordModel
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public int QuestionId { get; set; }
        public string Value { get; set; } = string.Empty;
    }
}

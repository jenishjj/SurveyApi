using Survey.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.DataModels
{
    public class QuestionRecord : BaseModel
    {
        public int RecordId { get; set; }
        public int QuestionId { get; set; }
        public string Value { get; set; } = string.Empty;
    }
}

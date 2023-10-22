using Survey.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Models.DataModels
{
    public class QuestionType : BaseModel
    {
        public string Type { get; set; } = string.Empty;
    }
}

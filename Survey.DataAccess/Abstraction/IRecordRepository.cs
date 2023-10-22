using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess.Abstraction
{
    public interface IRecordRepository
    {
        FormRecord AddFormRecord(FormRecord model);
        FormRecord GetFormRecordById(int recordId);
        List<QuestionRecord> GetQuestionRecordsByRecordId(int recordId);
        QuestionRecord AddQuestionRecord(QuestionRecord model);
        void AddQuestionRecordList(List<QuestionRecord> questionRecords);
    }
}

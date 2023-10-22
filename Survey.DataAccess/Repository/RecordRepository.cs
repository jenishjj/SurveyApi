using Survey.DataAccess.Abstraction;
using Survey.DataAccess.Data;
using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess.Repository
{
    public class RecordRepository : IRecordRepository
    {
        private readonly DataContext context;
        public RecordRepository(DataContext context)
        {
            this.context = context;
        }

        public FormRecord AddFormRecord(FormRecord model)
        {
            model.CreatedAt = DateTime.Now;
            context.FormRecords.Add(model);
            context.SaveChanges();

            return model;
        }

        public FormRecord GetFormRecordById(int recordId)
        {
            return context.FormRecords.FirstOrDefault(x => x.Id == recordId && x.IsDeleted == false);
        }

        public List<QuestionRecord> GetQuestionRecordsByRecordId(int recordId)
        {
            return context.QuestionRecords.Where(x => x.RecordId == recordId).ToList();
        }

        public QuestionRecord AddQuestionRecord(QuestionRecord model)
        {
            context.QuestionRecords.Add(model);
            context.SaveChanges();

            return model;
        }

        public void AddQuestionRecordList(List<QuestionRecord> questionRecords)
        {
            context.QuestionRecords.AddRange(questionRecords);
            context.SaveChanges();
        }
    }
}

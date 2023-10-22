using AutoMapper;
using Survey.DataAccess.Abstraction;
using Survey.Models.DataModels;
using Survey.Models.ResponseModels;
using Survey.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Services.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository recordRepository;
        private readonly IMapper mapper;

        public RecordService(IRecordRepository recordRepository, IMapper mapper)
        {
            this.recordRepository = recordRepository;
            this.mapper = mapper;
        }

        public FormRecordModel AddFormRecord(FormRecordModel model)
        {
            FormRecord formRecord = mapper.Map<FormRecord>(model);

            formRecord = recordRepository.AddFormRecord(formRecord);

            if (formRecord.Id > 0 && model.records != null && model.records.Count > 0)
            {
                foreach (var item in model.records)
                {
                    item.RecordId = formRecord.Id;
                }
                recordRepository.AddQuestionRecordList(mapper.Map<List<QuestionRecord>>(model.records));
            }

            return mapper.Map<FormRecordModel>(formRecord);
        }

        public FormRecordModel GetFormRecordById(int id)
        {
            FormRecord formRecord = recordRepository.GetFormRecordById(id);
            var formRecordModel = mapper.Map<FormRecordModel>(formRecord);

            var record = recordRepository.GetQuestionRecordsByRecordId(id);
            formRecordModel.records = mapper.Map<List<QuestionRecordModel>>(record);

            return formRecordModel;
        }
    } 
}

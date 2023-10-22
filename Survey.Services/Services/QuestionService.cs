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
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository questionRepository;
        private readonly IMapper mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            this.questionRepository = questionRepository;
            this.mapper = mapper;
        }

        public List<QuestionModel> GetQuestionByPageId(int pageId)
        {
            var question = questionRepository.GetByPageId(pageId);
            List<QuestionModel> questionModelList = mapper.Map<List<QuestionModel>>(question);

            foreach (var item in questionModelList)
            {
                if (!string.IsNullOrEmpty(item.Options))
                    item.OptionsArr = item.Options.Split(",").ToList();
            }

            return questionModelList;
        }
    }
}

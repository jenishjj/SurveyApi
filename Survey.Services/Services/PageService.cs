using AutoMapper;
using Survey.DataAccess.Abstraction;
using Survey.Models.ResponseModels;
using Survey.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Services.Services
{
    public class PageService: IPageService
    {
        private readonly IPageRepository pageRepository;
        private readonly IMapper mapper;
        private readonly IQuestionService questionService; 

        public PageService(
            IPageRepository pageRepository,
            IMapper mapper,
            IQuestionService questionService)
        {
            this.pageRepository = pageRepository;
            this.mapper = mapper;
            this.questionService = questionService;
        }

        public List<PageModel> GetPageByFormId(int formId)
        {
            var page = pageRepository.GetByFormId(formId);
            List<PageModel> pageModel = mapper.Map<List<PageModel>>(page);

            foreach (var item in pageModel)
            {
                item.Questions = questionService.GetQuestionByPageId(item.Id);
            }

            return pageModel;
        }
    }
}

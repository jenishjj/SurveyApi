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
    public class FormService: IFormService
    {
        private readonly IFormRepository formRepository;
        private readonly IMapper mapper;

        private readonly IPageService pageService;

        public FormService(IFormRepository formRepository, IMapper mapper, IPageService pageService)
        {
            this.formRepository = formRepository;
            this.mapper = mapper;
            this.pageService = pageService;
        }

        public List<Form> GetAllForms()
        {
            return formRepository.GetAll().ToList();
        }

        public FormModel GetFormById(int Id)
        {
            var form = formRepository.GetById(Id);
            FormModel formModel = mapper.Map<FormModel>(form);

            formModel.Pages = this.pageService.GetPageByFormId(form.Id);

            return formModel;
        }
    }
}

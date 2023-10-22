using AutoMapper;
using Survey.Models.DataModels;
using Survey.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Services.Common
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Form, FormModel>().ReverseMap();
            CreateMap<Page, PageModel>().ReverseMap();
            CreateMap<Question, QuestionModel>().ReverseMap();
            CreateMap<FormRecord, FormRecordModel>().ReverseMap();
            CreateMap<QuestionRecord, QuestionRecordModel>().ReverseMap();
        }
    }
}

﻿using Survey.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess.Abstraction
{
    public interface IFormRepository
    {
        List<Form> GetAll();
        Form GetById(int Id);
    }
}

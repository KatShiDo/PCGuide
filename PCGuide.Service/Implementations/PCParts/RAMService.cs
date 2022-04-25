﻿using PCGuide.Domain.Entities;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Service.Implementations
{
    public class RAMService : IBaseService<RAM, RAMViewModel>
    {
        public Task<IBaseResponse<RAM>> CreateAsync(RAMViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<RAM>> EditAsync(Guid id, RAMViewModel model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<IEnumerable<RAM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<RAMViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

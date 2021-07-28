﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Dto.Update;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public  interface ICategoryService
    {
        Task Insert(CategoryInputDto categoryDto);
        Task Delete(int id);
        Task Update(CategoryUpdateDto categoryUpdateDto);
        ValueTask<CategoryOutputDto> Get(int id);
        Task<List<CategoryOutputDto>> GetAll();
    }
}

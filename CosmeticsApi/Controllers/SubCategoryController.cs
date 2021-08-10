using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            this.subCategoryService = subCategoryService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubCategoryInputDto subCategoryInputDto)
        {
            await subCategoryService.Insert(subCategoryInputDto);
            return Ok();

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var subCategory = await subCategoryService.Get(id);
            return Ok(subCategory);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var subCategory = await subCategoryService.GetAll();
            return Ok(subCategory);
        }
        [HttpPut]

        public async Task<IActionResult> Update(SubCategoryUpdateDto subCategoryUpdateDto)
        {
            await subCategoryService.Update(subCategoryUpdateDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await subCategoryService.Delete(id);
            return Ok();
        }
    }
}
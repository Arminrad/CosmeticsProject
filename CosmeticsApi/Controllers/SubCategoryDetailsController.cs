using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Dto.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryDetailsController : ControllerBase
    {
        private readonly ISubCategoryDetailsService subCategoryDetailsService;

        public SubCategoryDetailsController(ISubCategoryDetailsService subCategoryDetailsService)
        {
            this.subCategoryDetailsService = subCategoryDetailsService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubCategoryDetailsInputDto subCategoryDetailsInputDto)
        {
            await subCategoryDetailsService.Insert(subCategoryDetailsInputDto);
            return Ok();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await subCategoryDetailsService.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            await subCategoryDetailsService.Get(id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await subCategoryDetailsService.GetAll();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(SubCategoryUpdateDto subCategoryUpdateDto)
        {
            await subCategoryDetailsService.Update(subCategoryUpdateDto);
            return Ok();
        }
    }
}
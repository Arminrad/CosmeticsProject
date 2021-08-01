using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Dto.Update;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public class CommentService : ICommentService
    {
        private readonly IRepositoryComment repositoryUserComment;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CommentService(IRepositoryComment repositoryUserComment,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.repositoryUserComment = repositoryUserComment;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Delete(int id)
        {
            await repositoryUserComment.DeleteAsync(id);
            await unitOfWork.Save();
        }

        public async ValueTask<CommentOutputDto> Get(int id)
        {
            var output = await repositoryUserComment.GetAsync(id);
            var comment = mapper.Map<CommentOutputDto>(output);
            return comment;
        }

        public async Task<List<CommentOutputDto>> GetAll()
        {
            var output = await repositoryUserComment.GetAllCommentAsync();
            var comment = mapper.Map<List<CommentOutputDto>>(output);
            return comment;
        }

        public async Task Insert(CommentInputDto commentInputDto)
        {
            var input = mapper.Map<Comment>(commentInputDto);
            repositoryUserComment.Insert(input);
            await unitOfWork.Save();
        }

      
        public async Task Update(CommentUpdateDto CommentUpdateDto)
        {
            //var input = mapper.Map<Comment>(CommentUpdateDto);
            var input = new Comment();
            input.Id = CommentUpdateDto.Id;
            input.CommentText = CommentUpdateDto.CommentText;
            input.ProductId = CommentUpdateDto.ProductId;
            input.UserId = CommentUpdateDto.UserId;
           
            await repositoryUserComment.UpdateAsync(input);
            await unitOfWork.Save();
        }
    }
}

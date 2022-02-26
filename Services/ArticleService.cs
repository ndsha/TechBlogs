using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechBlogs.Models;
using TechBlogs.Services.Interfaces;

namespace TechBlogs.Services
{
    public class ArticleService : IArticleService
    {
        public ArticleService()
        {

        }

        public async Task<Result> AddArticle(Article article)
        {
            var result = new Result();
            try
            {
                //TO-DO Add db call
                result.Success = true;
                result.Message = "Added article successfully.";
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<Result> DeleteArticle(string id)
        {
            var result = new Result();
            try
            {
                //TO-DO Add db call
                result.Success = true;
                result.Message = "Article deleted successfully.";
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<Article> GetArticle(string id)
        {
            var result = new Article();
            try
            {
                result = new Article()
                {
                    UserId = "abcd",
                    UserName = "Abcd XYZ",
                    Id = 1234,
                    Title = "qwehiuqwhre qiuwehqwiu",
                    Content = "asdajshd asjdask aksjdhakjsd akjsdhk",
                    Status = "Published",
                    Tags = new List<string>() { "abcd", "cdef" }
                };
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<List<Article>> GetArticles()
        {
            var result = new List<Article>();
            try
            {
                result.Add(new Article()
                {
                    UserId = "abcd",
                    UserName = "Abcd XYZ",
                    Id = 1234,
                    Title = "qwehiuqwhre qiuwehqwiu",
                    Content = "asdajshd asjdask aksjdhakjsd akjsdhk",
                    Status = "Published",
                    Tags = new List<string>() { "abcd", "cdef" }
                });
                result.Add(new Article()
                {
                    UserId = "abcd",
                    UserName = "Abcd XYZ",
                    Id = 1235,
                    Title = "qwehiuqwhre qiuwehqwiu",
                    Content = "asdajshd asjdask aksjdhakjsd akjsdhk",
                    Status = "Published",
                    Tags = new List<string>() { "abcd", "cdef" }
                });
                result.Add(new Article()
                {
                    UserId = "abcd",
                    UserName = "Abcd XYZ",
                    Id = 1236,
                    Title = "qwehiuqwhre qiuwehqwiu",
                    Content = "asdajshd asjdask aksjdhakjsd akjsdhk",
                    Status = "Published",
                    Tags = new List<string>() { "abcd", "cdef" }
                });
                result.Add(new Article()
                {
                    UserId = "abcd",
                    UserName = "Abcd XYZ",
                    Id = 1237,
                    Title = "qwehiuqwhre qiuwehqwiu",
                    Content = "asdajshd asjdask aksjdhakjsd akjsdhk",
                    Status = "Published",
                    Tags = new List<string>() { "abcd", "cdef" }
                });
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public async Task<Result> UpdateArticle(Article article)
        {
            var result = new Result();
            try
            {
                //TO-DO Add db call
                result.Success = true;
                result.Message = "Article updated successfully.";
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}

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

        public Task<Result> AddArticle(Article article)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> DeleteArticle(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Article> GetArticle(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Article>> GetArticles()
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> UpdateArticle(Article article)
        {
            throw new System.NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TechBlogs.Models;

namespace TechBlogs.Services.Interfaces
{
    public interface IArticleService
    {
        Task<Article> GetArticle(string id);
        Task<List<Article>> GetArticles();
        Task<Result> AddArticle(Article article);
        Task<Result> DeleteArticle(string id);
        Task<Result> UpdateArticle(Article article);
    }
}

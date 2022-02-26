using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TechBlogs.Models;
using TechBlogs.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBlogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET: api/<ArticleController>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                var articles = await _articleService.GetArticles();
                if (articles != null && articles.Any())
                {
                    return Ok(articles);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error occurred while fetching the data.");
            }
        }

        // GET api/<ArticleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var article = await _articleService.GetArticle(id);
                if (article != null)
                {
                    return Ok(article);
                }
                return NotFound("Article not found.");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error occurred while fetching the data.");
            }
        }

        // POST api/<ArticleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Article article)
        {
            try
            {
                if (article == null)
                {
                    return BadRequest("Article is not valid.");
                }
                if(article.Content == null)
                {
                    return BadRequest("Content is not valid.");
                }
                if(article.Title == null)
                {
                    return BadRequest("Title is not valid.");
                }
                
                var response = await _articleService.AddArticle(article);
                return response.Success ? Ok("Added article successfully.") : Ok(response.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error occurred while fetching the data.");
            }
        }

        // PUT api/<ArticleController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Article article)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return BadRequest("Id is invalid.");
                }
                var response = await _articleService.UpdateArticle(article);
                return response.Success ? Ok("Article updated successfully.") : Ok(response.Message);
            }
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error occurred while fetching the data.");
            }
        }

        // DELETE api/<ArticleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return BadRequest("Id is invalid.");
                }
                var response = await _articleService.DeleteArticle(id);
                return response.Success ? Ok("Article deleted successfully.") : Ok(response.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error occurred while fetching the data.");
            }
        }
    }
}

using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebClient.Model.Models;
using WebClient.Service;
using WebClient.Web.Infrastructure.Core;

namespace WebClient.Web.API
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController :ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        IErrorService _errorService;
        public PostCategoryController(IErrorService error, IPostCategoryService post):base(error)
        {
            this._postCategoryService = post;
            this._errorService = error;
        }
        [Route("getall")]
        // GET api/<controller>
        public HttpResponseMessage Get(HttpRequestMessage message)
        {
            return CreateHttpResponse(message, () => {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listcategory = _postCategoryService.GetAll();
                    reponse = message.CreateResponse(HttpStatusCode.OK, listcategory);
                }
                return reponse;
            });
        }
        [Route("post")]
        // POST api/<controller>
        public HttpResponseMessage Post(HttpRequestMessage message, PostCategory postCategory)
        {
            return CreateHttpResponse(message, () => {
                HttpResponseMessage reponse = null;
                if(ModelState.IsValid)
                {
                    Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _postCategoryService.Add(postCategory);
                    _postCategoryService.SaveChanges();
                    reponse = message.CreateResponse(HttpStatusCode.Created, category);
                }
                return reponse;
            });
        }
        [Route("put")]
        // PUT api/<controller>
        public HttpResponseMessage Put(HttpRequestMessage message, PostCategory postCategory)
        {
            return CreateHttpResponse(message, () => {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Update(postCategory);
                    _postCategoryService.SaveChanges();
                    reponse = message.CreateResponse(HttpStatusCode.OK);
                }
                return reponse;
            });
        }
        [Route("delete")]
        // DELETE api/<controller>
        public HttpResponseMessage Delete(HttpRequestMessage message, int id)
        {
            return CreateHttpResponse(message, () => {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.SaveChanges();
                    reponse = message.CreateResponse(HttpStatusCode.OK);
                }
                return reponse;
            });
        }
    }
}
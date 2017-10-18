using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebClient.Model.Models;
using WebClient.Service;

namespace WebClient.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }
        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage request, Func<HttpResponseMessage> funcResponseMess)
        {
            HttpResponseMessage response = null;
            try
            {
                response = funcResponseMess.Invoke();
            }
            catch(DbEntityValidationException DbEntityEx)
            {
                foreach(var x in DbEntityEx.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{x.Entry.Entity.GetType().Name}\" in state \"{x.Entry.State}\" has the following vadidation error.");
                    foreach(var y in x.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{y.PropertyName}\", Error: \"{y.ErrorMessage}\"");
                    }
                }
                LogError(DbEntityEx);
                response = request.CreateResponse(HttpStatusCode.BadRequest, DbEntityEx.InnerException.Message);
            }
            catch(DbUpdateException dbex)
            {
                LogError(dbex);
                response = request.CreateResponse(HttpStatusCode.BadRequest, dbex.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                response = request.CreateResponse(HttpStatusCode.BadRequest,ex.Message);
            }
            return response;
        }
        public void LogError(Exception ex)
        {
            try
            {
                Error e = new Error();
                e.CreatedDate = DateTime.Now;
                e.Message = ex.Message;
                e.StackTrace = ex.StackTrace;
                _errorService.CreateError(e);
                _errorService.Save();
            }
            catch
            {

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamitoWebAPI.Models
{
    public class Response
    {
        bool Sucess { get; set; }
        string Message { get; set; }

        private Response _response;
        public Response() {
            this._response = new Response(false,null);
        }
        public Response(bool _sucess, string _message) {
            this.Sucess = _sucess;
            this.Message = _message;
        }

        public Response BadRequest(string _message) {
            this._response = new Response( false, _message==null ? "Bad Request": _message );
            return this._response;
        }

        public Response NotFound(string _message)
        {
            this._response = new Response(false, _message == null ? "Not Found" : _message);
            return this._response;
        }

        public Response OK(string _message)
        {
            this._response = new Response(true, _message == null ? "Sucess" : _message);
            return this._response;
        }

        public Response error(string _message) {
            this._response = new Response(false, _message == null ? "Internal error" : _message);
            return this._response;
        }
    }
}

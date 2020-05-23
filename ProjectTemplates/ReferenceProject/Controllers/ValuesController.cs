using AutoMapper;
using Serilog;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ReferenceProject
{
    public class ComplexType
    {
        /// <summary>
        /// This is the object's key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// This is the object's key
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// A sting values which has the null value
        /// </summary>
        public string NullValue { get; set; } = null;
        /// <summary>
        /// Some integer value
        /// </summary>
        public int IntValue { get; set; } = 0;
    }

    /// <summary>
    /// An example of controller
    /// </summary>
    public class ValuesController : ApiController
    {
        private ILogger Logger { get; }
        private IMapper Mapper { get; }

        public ValuesController(ILogger logger, IMapper mapper)
        {
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Get all of the values
        /// </summary>
        /// <returns></returns>
        // GET <controller>
        public IEnumerable<string> Get()
        {
            Logger.Information("URL: {HttpRequestUrl}");
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a complex type value
        /// </summary>
        [HttpGet]
        [Route("GetComplex")]
        public ComplexType GetComplex()
        {
            return new ComplexType() { Key = "Key", Value = "Value" };
        }

        /// <summary>
        /// Always throw an exception
        /// </summary>
        [HttpGet]
        [Route("ThrowException")]
        public void ThrowException()
        {
            throw new Exception("Example exception");
        }

        /// <summary>
        /// Get a value by id
        /// </summary>
        /// <param name="id">The value identifier</param>
        /// <returns>Requested value</returns>
        // GET <controller>/5
#pragma warning disable RECS0154 // Parameter is never used
        public string Get(int id)
#pragma warning restore RECS0154 // Parameter is never used
        {
            return "value";
        }

        /// <summary>
        /// Create a new value
        /// </summary>
        /// <param name="value">New value</param>
        // POST <controller>
#pragma warning disable RECS0154 // Parameter is never used
        public void Post([FromBody]string value)
#pragma warning restore RECS0154 // Parameter is never used
        {
        }

        /// <summary>
        /// Update the previously created value
        /// </summary>
        /// <param name="id">The value identifier</param>
        /// <param name="value">New value</param>
        // PUT <controller>/5
#pragma warning disable RECS0154 // Parameter is never used
#pragma warning disable RECS0154 // Parameter is never used
        public void Put(int id, [FromBody]string value)
#pragma warning restore RECS0154 // Parameter is never used
#pragma warning restore RECS0154 // Parameter is never used
        {
        }

        /// <summary>
        /// Remove the earlier created value
        /// </summary>
        /// <param name="id">The value identifier</param>
        // DELETE <controller>/5
#pragma warning disable RECS0154 // Parameter is never used
        public void Delete(int id)
#pragma warning restore RECS0154 // Parameter is never used
        {
        }
    }
}
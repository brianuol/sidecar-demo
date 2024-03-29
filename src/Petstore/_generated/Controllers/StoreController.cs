/*
 * 
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace Petstore.GeneratedCode.Controllers
{ 
    using Models;
    using Interfaces;
    using Attributes;

    /// <summary>
    /// store API
    /// </summary>
    [Description("store API")]
    public class StoreController : Controller, IStoreController
    {
        private readonly IStoreController _implementation;
        public StoreController(IStoreController implementation){
            this._implementation = implementation;
        }
        
        /// <summary>
        /// Returns pet inventories by status
        /// </summary>  
        /// <remarks>Returns a map of status codes to quantities</remarks>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("/store/inventory")]
        [ValidateModelState]
        [SwaggerOperation("getInventory")]
        [SwaggerResponse(statusCode: 200, type: typeof(object), description: "successful operation")]
        public virtual IActionResult getInventory()
        {
            try {
                return this._implementation.getInventory();
            }
            catch(NotImplementedException){
                return Content("getInventory says: finish me!");
            }
        }

        /// <summary>
        /// Place an order for a pet
        /// </summary>  
        /// <param name="orderItem">order placed for purchasing the pet</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid Order</response>
        [HttpPost]
        [Route("/store/order")]
        [ValidateModelState]
        [SwaggerOperation("placeOrder")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, description: "Invalid Order")]
        public virtual IActionResult placeOrder([FromBody]Order orderItem)
        {
            try {
                return this._implementation.placeOrder(orderItem);
            }
            catch(NotImplementedException){
                return Content("placeOrder says: finish me!");
            }
        }

        /// <summary>
        /// Find purchase order by ID
        /// </summary>  
        /// <remarks>For valid response try integer IDs with value &gt;= 1 and &lt;= 10. Other values will generated exceptions</remarks>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpGet]
        [Route("/store/order/{orderId}")]
        [ValidateModelState]
        [SwaggerOperation("getOrderById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        [SwaggerResponse(statusCode: 400, description: "Invalid ID supplied")]
        [SwaggerResponse(statusCode: 404, description: "Order not found")]
        public virtual IActionResult getOrderById([FromRoute][Required][Range(1.0, 10.0)]int orderId)
        {
            try {
                return this._implementation.getOrderById(orderId);
            }
            catch(NotImplementedException){
                return Content("getOrderById says: finish me!");
            }
        }

        /// <summary>
        /// Delete purchase order by ID
        /// </summary>  
        /// <remarks>For valid response try integer IDs with positive integer value. Negative or non-integer values will generate API errors</remarks>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpDelete]
        [Route("/store/order/{orderId}")]
        [ValidateModelState]
        [SwaggerOperation("deleteOrder")]
        [SwaggerResponse(statusCode: 400, description: "Invalid ID supplied")]
        [SwaggerResponse(statusCode: 404, description: "Order not found")]
        public virtual IActionResult deleteOrder([FromRoute][Required]int orderId)
        {
            try {
                return this._implementation.deleteOrder(orderId);
            }
            catch(NotImplementedException){
                return Content("deleteOrder says: finish me!");
            }
        }
    }
}

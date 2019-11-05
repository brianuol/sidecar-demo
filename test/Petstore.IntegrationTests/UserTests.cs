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
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Petstore.Tests
{ 
    using Xunit;
    using GeneratedCode.Models;
    using GeneratedCode.Interfaces;

    /// <summary>
    /// user API
    /// </summary>
    public class UserTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        public UserTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        /// <summary>
        /// Create user
        /// </summary>  
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="userItem">Created user object</param>
        /// <response code="200">successful operation</response>
        //public async Task createUserTest(User userItem)

        [Theory]
        [InlineData(default(User))]
        public async Task createUserTest(User userItem)
        { 
            var client = _factory.CreateClient();
            var url = $"/user";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>  
        /// <param name="userItems">List of user object</param>
        /// <response code="200">successful operation</response>
        //public async Task createUsersWithArrayInputTest(List<User> userItems)

        [Theory]
        [InlineData(default(List<User>))]
        public async Task createUsersWithArrayInputTest(List<User> userItems)
        { 
            var client = _factory.CreateClient();
            var url = $"/user/createWithArray";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }

        /// <summary>
        /// Creates list of users with given input array
        /// </summary>  
        /// <param name="userItems">List of user object</param>
        /// <response code="200">successful operation</response>
        //public async Task createUsersWithListInputTest(List<User> userItems)

        [Theory]
        [InlineData(default(List<User>))]
        public async Task createUsersWithListInputTest(List<User> userItems)
        { 
            var client = _factory.CreateClient();
            var url = $"/user/createWithList";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }

        /// <summary>
        /// Logs user into the system
        /// </summary>  
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username/password supplied</response>
        //public async Task loginUserTest(string username, string password)

        [Theory]
        [InlineData(default(string), default(string))]
        public async Task loginUserTest(string username, string password)
        { 
            var client = _factory.CreateClient();
            var url = $"/user/login?username={ username }&password={ password }";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }

        /// <summary>
        /// Logs out current logged in user session
        /// </summary>  
        /// <response code="200">successful operation</response>
        //public async Task logoutUserTest()
        [Fact]
        public async Task logoutUserTest()
        { 
            var client = _factory.CreateClient();
            var url = $"/user/logout";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }

        /// <summary>
        /// Get user by user name
        /// </summary>  
        /// <param name="username">The name that needs to be fetched. Use user1 for testing. </param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        //public async Task getUserByNameTest(string username)

        [Theory]
        [InlineData(default(string))]
        public async Task getUserByNameTest(string username)
        { 
            var client = _factory.CreateClient();
            var url = $"/user/{username}";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }

        /// <summary>
        /// Updated user
        /// </summary>  
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="username">name that need to be updated</param>
        /// <param name="userItem">Updated user object</param>
        /// <response code="400">Invalid user supplied</response>
        /// <response code="404">User not found</response>
        //public async Task updateUserTest(string username, User userItem)

        [Theory]
        [InlineData(default(string), default(User))]
        public async Task updateUserTest(string username, User userItem)
        { 
            var client = _factory.CreateClient();
            var url = $"/user/{username}";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }

        /// <summary>
        /// Delete user
        /// </summary>  
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="username">The name that needs to be deleted</param>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        //public async Task deleteUserTest(string username)

        [Theory]
        [InlineData(default(string))]
        public async Task deleteUserTest(string username)
        { 
            var client = _factory.CreateClient();
            var url = $"/user/{username}";

            // todo:  implement
            // var response = await client.GetAsync(url);
            // response.EnsureSuccessStatusCode();

            throw new NotImplementedException("The test is not yet implemented");
        }
    }
}

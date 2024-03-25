using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Knedlex.Roblox.Users.AzureFunction
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            var user = req.Query["user"].ToString();

            var config = new Configuration
            {
                BasePath = "https://users.roblox.com"
            };

            var userApi = new UsersApi(config);

            var userData =
                await userApi.V1UsernamesUsersPostAsync(
                    new RobloxUsersApiMultiGetByUsernameRequest(new List<string> { user }));


            return new OkObjectResult(userData.Data);
        }
    }
}

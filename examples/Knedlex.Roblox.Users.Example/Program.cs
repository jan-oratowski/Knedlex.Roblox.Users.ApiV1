using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

string? userName = null;

while (string.IsNullOrWhiteSpace(userName))
{
    Console.WriteLine("Hello, World! Enter Roblox username.");
    userName = Console.ReadLine();
}

Console.WriteLine($"Hello, {userName}! Now calling Roblox API to get your info.");

var config = new Configuration
{
    BasePath = "https://users.roblox.com"
};

var userApi = new UsersApi(config);

var user =
    userApi.V1UsernamesUsersPostAsync(
        new RobloxUsersApiMultiGetByUsernameRequest(new List<string> { userName }));


Console.WriteLine($"User ID: {user.Result.Data[0].Id}");
Console.WriteLine($"User DisplayName: {user.Result.Data[0].DisplayName}");

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

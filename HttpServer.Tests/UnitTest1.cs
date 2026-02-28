namespace http_server_tests;

public class UnitTest1
{
    static HttpClientHandler clientHandler =  new HttpClientHandler();
    static HttpClient client =  new HttpClient(clientHandler);
    [Fact]
    public void Test1()
    {
        client.BaseAddress = new Uri("https://localhost:5001");
    }
}
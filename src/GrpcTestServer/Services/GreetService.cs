using GreeterService;

namespace GrpcTestServer.Services;

public class GreetService : Greeter.GreeterBase
{
    private readonly ILogger<GreetService> _logger;
    public GreetService(ILogger<GreetService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, Grpc.Core.ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}
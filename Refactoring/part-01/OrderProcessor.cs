namespace RefactoringLab.Part_1;

public class OrderProcessor
{
    
    private readonly IOrderRepository _orderRepository;
    private readonly IEmailSender _emailSender;

    public OrderProcessor(IOrderRepository orderRepository , IEmailSender emailSender )
    {
        _emailSender = emailSender;
        _orderRepository = orderRepository;
    }

    public void Process(int orderId, string customerEmail)
    {
        _orderRepository.Save(orderId, DateTime.Now);
        _emailSender.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}

public interface IOrderRepository
{
    public void Save(int orderId, DateTime processedAt);
}

public interface IEmailSender
{
    public void Send(string to, string body);
}

public class SqlOrderRepository : IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender : IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}

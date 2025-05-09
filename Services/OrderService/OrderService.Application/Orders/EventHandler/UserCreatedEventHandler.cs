using MediatR;
using UserService.Application.Users.Events;

namespace OrderService.Application.Orders.EventHandler
{
    public class UserCreatedEventHandler : INotificationHandler<UserCreatedEvent>
    {
        public Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            // Handle the event - Create an order for the new user
            Console.WriteLine($"User Created: {notification.UserName} (ID: {notification.EmailID})");

            // Simulate creating an order
            Console.WriteLine($"Creating an initial order for user {notification.UserName}");

            return Task.CompletedTask;
        }
    }
}

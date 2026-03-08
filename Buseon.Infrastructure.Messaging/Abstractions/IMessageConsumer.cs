namespace Buseon.Infrastructure.Messaging.Abstractions;

/// <summary>
/// Abstraction for consuming messages from a message broker.
/// Implementations should handle subscription, message dispatch, and error handling.
/// </summary>
public interface IMessageConsumer
{
    Task SubscribeAsync(
        string destination,
        Func<IMessageEnvelope, CancellationToken, Task> handler,
        CancellationToken cancellationToken = default);
}

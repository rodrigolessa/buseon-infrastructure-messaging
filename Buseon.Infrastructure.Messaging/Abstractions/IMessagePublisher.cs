namespace Buseon.Infrastructure.Messaging.Abstractions;

/// <summary>
/// Abstraction for publishing messages to a message broker (e.g. RabbitMQ, Amazon SQS, Azure Service Bus).
/// </summary>
public interface IMessagePublisher
{
    Task PublishAsync(
        string destination,
        ReadOnlyMemory<byte> body,
        IReadOnlyDictionary<string, object?>? headers = null,
        CancellationToken cancellationToken = default);
}
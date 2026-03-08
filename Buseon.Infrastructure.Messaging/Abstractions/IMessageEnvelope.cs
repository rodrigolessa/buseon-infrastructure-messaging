namespace Buseon.Infrastructure.Messaging.Abstractions;

/// <summary>
/// Represents a transport-agnostic message envelope used by the messaging infrastructure.
/// Implementations for RabbitMQ, Amazon SQS, etc. should map their native message types to this abstraction.
/// </summary>
public interface IMessageEnvelope
{
    string MessageId { get; }
    string? CorrelationId { get; }
    IReadOnlyDictionary<string, object?> Headers { get; }
    ReadOnlyMemory<byte> Body { get; }
}
using System;

namespace OVHSHARP.Api.Testing
{
    public interface ITimeProvider
    {
        DateTimeOffset Now { get; }
        DateTimeOffset UtcNow { get; }
    }
}
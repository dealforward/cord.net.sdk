using MediatR;

namespace Cord.SDK.Application.Abstractions.Messaging;

internal interface ICommand<out T> : IRequest<T>
{
}

internal interface ICommand : IRequest
{
}
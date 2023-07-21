using MediatR;

namespace Cord.SDK.Application.Abstractions.Messaging;

internal interface IQuery<out T> : IRequest<T>
{
}

internal interface IQueryHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : IQuery<TResponse>
{
}
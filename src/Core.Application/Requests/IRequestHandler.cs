using MediatR;

namespace Core.Application.Requests;

public interface IRequestHandler<in TRequest> : IRequestHandler<TRequest, Unit>
    where TRequest : IRequest { }

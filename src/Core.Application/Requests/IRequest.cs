using MediatR;

namespace Core.Application.Requests;

public interface IRequest : IRequest<Unit> { }

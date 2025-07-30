
namespace Basket.API.Basket.DeleteBasket
{
    public record DeleteBasketCommand(string UserName) : ICommand<DeleteBasketResult>;

    public record DeleteBasketResult(bool IsSuccess);

    public class DeleteBasetCommandValidator : AbstractValidator<DeleteBasketCommand>
    {
        public DeleteBasetCommandValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName Is Required");
        }
    }

    public class DeleteBasketCommandHandler
        : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
    {
        public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
        {
            return new DeleteBasketResult(true);
        }
    }
}

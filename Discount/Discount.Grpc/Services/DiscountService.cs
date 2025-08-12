using Grpc.Core;

namespace Discount.Grpc.Services
{
    public class DiscountService : DiscountProtoService.DiscountProtoServiceBase
    {
        // Implement the service methods here
        // For example, you can implement GetDiscount, CreateDiscount, UpdateDiscount, and DeleteDiscount methods.
        // Each method should interact with the data layer to perform the required operations.

        public override Task<CouponModel> GetDiscount(GetDiscountRequest request, ServerCallContext context)
        {
            return base.GetDiscount(request, context);
        }

        public override Task<CouponModel> CreateDiscount(CreateDiscountsRequest request, ServerCallContext context)
        {
            return base.CreateDiscount(request, context);
        }

        public override Task<CouponModel> UpdateDiscount(UpdateDiscountRequest request, ServerCallContext context)
        {
            return base.UpdateDiscount(request, context);
        }

        public override Task<DeleteDiscountResponse> DeleteDiscount(DeleteDiscountRequest request, ServerCallContext context)
        {
            return base.DeleteDiscount(request, context);
        }
    }
}

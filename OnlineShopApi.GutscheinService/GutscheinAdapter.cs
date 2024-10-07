using Grpc.Core;
using OnlineShopApi.GutscheinService.Contracts;

namespace OnlineShopApi.GutscheinService;

public class GutscheinAdapter : GutscheinService.Contracts.GutscheinService.GutscheinServiceBase
{
    public override Task<HoleGutscheinMitIdResponse> HoleGutscheinMitId(HoleGutscheinMitIdRequest request, ServerCallContext context)
    {
        return base.HoleGutscheinMitId(request, context);
    }
}

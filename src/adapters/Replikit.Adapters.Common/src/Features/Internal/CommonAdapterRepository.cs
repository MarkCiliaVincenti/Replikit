using Replikit.Abstractions.Adapters;
using Replikit.Abstractions.Attachments.Models;
using Replikit.Abstractions.Common.Models;
using Replikit.Abstractions.Repositories.Features;
using Replikit.Abstractions.Repositories.Models;

namespace Replikit.Adapters.Common.Features.Internal;

internal class CommonAdapterRepository : AdapterService, IAdapterRepository
{
    private readonly IAdapterRepository _adapterRepository;

    public CommonAdapterRepository(IAdapter adapter, IAdapterRepository adapterRepository) : base(adapter)
    {
        _adapterRepository = adapterRepository;
    }

    public AdapterRepositoryFeatures Features => _adapterRepository.Features;

    public Task<AccountInfo?> GetAccountInfoAsync(Identifier identifier, CancellationToken cancellationToken = default)
    {
        CheckIdentifier(identifier);

        return _adapterRepository.GetAccountInfoAsync(identifier, cancellationToken);
    }

    public Task<ChannelInfo?> GetChannelInfoAsync(Identifier identifier, CancellationToken cancellationToken = default)
    {
        CheckIdentifier(identifier);

        return _adapterRepository.GetChannelInfoAsync(identifier, cancellationToken);
    }

    public Task<Attachment> ResolveAttachmentUrlAsync(Attachment attachment,
        CancellationToken cancellationToken = default)
    {
        CheckIdentifier(attachment.Id!);

        return _adapterRepository.ResolveAttachmentUrlAsync(attachment, cancellationToken);
    }
}

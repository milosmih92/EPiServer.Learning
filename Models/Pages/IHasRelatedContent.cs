using EPiServer.Core;

namespace EPiServer.Learning.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}

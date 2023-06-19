using Composer.Common.Models;

namespace Composer.Common.Services
{
    public interface ITemplateService
    {
        public Task<T> GetTemplate<T>(Guid guid) where T : ITemplate;
        public Task<IEnumerable<ITemplateChild>> GetChildTemplates(Guid parentGuid);
    }
}

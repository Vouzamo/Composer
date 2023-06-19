using Composer.Common.Models;
using Composer.Common.Models.Templates;

namespace Composer.Common.Repositories
{
    public interface ITemplateRepository
    {
        public Task<CompositionTemplate> GetCompositionTemplate(Guid guid);
        public Task<IEnumerable<ITemplateChild>> GetChildTemplates(Guid parentGuid);
    }
}

using Composer.Common.Models;

namespace Composer.Common.Services
{
    public class TemplateService : ITemplateService
    {
        public Task<T> GetTemplate<T>(Guid guid) where T : ITemplate
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ITemplateChild>> GetChildTemplates(Guid parentGuid)
        {
            throw new NotImplementedException();
        }
    }
}

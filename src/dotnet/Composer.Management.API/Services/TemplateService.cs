using Composer.Common.Models;
using Composer.Common.Services;

namespace Composer.Management.API.Services
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

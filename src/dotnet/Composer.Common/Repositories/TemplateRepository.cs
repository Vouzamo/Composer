using Composer.Common.Models;
using Composer.Common.Models.Templates;

namespace Composer.Common.Repositories
{
    public class TemplateRepository : ITemplateRepository
    {
        private IList<ITemplate> Templates { get; set; } = new List<ITemplate>();

        public TemplateRepository()
        {
            
        }

        public void Add(ITemplate template)
        {
            Templates.Add(template);
        }

        public Task<CompositionTemplate> GetCompositionTemplate(Guid guid)
        {
            var result = Templates.OfType<CompositionTemplate>().SingleOrDefault(t => t.Guid == guid);
            
            if(result == default)
            {
                throw new KeyNotFoundException();
            }

            return Task.FromResult(result);
        }

        public Task<IEnumerable<ITemplateChild>> GetChildTemplates(Guid parentGuid)
        {
            var results = Templates.OfType<ITemplateChild>().Where(t => t.ParentGuid == parentGuid);

            return Task.FromResult(results);
        }
    }
}

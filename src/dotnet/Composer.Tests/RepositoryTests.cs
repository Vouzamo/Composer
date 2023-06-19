using Composer.Common.Models.Templates;
using Composer.Common.Repositories;

namespace Composer.Tests
{
    public class RepositoryTests
    {
        [Fact]
        public async Task Repositories_ITemplateRepository_Composition()
        {
            // Assemble
            var repository = new TemplateRepository();

            var compositionTemplate = new CompositionTemplate(Guid.NewGuid(), "My First Composition");
            repository.Add(compositionTemplate);

            var regionTemplate1 = new RegionTemplate(Guid.NewGuid(), compositionTemplate.Guid, "Region 1");
            repository.Add(regionTemplate1);


            // Act
            var composition = await repository.GetCompositionTemplate(compositionTemplate.Guid);
            var children = await repository.GetChildTemplates(composition.Guid);


            // Assert
            Assert.Equal("Region 1", children.FirstOrDefault(c => c.Type == "Region")?.Name);
        }
    }
}
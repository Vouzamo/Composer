namespace Composer.Common.Models.Templates
{
    public class CompositionTemplate : ITemplate
    {
        public Guid Guid { get; set; }
        public string Type => "Composition";
        public string Name { get; set; }

        public CompositionTemplate(Guid guid, string name)
        {
            Guid = guid;
            Name = name;
        }
    }
}
namespace Composer.Common.Models.Templates
{

    public class ComponentTemplate : ITemplateChild
    {
        public string Type => "Component";
        public Guid Guid { get; set; }
        public Guid ParentGuid { get; set; }
        public string Name { get; set; }

        public ComponentTemplate(Guid guid, Guid parentGuid, string name)
        {
            Guid = guid;
            ParentGuid = parentGuid;
            Name = name;
        }
    }
}
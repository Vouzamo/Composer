namespace Composer.Common.Models.Templates
{
    public class RegionTemplate : ITemplateChild
    {
        public string Type => "Region";
        public Guid Guid { get; set; }
        public Guid ParentGuid { get; set; }
        public string Name { get; set; }

        public RegionTemplate(Guid guid, Guid parentGuid, string name)
        {
            Guid = guid;
            ParentGuid = parentGuid;
            Name = name;
        }
    }
}
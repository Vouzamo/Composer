namespace Composer.Common.Models
{
    public interface ITemplateChild : ITemplate
    {
        public Guid ParentGuid { get; set; }
    }
}
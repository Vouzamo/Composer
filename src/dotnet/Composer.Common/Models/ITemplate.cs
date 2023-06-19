namespace Composer.Common.Models
{
    public interface ITemplate
    {
        public Guid Guid { get; set; }
        public string Type { get; }
        public string Name { get; set; }
    }
}
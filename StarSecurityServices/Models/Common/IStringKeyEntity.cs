namespace StarSecurityServices.Models.Common
{
    public interface IStringKeyEntity
    {
        string Id { get; set; }

        static void Generate(IStringKeyEntity obj)
        {
            obj.Id = Guid.NewGuid().ToString();
        }
    }
}

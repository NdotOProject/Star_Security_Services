namespace StarSecurityServices.Models.Common
{
    public interface IStringId
    {
        string? Id { get; set; }

        static bool Generate(IStringId obj)
        {
            string id = Guid.NewGuid().ToString();

            obj.Id = id;

            return obj.Id == id;
        }
    }
}

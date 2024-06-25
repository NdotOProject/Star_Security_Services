namespace StarSecurityServices.DTOs
{
    public abstract class AbstractMapper<T1, T2>
    {
        public abstract T2 Map(T1 o);
    }
}

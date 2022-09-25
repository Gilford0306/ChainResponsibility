namespace ChainResponsibility.Сheck
{
    public interface ICheck
    {
            ICheck SetNext(ICheck check);
            object Check(object request);
    }
}

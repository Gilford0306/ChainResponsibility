
namespace ChainResponsibility.Сheck
{
    abstract class AbstractCheck : ICheck
    {
        private ICheck _nextCheck;

        public ICheck SetNext(ICheck check)
        {
            this._nextCheck = check;
            return check;
        }

        public virtual object Check(object request)
        {
            if (this._nextCheck != null)
            {
                return this._nextCheck.Check(request);
            }
            else
            {
                return null;
            }
        }
    }
}
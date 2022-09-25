namespace ChainResponsibility.Сheck
{
    class UpperCh : AbstractCheck
    {
        public override object Check(object request)
        {
            if (!request.ToString().Any(Char.IsUpper))
            {
                return false;
            }
            else
            {
                return base.Check(request);
            }
        }
    }

}

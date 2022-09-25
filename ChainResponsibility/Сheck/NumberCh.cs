namespace ChainResponsibility.Сheck
{
    class NumberCh : AbstractCheck
    {
        public override object Check(object request)
        {
            if (!request.ToString().Any(Char.IsNumber))
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


namespace ChainResponsibility.Сheck
{
    class LengthCh : AbstractCheck
    {
        public override object Check(object request)
        {
            if (request.ToString().Length < 5)
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

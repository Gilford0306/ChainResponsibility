namespace ChainResponsibility.Сheck
{
    class SymbolCh : AbstractCheck
    {
        public override object Check(object request)
        {
            if (!request.ToString().Any(Char.IsSymbol))
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
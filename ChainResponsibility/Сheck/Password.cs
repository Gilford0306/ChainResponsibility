namespace ChainResponsibility.Сheck
{
    class Password : AbstractCheck
    {
        public string code { get; set; }
        public Password(string str)
        {
            code = str;
        }
        public override object Check(object request)
        {
            return true;
        }
        public void ClientCode(AbstractCheck check)
        {

            var result = check.Check(code);

            if (result == null)
            {
                Console.Write($"Password is good");
            }
            else
            {
                Console.WriteLine($" Password is not good.");
            }

        }
    }

}


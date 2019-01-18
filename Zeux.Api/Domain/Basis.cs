namespace Zeux.Api.Domain
{
    public class Basis
    {
        public static Basis Yearly = new Basis { Code = "Year", Name = "Yearly" };

        public string Code { get; private set; }

        public string Name { get; private set; }
    }
}
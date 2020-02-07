using System;
using Xunit;

namespace TestesDeUnidade.ObjetosDeValorTests.Idades
{
    public sealed class DatasSetup : TheoryData<int, int, int, int>
    {
        public DatasSetup()
        {
            Add(1997, 10, 25, 22);
            Add(1997, 1, 1, 23);
            Add(1997, 2, 1, 23);
            Add(1997, DateTime.Today.Month, DateTime.Today.AddDays(1).Day, 22);
            Add(1997, DateTime.Today.Month, DateTime.Today.Day, 23);
        }
    }
}

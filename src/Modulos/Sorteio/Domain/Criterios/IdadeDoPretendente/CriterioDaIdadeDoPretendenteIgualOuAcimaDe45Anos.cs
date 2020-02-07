namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public sealed class CriterioDaIdadeDoPretendenteIgualOuAcimaDe45Anos : CriterioDaIdadeDoPretendente
    {
        public override int Pontuacao => 3;
        public CriterioDaIdadeDoPretendenteIgualOuAcimaDe45Anos(int idade) : base(idade, idade => idade >= 45) { }
    }
}

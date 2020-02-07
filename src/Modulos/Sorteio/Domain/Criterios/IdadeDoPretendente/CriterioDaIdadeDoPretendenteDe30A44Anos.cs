namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public sealed class CriterioDaIdadeDoPretendenteDe30A44Anos : CriterioDaIdadeDoPretendente
    {
        public override int Pontuacao => 2;
        public CriterioDaIdadeDoPretendenteDe30A44Anos(int idade) : base(idade, idade => idade >= 30 && idade <= 44) {}
    }
}

namespace Sorteio.Domain.Criterios.IdadeDoPretendente
{
    public sealed class CriterioDaIdadeDoPretendenteAbaixoDos30Anos : CriterioDaIdadeDoPretendente
    {
        public override int Pontuacao => 1;
        public CriterioDaIdadeDoPretendenteAbaixoDos30Anos(int idade) : base(idade, idade => idade < 30) {}
    }
}

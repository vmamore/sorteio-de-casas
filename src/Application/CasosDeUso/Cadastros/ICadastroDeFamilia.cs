using Application.CasosDeUso.Cadastros.Dtos;
using Core.Domain;
using System.Threading.Tasks;

namespace Application.CasosDeUso.Cadastros
{
    public interface ICadastroDeFamilia
    {
        Task<Resultado> Cadastrar(FamiliaDto familiaDto);
    }
}

using Application.Cadastro.Dto.Acesso;
using AutoMapper;
using Domain.Acesso.UsuarioAgreggate;
using Domain.Acesso.UsuarioAgreggate.ValueObjects;

namespace Application.AutoMapper.Mappers
{
    public class AcessoDomainToDtoMapping : Profile
    {
        public AcessoDomainToDtoMapping()
        {
            CreateMap<Usuario, UsuarioDto>()
                .ForMember(cfg => cfg.Login, (map) => map.MapFrom(o => o.Login))
                .ForMember(cfg => cfg.Senha, (map) => map.MapFrom(o => o.Senha.Valor))
                .ForMember(cfg => cfg.Role, (map) => map.MapFrom(o => o.Role));
        }
    }
}
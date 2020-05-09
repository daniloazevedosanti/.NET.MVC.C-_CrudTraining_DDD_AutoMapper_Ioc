
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ClienteViewModel, Cliente>();
                cfg.CreateMap<ProdutoViewModel, Produto>();

            });

            Mapper.AssertConfigurationIsValid();
            
        }
    }
}
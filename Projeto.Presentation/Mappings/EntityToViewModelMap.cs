using AutoMapper;
using Projeto.Entities;
using Projeto.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mappings
{
    public class EntityToViewModelMap:Profile
    {
        public EntityToViewModelMap()
        {
            CreateMap<Cliente, ClienteConsultaViewModel>();
        }
    }
}

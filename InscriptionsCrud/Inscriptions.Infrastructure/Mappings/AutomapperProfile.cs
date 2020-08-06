using AutoMapper;
using Inscriptions.Core.DTOs;
using Inscriptions.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inscriptions.Infrastructure.Mappings
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Inscription, InscriptionDto>();
            CreateMap<InscriptionDto, Inscription>();
        }
    }
}

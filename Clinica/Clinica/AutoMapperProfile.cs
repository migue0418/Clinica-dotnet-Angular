using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Clinica.DTOs;
using Clinica.Entities;


namespace Clinica
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()  //Pasar de DTO a entidad, y de entidad a DTO
        {
            CreateMap<Usuario, UsuarioDTO>();

            CreateMap<UsuarioDTO, Usuario>();

            CreateMap<Paciente, PacienteDTO>();

            CreateMap<PacienteDTO, Paciente>();

            CreateMap<Medico, MedicoDTO>();

            CreateMap<MedicoDTO, Medico>();

            CreateMap<Diagnostico, DiagnosticoDTO>();

            CreateMap<DiagnosticoDTO, Diagnostico>();

            CreateMap<Cita, CitaDTO>();

            CreateMap<CitaDTO, Cita>();
        }
    }
}

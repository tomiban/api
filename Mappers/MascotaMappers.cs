using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Mascotas;
using api.Models;

namespace api.Mappers
{
    public static class MascotaMappers
    {
        public static MascotaDto ToMascotaDto(this Mascota mascota)
        {
            return new MascotaDto
            {
                Id = mascota.Id,
                Nombre = mascota.Nombre,
                Especie = mascota.Especie,
                Sexo = mascota.Sexo,
                Edad = mascota.Edad,
                Color = mascota.Color,
                Peso = mascota.Peso,
                Raza = mascota.Raza,
                
            };
        }

        public static Mascota FromDtoToMascota(this CreateMascotaDto mascotaDto)
        {
            return new Mascota
            {
                Nombre = mascotaDto.Nombre,
                Especie = mascotaDto.Especie,
                Sexo = mascotaDto.Sexo,
                Edad = mascotaDto.Edad,
                Color = mascotaDto.Color,
                Peso = mascotaDto.Peso,
                Raza = mascotaDto.Raza,
            };
        }
    }
}

using System.Collections.Generic;
using Sistema.Data.Converter;
using Sistema.Model;
using System.Linq;
using Sistema.Data.VO;
using System;

namespace Sistema.Data.Converters
{
    public class UserDadosConverter : IParser<UserDadosVO, User>, IParser<User, UserDadosVO>
    {

        public User Parse(UserDadosVO origin)
        {
            if (origin == null) return new User();
            return new User
            {
                Id = origin.Id,
                Email = origin.Email,
                AccessKey = origin.AccessKey,
                Cpf = origin.Cpf,
                Nome = origin.Nome,
                Perfil = origin.Perfil,
                Pontos = origin.Pontos

            };
        }

        public UserDadosVO Parse(User origin)
        {
            if (origin == null) return new UserDadosVO();
            return new UserDadosVO
            {
                Id = origin.Id,
                Email = origin.Email,
                AccessKey = origin.AccessKey,
                Cpf = origin.Cpf,
                Nome = origin.Nome,
                Pontos = origin.Pontos,
                Perfil = origin.Perfil

            };
        }

        public List<User> ParseList(List<UserDadosVO> origin)
        {
            if (origin == null) return new List<User>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<UserDadosVO> ParseList(List<User> origin)
        {
            if (origin == null) return new List<UserDadosVO>();
            return origin.Select(item => Parse(item)).ToList();
        }

    }
}

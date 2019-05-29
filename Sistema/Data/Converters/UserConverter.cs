using System.Collections.Generic;
using Sistema.Data.Converter;
using Sistema.Model;
using System.Linq;
using Sistema.Data.VO;

namespace Sistema.Data.Converters
{

    public class UserConverter : IParser<UserVO, User>, IParser<User, UserVO>
    {
        public User Parse(UserVO origin)
        {
            if (origin == null) return new User();
            return new User
            {
                Email = origin.Email,
                AccessKey = origin.AccessKey
      
            };
        }

        public UserVO Parse(User origin)
        {
            if (origin == null) return new UserVO();
            return new UserVO
            {
                Email = origin.Email,
                AccessKey = origin.AccessKey

            };
        }

        public List<User> ParseList(List<UserVO> origin)
        {
            if (origin == null) return new List<User>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<UserVO> ParseList(List<User> origin)
        {
            if (origin == null) return new List<UserVO>();
            return origin.Select(item => Parse(item)).ToList();
        }

    }
}

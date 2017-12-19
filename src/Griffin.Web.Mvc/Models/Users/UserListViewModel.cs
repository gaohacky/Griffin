using System.Collections.Generic;
using Griffin.Roles.Dto;
using Griffin.Users.Dto;

namespace Griffin.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
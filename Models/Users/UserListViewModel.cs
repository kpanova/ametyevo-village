using System.Collections.Generic;
using ametyevo-village.Roles.Dto;

namespace ametyevo-village.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

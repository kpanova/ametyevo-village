using System.Collections.Generic;
using ametyevo-village.Roles.Dto;

namespace ametyevo-village.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}

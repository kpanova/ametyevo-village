using System.Collections.Generic;
using ametyevo-village.Roles.Dto;

namespace ametyevo-village.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
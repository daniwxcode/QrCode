using QrCode.Application.Responses.Identity;
using System.Collections.Generic;

namespace QrCode.Application.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public IList<UserRoleModel> UserRoles { get; set; }
    }
}
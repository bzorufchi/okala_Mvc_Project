using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
namespace bahare_zorufchi.Models
{
    public class MyRoleProvider : RoleProvider
    {
        okalaDBEntities db = new okalaDBEntities();

        public override bool IsUserInRole(string UserName , string RoleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            var role = (from u in db.Users
                        join r in db.Roles
                            on u.RoleID equals r.ID
                        where u.UserName == username
                        select r.RoleName);
            return role.ToArray();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName { get; set; }


    }
}
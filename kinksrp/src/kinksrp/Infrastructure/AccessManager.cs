using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Infrastructure
{
    /**
     * Works with bits of UInt64 to add and remove permissions
     */
    public static class AccessManager
    {
        // 0000000000000000000000000000000000000000000000000000000000000000
        public enum Permission
        {
            AdminProtection = 0,
            AdminPanel = 1,
            Ban = 2,
            Unban = 3,
            Banned = 4,
            ReadOnly = 5,
            Registred = 6,
            EditUsers = 7,
            EditPosts = 8,
            Premium = 9,
        }

        public static bool hasPermission(long accessFlags, Permission permission)
        {
            return (accessFlags & (1 << (int)permission)) != 0;
        }

        public static long addPermission(long accessFlags, Permission permission)
        {
            return accessFlags |= 1 << (int)permission;
        }

        public static long takePermission(long accessFlags, Permission permission)
        {
            return accessFlags &= ~(1 << (int)permission);
        }
    }
}

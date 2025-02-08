using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Security.Principal;

using static GH3MLGUI.Common.Directories;
using static GH3MLGUI.Common.Utils;

namespace GH3MLGUI.Common;

public static class ProgramArguments
{
    public const string SetAccessArgument = "--SetAccess";
    public static readonly Dictionary<string, Func<ErrorCode>> ArgumentBindings = new Dictionary<string, Func<ErrorCode>>
    {
        {  SetAccessArgument, SetAccess }
    };

    public static ErrorCode SetAccess()
    {
        if (!IsAdministrator)
        {
            DisplayError("This application requires elevation.");
            return ErrorCode.ERROR_PRIVILEGE_NOT_HELD;
        }

        DirectoryInfo gh3DirInfo = new DirectoryInfo(GH3Directory);

        var security = gh3DirInfo.GetAccessControl();

        security.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
        gh3DirInfo.SetAccessControl(security);

        return ErrorCode.ERROR_SUCCESS;
    }

    public static ErrorCode ParseArguments(string[] arguments)
    {
        Func<ErrorCode>? value = null;
        foreach (var arg in arguments)
        {
            if (ArgumentBindings.TryGetValue(arg, out value))
            {
                var error = value.Invoke();
                if (error != ErrorCode.ERROR_SUCCESS)
                    return error;
            }
        }

        return ErrorCode.ERROR_SUCCESS;
    }
}

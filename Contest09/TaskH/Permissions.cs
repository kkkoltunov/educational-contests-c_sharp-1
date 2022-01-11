using System;

[Flags]
public enum Permissions
{
    Default = 1,
    UserRead = 2,
    UserWrite = 4,
    UserExecute = 8,
    GroupRead = 16,
    GroupWrite = 32,
    GroupExecute = 64,
    EveryoneRead = 128,
    EveryoneWrite = 256,
    EveryoneExecute = 512
}
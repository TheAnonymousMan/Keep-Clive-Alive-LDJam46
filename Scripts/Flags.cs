using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Flags
{
    public static bool Kill = true;
    public static bool Save = false;
    public static bool Eject = false;

    public static void flagReset()
    {
        Kill = true;
        Save = false;
        Eject = false;
    }
}

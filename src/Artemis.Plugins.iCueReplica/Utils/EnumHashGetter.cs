using System;
using System.Collections.Generic;

namespace Artemis.Plugins.iCueReplica.Utils;


/**
 * Utility class to optimize hash codes for Enum values.
 */
internal class EnumHashGetter: IEqualityComparer<Enum>
{
    public static readonly EnumHashGetter Instance = new();

    private EnumHashGetter()
    {
    }

    public bool Equals(Enum? x, Enum? y)
    {
        return object.Equals(x, y);
    }

    public int GetHashCode(Enum obj)
    {
        return Convert.ToInt32(obj);
    }
}
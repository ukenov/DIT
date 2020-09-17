using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Using RadialListId to identify the type of of RadialList 
/// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
/// </summary>

[SerializeField]
public class RadialList: IEquatable<RadialList>
{
    public string RadialListName { get; set; }
    public int RadialListId { get; set; }

    public override string ToString()
    {
        return "ID: " + RadialListId + " Name: " + RadialListName;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        RadialList objAsRadialList = obj as RadialList;
        if (objAsRadialList == null) return false;
        else return Equals(objAsRadialList);
    }
    public override int GetHashCode()
    {
        return RadialListId;
    }
    public bool Equals(RadialList other)
    {
        if (other == null) return false;
        return (this.RadialListId.Equals(other.RadialListId));
    }

}

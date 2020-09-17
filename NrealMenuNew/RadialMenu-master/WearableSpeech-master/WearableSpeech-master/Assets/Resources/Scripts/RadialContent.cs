using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RadialContent
{
    public List<string> name;
    public int value;

    // constructor to allocate the values 
    public RadialContent(List<string> name, int value)
    {
        this.name = name;
        this.value = value;
    }

}

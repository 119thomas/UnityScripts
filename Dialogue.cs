using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* we mark as serializable so it will show up in the inspector */
[System.Serializable]

/* this class represents a specific character's dialogue */
public class Dialogue
{
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
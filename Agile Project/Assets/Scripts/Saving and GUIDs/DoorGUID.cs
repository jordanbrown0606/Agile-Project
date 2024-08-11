using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGUID : GUIDObject
{
    protected bool _isOpen;

    public bool IsOpen { get { return _isOpen; } set { _isOpen = value; } }
}

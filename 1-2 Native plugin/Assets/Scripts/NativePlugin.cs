using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class NativePlugin : MonoBehaviour
{
    [DllImport("MyPlugin")] private static extern string TwoStrings();


}

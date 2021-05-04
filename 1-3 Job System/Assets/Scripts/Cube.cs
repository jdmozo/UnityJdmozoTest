using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public struct Data
    {
        private int _rChannel;

        public Data(Cube cube)
        {
            _rChannel = (int)cube.GetComponent<Renderer>().material.color.r;
        }

        public void Update()
        {

        }
    }
}

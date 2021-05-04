using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace jdmozo
{
    public struct CubeJob : IJobParallelFor
    {
        public NativeArray<Cube.Data> CubeDataArray;

        public void Execute(int index)
        {
            var data = CubeDataArray[index];
            data.Update();
            CubeDataArray[index] = data;
        }
    }

    public class CubeManager: MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI rChannelText;
        [SerializeField] private List<Cube> cubes;
        private int rchannel;

        private void Start()
        {
            rChannelText.text = "R CHANNEL: <color=#FFF>"+ rchannel + "</color>";
        }

        private void Update()
        {
            var cubeDataArray = new NativeArray<Cube.Data>(cubes.Count, Allocator.TempJob);
            for (int i = 0; i < cubes.Count; i++)
            {
                cubeDataArray[i] = new Cube.Data(cubes[i]);
            }
            var job = new CubeJob
            {
                CubeDataArray = cubeDataArray
            };
            var jobHandle = job.Schedule(cubes.Count, 1);
            jobHandle.Complete();
            cubeDataArray.Dispose();
        }
    }
}

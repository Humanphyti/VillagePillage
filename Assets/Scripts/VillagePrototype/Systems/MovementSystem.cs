using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using Unity.Jobs;
using UnityEngine;

public class MovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        throw new System.NotImplementedException();
    }

    [BurstCompile]

    //[ComputeJobOptimization]
    private struct MovementJob : IJobForEach<Translation, Rotation, MoveSpeedComponent>
    {
        public void Execute(ref Translation c0, ref Rotation c1, ref MoveSpeedComponent c2)
        {
            throw new System.NotImplementedException();
        }
    }
}

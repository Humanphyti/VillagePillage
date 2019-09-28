using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Rendering;
using Unity.Mathematics;
using UnityEditor.Build.Content;
using UnityEngine.SocialPlatforms;

public class EntityControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Mesh mesh;
    [SerializeField] private Material mat;
    private void Start()
    {
        EntityManager entityManager = World.Active.EntityManager;

        EntityArchetype villager = entityManager.CreateArchetype();
        //EntityArchetype jarl = entityManager.CreateArchetype(typeof(VillagerComponent));


        NativeArray<Entity> entityArray = new NativeArray<Entity>(100000, Allocator.Temp);
        entityManager.CreateEntity(villager, entityArray);


        for (int i = 0; i < entityArray.Length; i++)
        {
            Entity entity = entityArray[i];
            entityManager.SetComponentData(entity, new VillagerComponent
            {
                level = UnityEngine.Random.Range(10,20),
                moveSpeed = UnityEngine.Random.Range(1f, 2f),
            });
        }
    }
}

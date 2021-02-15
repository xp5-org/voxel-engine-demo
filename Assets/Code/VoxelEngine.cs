using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelEngine : MonoBehaviour
{
    private World _world = new World();
    private System.Random _random = new System.Random();
    public Material Material;

    // Start is called before the first frame update
    void Start()
    {
        // Create GameObject that will hold a Chunk
        var chunkGameObject = new GameObject("Chunk 0, 0, 0");
        chunkGameObject.transform.parent = transform.parent;
        // Add Chunk to GameObject
        var chunk = chunkGameObject.AddComponent<Chunk>();
        // Add chunk to world at position 0, 0, 0
        _world.Chunks.Add(new ChunkId(0, 0, 0), chunk);
        // Set material
        chunkGameObject.GetComponent<MeshRenderer>().material = Material;
        

    }

    // Update is called once per frame
    void Update()
    {
        // Update a random block to random type
        // var x = _random.Next(0, 16);
        // var y = _random.Next(0, 3);
        // var z = _random.Next(0, 16);


        // _world[x, y, z] = voxelType;
        bool finished = false;


        if (finished == false)
        {
            var voxelType = (UInt16)_random.Next(2, 2);
            int[,,] arrayOfMessages = new int[16, 16, 16];
            for (int x = 0; x < arrayOfMessages.GetLength(0); x++)
            {
                for (int y = 0; y < arrayOfMessages.GetLength(1); y++)
                {
                    for (int z = 0; z < arrayOfMessages.GetLength(2); z++)
                    {
                        _world[x, y, z] = voxelType;

                    }
                }
                finished = true;
            }
        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    TerrainSpawner terrainSpawner;

    // Start is called before the first frame update
    void Start()
    {
        terrainSpawner = GetComponent<TerrainSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        terrainSpawner.MoveTerrain();
    }
}

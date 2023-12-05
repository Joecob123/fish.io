using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public List<GameObject> terrains;

    private float offset = 80f;

    // Start is called before the first frame update
    void Start()
    {
        if (terrains != null && terrains.Count > 0)
        {
            terrains = terrains.OrderBy(r => r.transform.position.x).ToList();
        }
    }

    public void MoveTerrain()
    {
        GameObject movedTerrain = terrains[0];
        terrains.Remove(movedTerrain);
        float newX = terrains[terrains.Count - 1].transform.position.x + offset;
        movedTerrain.transform.position = new Vector3(newX, 0, 0);
        terrains.Add(movedTerrain);
    }    
}

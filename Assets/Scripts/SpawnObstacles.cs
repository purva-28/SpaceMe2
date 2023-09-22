using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject planet;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    // Update is called once per frame
    void Update()
    {
        if(Time.time>spawnTime)
        {
        Spawn();
        spawnTime=Time.time+timeBetweenSpawn;
        }
    
    }
    void Spawn()
    {
        float randomX=Random.Range(minX,maxX);
        float randomY=Random.Range(minY,maxY);
        GameObject selectedObstacle = Random.Range(0f, 1f) > 0.5f ? obstacle : planet;
        
        Instantiate(selectedObstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}

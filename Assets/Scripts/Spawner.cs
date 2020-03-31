using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float minX;
    public float minY;
    public float minZ;
    public float maxX;
    public float maxY;
    public float maxZ;

    private float spawnX;
    private float spawnY;
    private float spawnZ;

    public bool canSpawn = true;
    public GameObject banana;
    void OnEnable()
    {
        StartCoroutine(Spawner1());
    }

    IEnumerator Spawner1()
    {
        float spawnDelay = Random.Range(0.1f, 0.5f);
        yield return new WaitForSeconds(spawnDelay);
        spawnX = Random.Range(minX, maxX);
        spawnY = Random.Range(minY, maxY);
        spawnZ = Random.Range(minZ, maxZ);
        Instantiate(banana, new Vector3(transform.localPosition.x + spawnX, transform.localPosition.y + spawnY, transform.localPosition.z + spawnZ), Quaternion.identity);
        StartCoroutine(Spawner1());

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(transform.localPosition.x + minX, transform.localPosition.y + minY, transform.localPosition.z + minZ), new Vector3(transform.localPosition.x + maxX, transform.localPosition.y + maxY, transform.localPosition.z + maxZ));
    }

    
}

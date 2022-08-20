using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    private float _spawnRange = 45;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMeteor", 5.0f, 5.0f); //spawns a meteor every 5 seconds.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if space key pressed...
        {
            SpawnMeteor();                  //instantiate a meteor.
        }
    }

    // For Instantiate Meteors
    void SpawnMeteor()
    {

        Instantiate(meteorPrefab, GenerateSpawnPosition(), meteorPrefab.transform.rotation);
    }

    // Returns random spawning positions for meteors. Random position coordinates restricted due camera view.
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-_spawnRange, _spawnRange);
        float spawnPosY = Random.Range(-_spawnRange, _spawnRange);
        float spawnPosZ = Random.Range(-_spawnRange, _spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        return randomPos;
    }


}

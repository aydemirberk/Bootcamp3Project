using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject meteorPrefab;
    public GameObject panel;
    private float spawnRange = 45;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMeteor", 5.0f, 5.0f); //spawns a meteor every 5 seconds.
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) //Every time pressing space key, spawns a meteor.
            SpawnMeteor();

    }


    //Class for Spawn Meteors
    void SpawnMeteor()
    {
        Instantiate(meteorPrefab, GenerateSpawnPosition(), meteorPrefab.transform.rotation);

    }

    
        // Returns random positions for meteors. Random position coordinates restricted due camera view.
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        return randomPos;
    }



        // Opens Planet Info Text. Referenced at Button Script
    public void OpenPanel()
    {
        panel.gameObject.SetActive(true);
        
    }

        // Closes Planet Info Text. Referenced at Button Script.
    public void ClosePanel()
    {
        panel.gameObject.SetActive(false);
        
    }
}

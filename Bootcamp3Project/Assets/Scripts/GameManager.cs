using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject meteorPrefab;
    public GameObject panel;
    private float spawnRange = 45;
    private string clickedPlanetName;
    public TextMeshProUGUI planetName;
    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        InvokeRepeating("SpawnMeteor", 5.0f, 5.0f); //spawns a meteor every 5 seconds.
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) //if space key pressed...
        {
            SpawnMeteor();                  //instantiate a meteor.
        }


        if (Input.GetMouseButtonDown(0)) // if left button pressed...
        {
            OpenPanel();                //opens UI panel.
        }

    }

    //Class for Instantiate Meteors
    void SpawnMeteor()
    {

         Instantiate(meteorPrefab, GenerateSpawnPosition(), meteorPrefab.transform.rotation);
    }

    
    // Returns random spawning positions for meteors. Random position coordinates restricted due camera view.
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        return randomPos;
    }


    // Opens Panel (On Click to Planet)
    private void OpenPanel()
    {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; //Code for detecting click on an object.

            if (Physics.Raycast(ray, out hit)) //if clicked to a game object...
            {
                isGameActive = false;
                panel.gameObject.SetActive(true);  //opens UI panel
                clickedPlanetName = hit.transform.gameObject.name;
                planetName.text = clickedPlanetName;
            }
    }

        // Closes Panel. 
    public void ClosePanel()
    {
        panel.gameObject.SetActive(false);
        
    }
}

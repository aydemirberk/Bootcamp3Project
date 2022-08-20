using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panel;
    private string clickedPlanetName;
    public TextMeshProUGUI planetName;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) // if left button pressed...
        {
            OpenPanel();                //opens UI panel.
        }

    }

    // Opens Panel (On Click to Planet)
    private void OpenPanel()
    {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; //Code for detecting click on an object.

            if (Physics.Raycast(ray, out hit)) //if clicked to a game object...
            {
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

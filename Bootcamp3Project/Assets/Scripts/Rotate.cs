using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed;
    float totalRotationAngle;


    // Update is called once per frame
    void Update()
    {
        // For rotating planets.
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);


        // Calculates total rotation angle and writes to console if planet has completed the revolution.
        totalRotationAngle += Time.deltaTime * rotationSpeed;

        if (totalRotationAngle >= 360)
        {
            totalRotationAngle = 0;
            Debug.Log($"{gameObject.name} has completed one revolution." );
        }
    }
}

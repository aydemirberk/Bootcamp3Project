using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialMovement : MonoBehaviour
{
    public float rotationSpeed;
    public Transform targetObject;

    private void Update()
    {
        if (targetObject == null)
            return;

        transform.RotateAround(targetObject.position, Vector3.up, Time.deltaTime * rotationSpeed);
    }

}

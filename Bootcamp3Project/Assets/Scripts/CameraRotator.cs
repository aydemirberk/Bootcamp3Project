using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        StartCoroutine(RotateCamera());
    }
    private IEnumerator RotateCamera()
    {
        yield return new WaitForSeconds(3.0f);
        transform.Rotate(new Vector3(0, -rotationSpeed, 0));
    }
}

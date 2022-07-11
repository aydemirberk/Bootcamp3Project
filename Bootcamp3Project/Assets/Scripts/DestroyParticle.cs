using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(DestroyParticles());
    }
    IEnumerator DestroyParticles()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}

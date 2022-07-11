using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed;
    private Rigidbody meteorRb;
    private GameObject[] planets;
    private GameObject targetPlanet;
    public ParticleSystem explosionParticle;


    // Start is called before the first frame update
    void Start()
    {
        meteorRb = GetComponent<Rigidbody>();
        planets = GameObject.FindGameObjectsWithTag("Planets");
        targetPlanet = planets[Random.Range(0, planets.Length)];
        StartCoroutine(DestroyMeteor());


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 lookDirection = (targetPlanet.transform.position - transform.position).normalized;
        meteorRb.AddForce(lookDirection * speed);

        


        //if (transform.position.y < -10)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosionParticle, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
        
    }

    IEnumerator DestroyMeteor()
    {
        yield return new WaitForSeconds(2);
        Instantiate(explosionParticle, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
        

    } 

        
}
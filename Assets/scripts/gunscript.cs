using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunscript : MonoBehaviour
{
    public Camera fpscam;
    public float range;
    public ParticleSystem impactpoint;
    public float damage = 10f;
    public float bulletforce = 10f;
    public AudioSource gunshot;
    
    public void ShootButton()
    {
        Shoot();
        
    }
    public void Shoot()
    {
        gunshot.Play();
        
        impactpoint.Play();
        
        Debug.Log("button is working");
        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            
            Debug.Log(hit.transform.name);
            //Destroy(hit.transform.gameObject);

            chase chasee = hit.transform.GetComponent<chase>();
            if( chasee != null)
            {
                chasee.TakeDamage(damage);
            }
            if( hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * bulletforce);

            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

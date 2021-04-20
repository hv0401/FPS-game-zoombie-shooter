using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class chase : MonoBehaviour
{
    Transform player;
    public Animator anim;
    

    public float health = 50f;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        if( health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        anim.SetBool("Death", true);
        Destroy(gameObject, 2.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = player.position - this.transform.position;
        //float angle = Vector3.Angle(direction, this.transform.forward);
        if(Vector3.Distance(player.position, this.transform.position) < 1000 )
        {
            
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                              Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("Idle", false);

            if(direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.08f);
                anim.SetBool("Walking", true);
                anim.SetBool("Attacking", false);
            }
            else
            {
                anim.SetBool("Walking", false);
                anim.SetBool("Attacking", true);

            }
        }
        else
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Walking", false);
            anim.SetBool("Attacking", false);
        }
        
    }
}

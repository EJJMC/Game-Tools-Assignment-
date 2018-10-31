using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class failedscript2 : MonoBehaviour {

    public Transform player;
    public GameObject Dplayer;
    static Animator anim;

    public int health = 1;
    int DestroyTime = 4;

    void Start()
    {
        anim = GetComponent<Animator>();

    }


    void Update()
    {
        Die();


        if (Vector3.Distance(player.position, this.transform.position) < 2)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);


            anim.SetBool("Idle", false);
            if (direction.magnitude > 1)
            {
                this.transform.Translate(0, 0, 0.009f);
                anim.SetBool("Walking", true);
                anim.SetBool("Attacking", false);
            }

            else if (direction.magnitude < 1)
            {
                anim.SetBool("Attacking", true);
                anim.SetBool("Walking", false);
            }
        }

        else
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Walking", false);
            anim.SetBool("Attacking", false);
        }
    }

    void Die()
    {
        DestroyTime = 2;

        if (health == 0)
        {
            anim.SetTrigger("dead");

            Destroy(gameObject, DestroyTime);

            Debug.Log("ya dead son");
        }
    }





}

    */
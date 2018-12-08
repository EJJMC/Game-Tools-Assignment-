using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public Transform player;
    public GameObject Dplayer;
    static Animator anim;

    [SerializeField] AudioClip audiodeath;

    private AudioSource deathSfx;

    private PlayerControl m_playerScript;


    void Start()
    {
        anim = GetComponent<Animator>();
        m_playerScript = FindObjectOfType<PlayerControl>();
        deathSfx = GetComponent<AudioSource>();

    }


    void Update()
    {

        if (Vector3.Distance(player.position, this.transform.position) < 2)  //Sets distance for when zombi follows player
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);


            anim.SetBool("Idle", false); // When player is in range of the zombi
            if (direction.magnitude > 1)
            {
                this.transform.Translate(0, 0, 0.009f);
                anim.SetBool("Walking", true);
                anim.SetBool("Attacking", false);
            }

            else if (direction.magnitude < 1) // If zombi next to player
            {
                anim.SetBool("Attacking", true);
                anim.SetBool("Walking", false);
                
               

            }
        }

        else
        {
            anim.SetBool("Idle", true); // if Zombi is not near the player
            anim.SetBool("Walking", false);
            anim.SetBool("Attacking", false);
        }
    }

    IEnumerator hit()
    {
        yield return new WaitForSecondsRealtime(1f); // zombi damaging the player
        m_playerScript.health = m_playerScript.health - 1;

        Debug.Log(m_playerScript.health);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player") // if zombi is hit by player
            {
            StartCoroutine(hit());
        }
    }

    public void zombidie() // plays death sound effect
    {
        playSsound(); 
    }

    private void playSsound()
    {
    deathSfx.PlayOneShot(audiodeath);

    }
}

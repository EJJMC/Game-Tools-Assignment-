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

    IEnumerator hit()
    {
        yield return new WaitForSecondsRealtime(1f);
        m_playerScript.health = m_playerScript.health - 1;

        Debug.Log(m_playerScript.health);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
            {
            StartCoroutine(hit());
        }
    }

    public void zombidie()
    {
        playSsound();
    }

    private void playSsound()
    {
    deathSfx.PlayOneShot(audiodeath);

    }
}

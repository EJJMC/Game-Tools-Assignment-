﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] AudioClip audiopower;
    private Animator m_animator;
    private GameObject enemy;
     public Transform zombi;
    private Animator m_ane;
    // public GameObject SpawnItem;
    // private Transform SpawnPos;

    Shader shader1;
    Shader shader2;
    Shader shader3;
    Renderer rend;


    public GameObject pickup;


  

    private AudioSource powerSfx;


    public int health = 5;
    int DestroyTime = 4;


    void Start()
    {
        m_animator = GetComponent<Animator>();

        // Instantiate(SpawnItem, SpawnPos);

        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("Power up");
        shader2 = Shader.Find("Default");
        shader3 = Shader.Find("Charge up");


    }



    void Update()
    {

        Die();

        float zombidist = Vector3.Distance(zombi.position, transform.position); // so zombi follows player

        float m_turn = Input.GetAxis("Horizontal");
        m_animator.SetFloat("turn", m_turn);

        float m_forward = Input.GetAxis("Vertical");
        m_animator.SetFloat("forward", m_forward);



        bool m_jump = Input.GetButtonDown("Jump"); // jumping 

        if (m_jump)
        {
            m_animator.SetTrigger("Jump");
        }

        //attacking animations

        bool m_kick = Input.GetKeyDown(KeyCode.M);
        m_animator.SetBool("Kick", m_kick);

        bool m_punch = Input.GetKeyDown(KeyCode.V);
        m_animator.SetBool("Punching", m_punch);

        bool m_Crossp = Input.GetKeyDown(KeyCode.B);
        m_animator.SetBool("CrossPunch", m_Crossp);

        bool m_elbow = Input.GetKeyDown(KeyCode.N);
        m_animator.SetBool("Elbow", m_elbow);

        bool m_Parry = Input.GetKeyDown(KeyCode.P);
        m_animator.SetBool("Parrying", m_Parry);

        //Health gain
        bool m_Charge = Input.GetKeyDown(KeyCode.H);
        m_animator.SetBool("Charge up", m_Charge);

        //pickup animation
        bool m_pick = Input.GetKeyDown(KeyCode.C);
        m_animator.SetBool("Pick", m_pick);




        //Killing zombi
          if ((Input.GetKeyDown(KeyCode.M)) && zombidist < 2)
          {

              m_kick = true;

             // m_ane.SetTrigger("dead");

          }



          if ((Input.GetKeyDown(KeyCode.V)) && zombidist < 2)
          {

              m_punch = true;

            //  m_ane.SetTrigger("dead");

        }

        if ((Input.GetKeyDown(KeyCode.B)) && zombidist < 2)
          {

              m_Crossp = true;

            //  m_ane.SetTrigger("dead");

        }

        if ((Input.GetKeyDown(KeyCode.N)) && zombidist < 2)
          {

              m_elbow = true;

            //   m_ane.SetTrigger("dead");

           


          }
          

        // Power Up script
        if ((Input.GetKeyDown(KeyCode.C)))
        {

            m_pick = true;

            Destroy(pickup, 2);

            {
                if (rend.material.shader == shader1)
                {
                    rend.material.shader = shader1;
                }
                else
                {
                    rend.material.shader = shader1;
                }
            }
        }

        if ((Input.GetKeyDown(KeyCode.H)))
        {

            m_Charge = true;

            health = health + 1;

            Debug.Log("health +1");

            if (rend.material.shader == shader2)
            {
                rend.material.shader = shader2;
            }
            else
            {
                rend.material.shader = shader2;
            }
        }
    }
       

  
    void Die()
    {
        DestroyTime = 5;

        if (health == 0)
        {
            m_animator.SetTrigger("death");

            //Destroy(gameObject, DestroyTime);
            SceneManager.LoadScene(5);
            Debug.Log("you died");
        }
    }

    public void powerup()
    {
        playAudio();
    }

    private void playAudio()
    {
        powerSfx.PlayOneShot(audiopower);

    }
}








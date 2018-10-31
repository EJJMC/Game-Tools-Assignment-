using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class FaildScript1 : MonoBehaviour {

    private Animator m_animator;
    public Animator m_ane;
    private Test m_zombieScript;
    public Transform zombi;


    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_zombieScript = FindObjectOfType<Test>();
    }

    void FixedUpdate()
    {

        float zombidist = Vector3.Distance(zombi.position, transform.position);

        float m_turn = Input.GetAxis("Horizontal");
        m_animator.SetFloat("turn", m_turn);

        float m_forward = Input.GetAxis("Vertical");
        m_animator.SetFloat("forward", m_forward);


        bool m_jump = Input.GetButtonDown("Jump");

        if (m_jump)
        {
            m_animator.SetTrigger("Jump");
        }


        bool m_kick = Input.GetKeyDown(KeyCode.M);
        m_animator.SetBool("Kick", m_kick);

        bool m_punch = Input.GetKeyDown(KeyCode.V);
        m_animator.SetBool("Punching", m_punch);

        bool m_Crossp = Input.GetKeyDown(KeyCode.B);
        m_animator.SetBool("CrossPunch", m_Crossp);

        bool m_elbow = Input.GetKeyDown(KeyCode.N);
        m_animator.SetBool("Elbow", m_elbow);




        if ((Input.GetKeyDown(KeyCode.M)) && zombidist < 2)
        {
            m_kick = true;

            m_zombieScript.health = m_zombieScript.health - 1;

            Debug.Log(m_zombieScript.health);



        }




    }

    */
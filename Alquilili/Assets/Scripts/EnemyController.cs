using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{

    private Animator enemyAnimator;
    private NavMeshAgent enemyAgent;
    private Transform playerTransform;
    //public GameObject vidasPlayer;
    public float lifeEnemy;
    public LifeBar barraDeVida;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        enemyAgent = GetComponent<NavMeshAgent>();

        //encuentra un player y obten el transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        //barraDeVida.life = 2;
        lifeEnemy = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (!enemyAgent.isOnNavMesh)
            return;
        if (lifeEnemy >= 0)
        {
            enemyAgent.SetDestination(playerTransform.position);
            //Debug.Log("Distance to player:"+enemyAgent.remainingDistance);

            //Debug.Log("propieda:" + barraDeVida.life);
            //enemyAnimator.SetFloat("Speed",enemyAgent.speed);
            if (enemyAgent.remainingDistance <= 5f && enemyAgent.hasPath)
            {
                enemyAnimator.SetFloat("Speed", 0f);
                //enemyAnimator.SetBool("Punch", true);
                enemyAnimator.SetTrigger("Mordida");


            }
            else
            {
                if(!enemyAnimator.GetCurrentAnimatorStateInfo(0).IsName("Muerte"))
                enemyAnimator.SetFloat("Speed", enemyAgent.speed);
                //enemyAnimator.SetBool("Mordida", false);


            }
        }
        if (lifeEnemy <= 0 && enemyAnimator.GetCurrentAnimatorStateInfo(0).IsName("Muerte"))
        {
            //enemyAnimator.SetBool("Muerte", false);
            if (enemyAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= .7f)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<PersonControlller>();
                Destroy(this.gameObject);
            }
            //Debug.Log("hola:"+enemyAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime);

            //enemyAnimator.SetBool("Muerte", false);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Espada")
        {
            Debug.Log("detecta colison");
            barraDeVida.life--;
            lifeEnemy--;
            if (lifeEnemy == 0)
            {
                enemyAnimator.SetBool("Muerte", true);
                
                //   StartCoroutine( muerteDeEnemigo());


            }
        }

    }

    //IEnumerator muerteDeEnemigo()
    //{
    //    //enemyAnimator.SetBool("Muerte", true);
    //  //  yield return new WaitUntil(()=>enemyAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime>=1f);


    //}

    public void OnDestroy()
    {
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PersonControlller : MonoBehaviour
{
    public float vida;
    public float experiencia=0;
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public LifeBar barra;
    public float x, y;

    public AudioClip[] sfx;
    private AudioSource pcSource;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        vida = 50;
        pcSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("velocidad1", x);
        anim.SetFloat("velocidad2", y);
        

        if (Input.GetMouseButtonDown(2))
        {
            anim.SetTrigger("ataque");
            pcSource.PlayOneShot(sfx[1]);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            pcSource.PlayOneShot(sfx[0]);
        }
        if (Input.GetMouseButtonDown(1))
        {
            pcSource.PlayOneShot(sfx[1]);
            anim.SetTrigger("ataque2");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            if (collision.transform.GetComponent<Animator>().GetBool("Mordida") == true)
            {
                vida -= 15;
                
                if (vida <= 0)
                {
                    SceneManager.LoadScene("Menu_Inicial", LoadSceneMode.Single);
                }
            }
        }

    }
}

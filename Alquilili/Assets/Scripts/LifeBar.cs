using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Image lifeBarImage;
    public Color fullLife;
    public Color emptyLife;
    public float animDuration;
    private float startTime;
    public float life=1.5f;
    public float fullLifeEnemy;
    private GameObject principal;
    // Start is called before the first frame update
    void Start()
    {
        lifeBarImage.color = fullLife;
        lifeBarImage.fillAmount = 1;
        startTime = Time.time;
        fullLifeEnemy = 2;
        principal=GameObject.FindGameObjectWithTag("Player");
    }
    public float getlife()
    {
        return life;
    }
    // Update is called once per frame
    void Update()
    {
        //tiempo de ejercuión entre duración anim
        //sii sobrepasa  usa 1

        //lifeBarImage.fillAmount = Mathf.Lerp(0, 1, (Time.time - startTime) / animDuration);

        //   lifeBarImage.color = Color.Lerp(emptyLife, fullLife, (Time.time - startTime) / animDuration);

        //lifeBarImage.fillAmount = 2;
        life=2*principal.GetComponent<PersonControlller>().vida/100;
        lifeBarImage.fillAmount = (life/fullLifeEnemy);
        lifeBarImage.color = Color.Lerp(emptyLife, fullLife, (life / fullLifeEnemy));
    }
}

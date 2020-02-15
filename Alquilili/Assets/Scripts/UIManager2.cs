using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
public class UIManager2 : MonoBehaviour
{

    public GameObject HUDPanel;
    public GameObject pausePanel;
    //huds elements
 
    //pause elements
    public Slider musicSlider;
    public Slider sfxSlider;
    //audio elements
    public AudioMixer mainMixer;
    private float musicVolume;
    private float sfxVolume;



    void Start()
    {
        CleanUI();
        HUDPanel.SetActive(true);

      
    }
    private void CleanUI()
    {
        HUDPanel.SetActive(false);
        pausePanel.SetActive(false);
    }
    public void ShowPause()
    {
        CleanUI();
        pausePanel.SetActive(true);
        mainMixer.GetFloat("musicaVolume", out musicVolume);
        musicSlider.value = musicVolume;

        mainMixer.GetFloat("sfxVolume", out sfxVolume);
        sfxSlider.value = sfxVolume;
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        //solo un script se encarga de esto la pause con timescale
        Time.timeScale = 1;
        CleanUI();
        HUDPanel.SetActive(true);
    }

    public void Exit()
    {
        //comunicaion con el json
    
        Application.Quit();


    }
    public void SetMusic(float volume)
    {
        mainMixer.SetFloat("musicVolume", volume);
    
    }

    public void SetSFX(float sfx)
    {
        mainMixer.SetFloat("sfxVolume", sfx);
      
    }

}

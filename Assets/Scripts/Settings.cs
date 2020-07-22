using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject stars1;
    public GameObject stars2;

    public GameObject windmills;
    public GameObject factories;
    public GameObject solarPanels;

    public Toggle musicToggle;
    public Toggle soundEffectsToggle;
    public Toggle starsToggle;
    public Toggle productionGraphicsToggle;

    public AudioSource music;
    public AudioSource soundEffects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleMusic()
    {
        if (musicToggle.isOn)
        {
            music.mute = true;
        }
        else
        {
            music.mute = false;
        }
    }
    public void toggleSoundEffects()
    {
        if (soundEffectsToggle.isOn)
        {
            soundEffects.mute = true;
        }
        else
        {
            soundEffects.mute = false;
        }
    }
    public void toggleStars()
    {
        if (starsToggle.isOn)
        {
            stars1.SetActive(false);
            stars2.SetActive(false);
        }
        else
        {
            stars1.SetActive(true);
            stars2.SetActive(true);
        }
    }
    public void toggleProductionGraphics()
    {
        if (productionGraphicsToggle.isOn)
        {
            windmills.SetActive(false);
            factories.SetActive(false);
            solarPanels.SetActive(false);
        }
        else
        {
            windmills.SetActive(true);
            factories.SetActive(true);
            solarPanels.SetActive(true);
        }
    }
   
}

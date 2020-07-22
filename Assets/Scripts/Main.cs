using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Text counterText;
    public Text energyPerSecondText;

    public SimpleHealthBar healthBar;

    public GameObject settingsPanel;
    public GameObject scrollList;
    public GameObject content;

    public static int numWindmills = 0;
    public static int numSolarPanels = 0;
    public static int numFactories = 0;
    public static int numTrees = 0;
    public static int numCoalMines = 0;

    public static int windmillDefaultEPS = 1;
    public static int solarPanelDefaultEPS = 1;

    public static int factoryDefaultEPS = 2;
    public static int coalMineDefaultEPS = 2;

    public int windmillEPS;
    public int solarPanelEPS;
    public int factoryEPS;
    public int coalMineEPS;

    

    public static float count = 1000;
    public float unsustainableCount = 0;

    public static float energyPerSecond = 0;

    public float unsustainableEPS;
    public int pollutionCap = 1000000;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("autoAddEnergy", 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = (((int)count).ToString("n0"));
        windmillEPS = numWindmills * windmillDefaultEPS;
        solarPanelEPS = numSolarPanels * solarPanelDefaultEPS;
        factoryEPS = numFactories * factoryDefaultEPS;
        coalMineEPS = numCoalMines * coalMineDefaultEPS;
        energyPerSecond = (factoryEPS + coalMineEPS + solarPanelEPS + windmillEPS);
        energyPerSecondText.text = ("EPS: " + Main.energyPerSecond.ToString("n1"));

        unsustainableEPS = factoryEPS + coalMineEPS;
    }
    
    public void buttonClick()
    { 
        count++;
        //SET POSITION OF CONTENT TO 0,0,0
        content.transform.localPosition = new Vector3(0f,0f,0f);
        Debug.Log("button clicked");
    }

    public void settingsClick()
    {
        Debug.Log("settings clicked");
        if (settingsPanel.activeInHierarchy == false)
        {
            settingsPanel.SetActive(true);
            ScrollRect rect = scrollList.GetComponent(typeof(ScrollRect)) as ScrollRect;
            rect.enabled = false;
        }
        else
        {
            settingsPanel.SetActive(false);
            ScrollRect rect = scrollList.GetComponent(typeof(ScrollRect)) as ScrollRect;
            rect.enabled = true;
        }
    }

    public void autoAddEnergy()
    {
        count += (energyPerSecond / 10);
        unsustainableCount += (unsustainableEPS) / 10;
        unsustainableCount -= (3/10); //default pollution deterioration
        unsustainableCount -= (numTrees/10);
        healthBar.UpdateBar(unsustainableCount, pollutionCap);

        Debug.Log("Unsustainable count: " + unsustainableCount);
    }

    public void buttonTest()
    {
        Debug.Log("Button clicked");
    }
}

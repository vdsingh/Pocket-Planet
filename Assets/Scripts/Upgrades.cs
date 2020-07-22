using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Upgrades : MonoBehaviour
{
    public GameObject windmillPrefab;
    public GameObject windmillParent;

    public GameObject solarPanelPrefab;
    public GameObject solarPanelParent;

    public GameObject treePrefab;
    public GameObject treeParent;
    public Sprite tree1, tree2, tree3, tree4;

    public GameObject factoryPrefab;
    public GameObject factoryParent;

    public GameObject coalMinePrefab;
    public GameObject coalMineParent;

    public GameObject[] windmillsList;
    // Start is called before the first frame update
    void Start()
    {
        windmillsList = GameObject.FindGameObjectsWithTag("Windmill");
        foreach(GameObject g in windmillsList)
        {
            g.SetActive(false);
        }
        Debug.Log("windmills list has " + windmillsList.Length + " objects.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buyWindmill()
    {

        if (Main.count >= 10)
        {
            Main.numWindmills++;
            Main.count -= 10;
            GameObject windmill;
            windmill = Instantiate(windmillPrefab, windmillParent.transform);
            if (Main.numWindmills <= 6) {
                windmillsList[Main.numWindmills - 1].SetActive(true);
            }
        }
    }
    public void buySolarPanel()
    {
        if(Main.count >= 10)
        {
            Main.numSolarPanels++;
            Main.count -= 10;
        }
    }

    public void buyTree()
    {
        if(Main.count >= 10)
        {
            Main.numTrees++;
            Main.count -= 10;
            GameObject tree;
            tree = Instantiate(treePrefab, treeParent.transform);
            int randNum = Random.Range(1,5);
            Sprite pic;
            if (randNum == 1)
            {
                pic = tree1;
            }else if (randNum == 2)
            {
                pic = tree2;
            }else if (randNum == 3)
            {
                pic = tree3;
            }
            else
            {
                pic = tree4;
            }
            tree.GetComponent<Image>().sprite = pic;
    
        }
    }
    public void buyFactory() {
        if(Main.count >= 10)
        {
            Main.numFactories++;
            Main.count -= 10;
            GameObject factory;
            factory = Instantiate(factoryPrefab, factoryParent.transform);
            
        }
    }
    public void buyCoalMine()
    {
        if (Main.count >= 10)
        {
            Main.numCoalMines++;
            Main.count -= 10;
            GameObject coalMine;
            coalMine = Instantiate(coalMinePrefab, coalMineParent.transform);

        }
    }
}

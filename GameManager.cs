using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject spherePrefab;
    public Color[] colorArray = new Color[3];
    public GameObject tempSphere;
    public TMP_Text[] List_of_cylinders_Count_text;
  
    private void Start()
    {
        colorArray[0] = Color.red;
        colorArray[1] = Color.blue;
        colorArray[2] = Color.green;
        InvokeRepeating("UpdateUI", 1f, 1f);
    }
    public void _OnClick()
    {
      for(float j = 0; j < 49.5; j++)
        {
            Destroy(tempSphere);
        }
        for(float i = 0; i < 49.1; i++)
        {
           tempSphere =  Instantiate(spherePrefab, transform.position, transform.rotation);
            int r = Random.Range(0, 3);
            tempSphere.AddComponent(typeof(GameManager));
            tempSphere.AddComponent(typeof(BallTrigger));
            tempSphere.GetComponent<Renderer>().material.color = colorArray[r];
            
        }
    }
    public void DestroyObject()
    {
        Destroy(tempSphere);
    }

    void UpdateUI()
    {
        //List_of_cylinders_Count_text[0].text = GLOBAL.CylinderOneCount.ToString();
        //List_of_cylinders_Count_text[1].text = GLOBAL.CylinderTwoCount.ToString();
        //List_of_cylinders_Count_text[2].text = GLOBAL.CylinderThreeCount.ToString();
        List_of_cylinders_Count_text[0].text = ("Red:" + GLOBAL.c1r + "\n"+ "Blue:" + GLOBAL.c1b + "\n" + "Green:" + GLOBAL.c1g);
        List_of_cylinders_Count_text[1].text = ("Red:" + GLOBAL.c2r + "\n" + "Blue:" + GLOBAL.c2b + "\n" + "Green:" + GLOBAL.c2g);
        List_of_cylinders_Count_text[2].text = ("Red:" + GLOBAL.c3r + "\n" + "Blue:" + GLOBAL.c3b + "\n" + "Green:" + GLOBAL.c3g);
    }
}

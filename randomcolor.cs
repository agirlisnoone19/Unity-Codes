using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomcolor : MonoBehaviour
{
    public GameObject cubes;
    public Material[] matObj;
    public Renderer[] ren;

    private void Start()
    {
        for (int i = 0; i < cubes.transform.childCount; i++)
        {
            ren[i] = cubes.transform.GetChild(i).GetComponent<Renderer>();
        }
    }
    public void Change_Color()
    {
        int randomcolorinteger = Random.Range(0, matObj.Length);
        for (int i = 0; i < ren.Length; i++)
        {

            ren[i].material.color = matObj[randomcolorinteger].color;
        }

    }

}

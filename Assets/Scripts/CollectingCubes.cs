using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectingCubes : MonoBehaviour
{
    public TMP_Text CubeCounttext;
    float CubeCount;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Cubes")
        {
            Destroy(other.gameObject);
            CubeCount++;
        }
    }
    private void Update()
    {
        CubeCounttext.text=CubeCount.ToString();
    }
}

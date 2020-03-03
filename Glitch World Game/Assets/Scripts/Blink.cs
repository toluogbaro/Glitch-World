using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{

   public GameObject markerPrefab;

    public Transform markerPoint;


  void Update()
    {
        StartCoroutine("blinking");
    }
  
 IEnumerator blinking()
    {
        GameObject marker = Instantiate(markerPrefab, markerPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(3);
    }
}



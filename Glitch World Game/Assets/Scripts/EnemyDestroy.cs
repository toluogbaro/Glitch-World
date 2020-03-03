using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public Camera cam;
   void Start()
    {
        Color newColour = new Color(41f, 1f, 1f);

        
        while (cam.backgroundColor == newColour)
        {
            Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public GameObject markerPrefab;
    public void SceneSwitcher() 
    {
        SceneManager.LoadScene(1);

        Destroy(markerPrefab);
    }



}

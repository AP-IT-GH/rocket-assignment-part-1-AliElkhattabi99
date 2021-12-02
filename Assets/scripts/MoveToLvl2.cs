using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLvl2 : MonoBehaviour
{
    public string mLevelToLoad;
    public GameObject Player;
   
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(mLevelToLoad);
            
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string loadlvl;

    public void lvlToLoad()
    {
        SceneManager.LoadScene(loadlvl);
    }
}

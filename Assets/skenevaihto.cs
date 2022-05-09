using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skenevaihto : MonoBehaviour
{
    
    public void LataaSkene2(string sceneName) 
    {
        
        SceneManager.LoadScene(sceneName);

    }

}
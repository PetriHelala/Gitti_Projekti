using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightToggle : MonoBehaviour
{
        [SerializeField] GameObject Light;
        [SerializeField] [Range(1, 10)] int LoopCount;
        bool Enabled = false;
        public GameObject[] Lights;
        public bool[] Light_Enabled;

void CreateLight(int value){
    Debug.Log("Creating Light number: " + value);
    Lights[value] = Instantiate(Light,new Vector3(2*((value - 1 - 5) * 0.8f), 5, 0),Quaternion.identity);
    Lights[value].GetComponent<Light>().enabled = Light_Enabled[value];
}
        void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
            Enabled = !Enabled;
            for(int i = 1; i <= LoopCount; i++)
            {
                    if (Lights[i] == null)
                        CreateLight(i);
                    else 
                    {
                        Light LightEnable = Lights[i].GetComponent<Light>();
                        LightEnable.enabled = !LightEnable.enabled;
                        Light_Enabled[i] = LightEnable.enabled;
                    } 
            }
        }
            
        else if (Input.GetMouseButtonDown(1)){
                for(int i = 1; i <= LoopCount; i++){
                    if(Lights[i] == null)
                        CreateLight(i);
                    else{
                        Debug.Log("Destroying light: " + i);
                        Destroy(Lights[i]);
                        Lights[i] = null;
                    }
                    
                    {
                }       
            
            }    
        }
    }

    void Update(){
        if (Input.GetKeyDown("space")){
            SceneManager.LoadScene("Scene1");

        }
    }
}

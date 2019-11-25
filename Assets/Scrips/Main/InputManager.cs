using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour{
    void Start(){
        
    }
    
    void Update(){
        if(OVRInput.GetDown(OVRInput.Button.One)){
            // Change Scene Name Here
            SceneManager.LoadScene("Robson");
        }
    }
}

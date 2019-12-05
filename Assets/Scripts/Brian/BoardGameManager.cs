using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class BoardGameManager : MonoBehaviour{

    Dictionary<string,bool> boxes = new Dictionary<string,bool>();
    void Start(){
        boxes.Add("box1", false);
        boxes.Add("box2", false);
        boxes.Add("box3", false);
        boxes.Add("box4", false);
        boxes.Add("box5", false);
        boxes.Add("box6", false);
    }

    bool playedWinSound;

    void Update(){
        if(isGameOver()){
            TextMeshPro monitor = GameObject.Find("MonitorText").GetComponent<TextMeshPro>();
            monitor.SetText("Congratulations! You solved the puzzle\n\nYou can remove the headset now or tap the A button to go back to the office.");
            playWinSound();
            if(OVRInput.GetDown(OVRInput.Button.One)){
                // Change Scene Name Here
                SceneManager.LoadScene("Main");
            }
        }
    }

    public void changeBoxStatus(string boxName, bool value){
        boxes[boxName] = value;
    }

    void playWinSound(){
        if(!playedWinSound){
            AudioSource monitor = GameObject.Find("ComputerMonitor").GetComponent<AudioSource>();
            monitor.Play();
            playedWinSound = true;
        }
    }

    bool isGameOver(){
        foreach(KeyValuePair<string, bool> box in boxes){
            if(box.Value == false){
                return false;
            }
        }
        return true;
    }
}

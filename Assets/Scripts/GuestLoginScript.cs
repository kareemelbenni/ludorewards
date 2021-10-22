using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestLoginScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void offline_game()
    {
        SoundManagerScript.buttonAudioSource.Play();
        SceneManager.LoadScene("Offline Modes");
    }
}

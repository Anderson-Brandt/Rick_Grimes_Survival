using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController gameController;
    private AudioSource audioSource;
    public AudioClip shot;

    // Start is called before the first frame update
    void Start()
    {
        gameController = this;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}

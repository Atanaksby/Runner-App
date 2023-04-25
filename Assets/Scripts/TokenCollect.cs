using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCollect : MonoBehaviour
{
    AudioSource audio;
    public AudioClip sa;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject SoundManager = GameObject.FindGameObjectWithTag("FabrikaSoundManager");
        
        audio = SoundManager.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        audio.Play(0);
        audio.PlayOneShot();
        Destroy(gameObject);
    }
}

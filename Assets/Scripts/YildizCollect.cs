using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YildizCollect : MonoBehaviour
{
    AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject SoundManager = GameObject.FindGameObjectWithTag("SoundManager");
        
        audio = SoundManager.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        audio.Play(0);
        Destroy(gameObject);
    }
}

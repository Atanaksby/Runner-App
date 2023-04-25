using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScaleSetter : MonoBehaviour
{
    private GameObject oyuncu;
    private bool getDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.FindGameObjectWithTag("GencSaadet");
        //LİSTE BURADA OLUŞTURULUYOR
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = oyuncu.transform.position;
        transform.position = new Vector3(oyuncu.transform.position.x+1.0f, oyuncu.transform.position.y+1.5f, oyuncu.transform.position.z);
        if(transform.localScale.y <0.18f){
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector2(0.2f,0.2f), Time.deltaTime);
        }
        else if(transform.localScale.y >0.15f){
            Destroy(this.gameObject);
        }
    }
}

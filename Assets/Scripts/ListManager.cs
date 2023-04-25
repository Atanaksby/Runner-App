using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListManager : MonoBehaviour
{
    // Start is called before the first frame update
    
        public List<string> fabrikaList = new List<string>();
    void Start()
    {
        fabrikaList.Add("Ahmet");
        fabrikaList.Add("Atana "); //buradan fabrika isimleri eklenecek.
        fabrikaList.Add("Faruk");
        int randomNumber = Random.Range(0, fabrikaList.Count-1);
        Debug.Log(fabrikaList[randomNumber]);
        fabrikaList.RemoveAt(randomNumber);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

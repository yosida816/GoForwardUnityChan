using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cubesound : MonoBehaviour
{
    public AudioClip sound;

   


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("");

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("");
        if (other.gameObject.CompareTag("sound"))
          
        {
            GetComponent<AudioSource>().PlayOneShot(sound);
            Debug.Log(sound);

        }


    }

}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public AudioClip hitSound;
    AudioSource mySource;

    public AudioClip[] allSounds;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver() {
        Debug.Log(gameObject.transform.name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.transform.name == "Torso")
        //{
        int randSound = Random.Range(0, allSounds.Length);
        mySource.PlayOneShot(allSounds[randSound]);
            //mySource.PlayOneShot(hitSound);
        //}
        //Debug.Log(collision.gameObject.transform.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.transform.name);
    }

}

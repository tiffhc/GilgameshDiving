using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundBox : MonoBehaviour
{
    public Collider2D player;
    public AudioSource playerSound;
    public AudioClip gasp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision player)
    {
        if(player.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Found enemy");
            playerSound.clip = gasp;
            playerSound.Play(); 
        }
    }
}

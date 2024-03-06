using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pixelsx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // getting the audio source for the explosion
        AudioSource audioSource;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skymarior : MonoBehaviour
{
    [SerializeField] float Speed = 4f; //sets the speed for the background but allows for changes in unity instead of hardcode
    [SerializeField] float maxX; // sets the maxX for the background but allows for changes in unity instead of hardcode
    [SerializeField] float minX; // sets the minX for the background but allows for changes in unity instead of hardcode

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Speed * Vector3.left); // moves the background to the left by multiplying the speed by the set unity speed
        if (transform.position.x < maxX) //if statement that tells the background to move back to minX if it reaches a number less than the max, helps to create a moving sky illusion
        {
            transform.position = new Vector3(minX, 0f, 0f);
        }

    }
}

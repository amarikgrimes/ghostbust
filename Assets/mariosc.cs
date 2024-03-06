using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class mariosc : MonoBehaviour
{
    [SerializeField] GameObject pixelPrefab;
    [SerializeField] float Speed;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Speed * Vector3.left);
    }

    // OnCollisionEnter2D is called when this collider/rigidbody2D has begun touching another rigidbody2D/collider2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(pixelPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            gameManager.score -= 100;
            
        }
    }
}

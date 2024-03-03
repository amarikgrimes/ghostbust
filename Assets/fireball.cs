using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{

    public float Speed;
    [SerializeField] GameObject pixelPrefab;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float r = Random.Range(0, Speed);
        transform.Translate(Speed * Time.deltaTime * Vector3.right);
    }

    // OnCollisionEnter2D is called when this collider/rigidbody2D has begun touching another rigidbody2D/collider2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Instantiate(pixelPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villiansc : MonoBehaviour
{
    public float Speed;
    [SerializeField] float maxY;
    [SerializeField] float minY;
    [SerializeField] GameObject fireballPrefab;
    [SerializeField] GameObject pixelPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");

        float r = Random.Range(0, Speed);

        transform.Translate(Time.deltaTime * Speed * y * Vector3.up);


        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0f);

        }
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, 0f);
        }


        if (Input.GetButtonDown("Fire1") == true)
        {
            Instantiate(fireballPrefab, transform.position, transform.rotation);

        }
    }
    // OnCollisionEnter2D is called when this collider/rigidbody2D has begun touching another rigidbody2D/collider2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}


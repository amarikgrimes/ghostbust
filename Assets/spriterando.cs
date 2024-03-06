using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriterando : MonoBehaviour

{
    //assigning public and serialized variables 
    public GameObject lupigiPrefab; // Assign your sprite prefab in the inspector
    public GameObject marioPrefab;// Assign your sprite prefab in the inspector
    [SerializeField] int Ratio = 50;
    public float instantiateInterval = 1.0f; // Adjust the interval between instantiations as needed
    [SerializeField] float MinY; 
    [SerializeField] float MaxY;

    private void Start()
    {
        StartCoroutine(InstantiateSprites()); // instantiates the sprites that we are randomizing
    }

    private IEnumerator InstantiateSprites() //calling it
    {
        //while loop for randomizing the creation of sprites
        while (true)
        {
          
            float randomY = Random.Range(MinY, MaxY); 
            int r = Random.Range(0, 100); // creating a range of how many are created
            Vector3 randomPosition = new Vector3(12f, randomY, transform.position.z); // creating a vector to randomize the position

            if (r < Ratio)
            {
                Instantiate(lupigiPrefab, randomPosition, transform.rotation); // randomizing the mario prefab
            }
            else
            {
                Instantiate(marioPrefab, randomPosition, transform.rotation); // randomizing the lupigi prefab
            }
            yield return new WaitForSeconds(instantiateInterval); //wait time for randomizing
        }
    }
}

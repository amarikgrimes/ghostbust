using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriterando : MonoBehaviour

{
    public GameObject lupigiPrefab; // Assign your sprite prefab in the inspector
    public GameObject marioPrefab;// Assign your sprite prefab in the inspector
    [SerializeField] int Ratio = 50;
    public float instantiateInterval = 1.0f; // Adjust the interval between instantiations as needed
    [SerializeField] float MinY;
    [SerializeField] float MaxY;

    private void Start()
    {
        StartCoroutine(InstantiateSprites());
    }

    private IEnumerator InstantiateSprites()
    {
        while (true)
        {
            float randomY = Random.Range(MinY, MaxY);
            int r = Random.Range(0, 100);
            Vector3 randomPosition = new Vector3(12f, randomY, transform.position.z);

            if (r < Ratio)
            {
                Instantiate(lupigiPrefab, randomPosition, transform.rotation);
            }
            else
            {
                Instantiate(marioPrefab, randomPosition, transform.rotation);
            }
            yield return new WaitForSeconds(instantiateInterval);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour

{
    public GameObject lupigiPrefab; // Assign your sprite prefab in the inspector
    public GameObject marioPrefab;// Assign your sprite prefab in the inspector
    [SerializeField] int Ratio = 50;
    public float instantiateInterval = 1.0f; // Adjust the interval between instantiations as needed
    [SerializeField] float MinY;
    [SerializeField] float MaxY;
    private int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateSprites());
        score = 0;
        scoreText.text = "Score:" + score; UpdateScore(0);
        IEnumerator InstantiateSprites()
        {

            {

            }
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
        public void UpdateScore(int scoretoAdd)
        {
            score += scoretoAdd;
            scoreText.text = "Score:" + score;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

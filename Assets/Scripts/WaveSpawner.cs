using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefabs;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public Text waveCountdownTimer;

    private int waveIndex = 1;

    void Update()
    {
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        } 

        countdown -= Time.deltaTime;

        waveCountdownTimer.text = Mathf.Round(countdown).ToString();

    }

    IEnumerator SpawnWave()
    {
        for(int i = 0; i<waveIndex; i++)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        waveIndex++;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefabs, spawnPoint.position, spawnPoint.rotation); 
    }
}

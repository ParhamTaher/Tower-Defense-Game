using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

    public static int enemiesAlive = 0;

    // public Transform enemyPrefab;
    public Wave[] waves;
    public Transform spawnPoint;
    public float timeBetweenWaves = 2f;
    public Text WaveCountdownText;
    public GameManager gameManager;

    private float countdown = 2f;
    private int waveIndex = 0;

    private void Start()
    {

        enemiesAlive = 0;

    }

    private void Update()
    {

        if (enemiesAlive > 0)
        {

            return;

        }

        if (waveIndex == waves.Length)
        {

            gameManager.WinLevel();
            this.enabled = false;

        }

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        WaveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    // Coroutine
    IEnumerator SpawnWave()
    {
        Debug.Log("Wave Incoming!");

        PlayerStats.rounds += 1;

        Wave wave = waves[waveIndex];
        enemiesAlive = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(1f / wave.rate);
        }

        waveIndex += 1;

    }

    void SpawnEnemy(GameObject enemy)
    {

        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        
    }

}

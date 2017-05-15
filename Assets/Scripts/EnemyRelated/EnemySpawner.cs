using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public Rigidbody enemy; 

	public int enemyCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < enemyCount; i++)
			{
				Invoke ("SpawnEnemy", 1.5f);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
	void SpawnEnemy(){
		Rigidbody instance = Instantiate(enemy);

		instance.velocity = Random.insideUnitSphere * 5;
	}
}

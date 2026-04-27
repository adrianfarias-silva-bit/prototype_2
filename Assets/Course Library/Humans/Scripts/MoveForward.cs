using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20f;
    public float spawnPosZ = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && animalPrefabs.Length > 0)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Quaternion spawnRotation = animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0, 180, 0);

            Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRotation);
        }
    }
}
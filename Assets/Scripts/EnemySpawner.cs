using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(enemy, this.transform.position, this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

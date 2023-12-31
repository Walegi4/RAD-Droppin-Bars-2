using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bombPrefab;
    public float delay = 2.0f
    public bool active = true;
    public Vector2 delayRange = new Vector2(1, 2);

    // Start is called before the first frame update
    void Start()
    {
        ResetDelay();
        StartCoroutine(EnemyGenerator());
    }

    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);
        if (active)
        {
            Instantiate(bombPrefab, new Vector 3 randomX, spawnY, 0), bombPrefab.transform.rotation;
            ResetDelay();
        }

        StartCoroutine(EnemyGenerator());
    }

   
   void ResetDelay()
   {
    delay = Random.Range(delayRAnge.x, delayRange.y);
   }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}

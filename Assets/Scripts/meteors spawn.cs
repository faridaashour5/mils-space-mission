using UnityEngine;

public class meteors_spawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
       public GameObject pipePrefab;
        public Transform  spawnPoint;
      public float   spawnRate = 2f;
        private float timer = 0f;
    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
     else
        {
          SpawnPipe();
          timer = 0f;
        }
  
  void SpawnPipe()
    {
        Instantiate(pipePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}

}
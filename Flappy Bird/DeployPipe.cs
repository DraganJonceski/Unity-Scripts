using System.Collections;
using UnityEngine;

public class DeployPipe : MonoBehaviour
{
    public GameObject pipePrefab;
    public float respawnTime = 1.0f;
    public float speed;
    private Vector2 screenBounds;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
       // rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(pipeWave());
    }

    private void spawnPipe()
    {
        GameObject p = Instantiate(pipePrefab) as GameObject;
       
        p.transform.position = new Vector2(screenBounds.x , Random.Range(-screenBounds.y-5, screenBounds.y));
        

    }

    IEnumerator pipeWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPipe();
        }
    }
}

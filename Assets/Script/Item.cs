using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour {
    public float speed = 0.5f; 

    private void Update()
    {
        this.gameObject.transform.RotateAround(new Vector3(0,0,0),transform.up,45 * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Player")){

            Destroy(gameObject);
        }
    }
}

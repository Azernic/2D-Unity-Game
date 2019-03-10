using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
{
    public Collider FPSController; // idk what this does right now i dont think it's being used

    private GameObject player; // neither is this

    private bool isInCollider;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player has entered the area");
        isInCollider = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Player has exited the area");
        isInCollider = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isInCollider == true)
        {
            SceneManager.LoadScene(1);
            Debug.Log("ok");
            
        }
    }
}

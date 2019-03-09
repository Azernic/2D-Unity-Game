using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
{

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
            Debug.Log("ok");
            SceneManager.LoadScene("test");
        }
    }
}

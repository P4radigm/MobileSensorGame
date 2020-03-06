using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int currentBuildIndex;
    [SerializeField] private int amntTouchesReq = 3;
    [SerializeField] private bool readyCheck = false;

    // Start is called before the first frame update
    void Awake()
    {
        readyCheck = false;
    }

    void Start()
    {
        readyCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(Input.touchCount);
        if (Input.touchCount == amntTouchesReq && readyCheck == true)
        {
            if (SceneManager.GetActiveScene().buildIndex < 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }

        }

        if (Input.touchCount == (amntTouchesReq + 1))
        {
            readyCheck = true;
        }
    }
}

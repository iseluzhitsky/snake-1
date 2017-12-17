using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour {

    public float Speed;
    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public SnakeMovement mainSnake;
    public int indx;

    void Start () {

        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        Speed = mainSnake.Speed+1.5f;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        indx = mainSnake.tailObjects.IndexOf(gameObject);

    }
	
	void Update () {

        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);

	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SnakeMain"))
        {
            if(indx > 2)
            {
                SceneManager.LoadScene("Play");
            } 
        }
    }
     
}

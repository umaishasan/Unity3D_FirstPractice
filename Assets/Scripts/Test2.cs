﻿using UnityEngine;

public class Test2 : MonoBehaviour
{
    private float speed = 10f;
    public Rigidbody rigidbody;
    private float moveX;
    private float moveY;
    
    void OnEnable()
    {
        Debug.Log("OnEnable called");
    }

    void Awake()
    {
        Debug.Log("Awake called");
    }

    void Reset()
    {
        Debug.Log("Reset called");
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        Debug.Log("Start called");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable called");
    }

    // Update is called once per frame
    void Update()
    {
        this.objectMovingWithDT();
        /*this.shortKut();*/
        /*this.objectMovingWithSimple();*/
    }

    //MOUSE EVENTS
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Mouse Drag");
    }

    private void OnMouseOver()
    {
        Debug.Log("Mouse Over");
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
    }

    private void OnMouseUp()
    {
        Debug.Log("Mouse Up");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Mouse Up As Button");
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
    }

    void objectMovingWithDT()
    {
/*        rb.velocity = new Vector3(0f, 1f, 0f);*/
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(10f, 0f, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0f, 0f, -10f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0f, 10f, 0f) * Time.deltaTime);
        }
    }

    void objectMovingWithSimple()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * this.speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * this.speed);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * this.speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * this.speed);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * this.speed);
        }
    }

    /*void shortKut()
    {
        if (Input.GetAxis("Horizontal"))
        {
            transform.Translate(new Vector3(moveX,0,0));
        }
    }*/
    
}

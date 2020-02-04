using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public Transform dest;
    bool holding = false;
    float speed = 25000f;
    private void LateUpdate()
    {
        if (holding)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2 - 3f, Camera.main.nearClipPlane + 3f));
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().AddForce(dest.transform.forward * speed * Time.deltaTime);
                holding = false;
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().freezeRotation = false;
            }
        }
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (holding == false)
            {
                if (Vector3.Distance(transform.position, dest.transform.position) <= 5)
                {
                    GetComponent<Rigidbody>().useGravity = false;
                    holding = true;
                    this.transform.parent = GameObject.Find("GrabDistance").transform;
                    GetComponent<Rigidbody>().velocity = Vector3.zero;
                    GetComponent<Rigidbody>().freezeRotation = true;
                }
            }
            else
            {
                holding = false;
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().freezeRotation = false;
            }

        }
    }
}
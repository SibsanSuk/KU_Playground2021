using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public bool gateOpen = false;
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Open",gateOpen);

        if (Input.GetKeyDown(KeyCode.E))
        {
            gateOpen = !gateOpen;
        }
    }
}

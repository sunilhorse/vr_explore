using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{


    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("basketball"))
        {
            myAnimationController.SetBool("playDance", true);
        }



    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("basketball"))
        {
            myAnimationController.SetBool("playDance", false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

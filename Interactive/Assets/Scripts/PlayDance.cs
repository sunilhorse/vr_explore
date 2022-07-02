using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDance : MonoBehaviour
{
    Animator cheerGirl;
    private void OnTriggerEnter(Collider other)
    {

        cheerGirl.SetBool("playDance", true);

    }

        // Start is called before the first frame update
        void Start()
    {
        cheerGirl = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

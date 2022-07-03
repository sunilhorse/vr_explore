using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDance : MonoBehaviour
{
    [SerializeField] private Animator myDance = null;

    [SerializeField] private bool idleAnim = false;
    [SerializeField] private bool danceAnim = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("basketball"))
        {
            if (idleAnim)
            {
                myDance.Play("cheer_idle", 0, 0.0f);
                //gameObject.SetActive(false);
            }
            else if (danceAnim)
            {
                myDance.Play("cheer_dance", 0, 0.0f);
                //gameObject.SetActive(false);
            }

        }
    }
}

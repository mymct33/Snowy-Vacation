using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarshmellowOnStick : MonoBehaviour
{
    public GameObject VRAvatar;
    private  GameObject Hand;
    public void AttachToController()
    {
        for(int i = 0; i < VRAvatar.transform.childCount; i++)
        {
            Transform tChild = VRAvatar.transform.GetChild(i);
            if(tChild.name == "PrimaryHand")
            {
                Hand = tChild.gameObject;
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, Hand.transform.position, 1);
            }
        }
    }
}

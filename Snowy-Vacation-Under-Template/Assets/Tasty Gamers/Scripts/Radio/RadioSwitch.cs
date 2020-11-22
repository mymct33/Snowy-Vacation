using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSwitch : MonoBehaviour
{
    public List<AudioClip> Songs;
    private AudioSource sPlayer;
    public int CurrentSong;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < gameObject.transform.childCount; i++)
        {
            Transform tChild = gameObject.transform.GetChild(i);
            if(tChild.GetComponent<AudioSource>())
            {
                sPlayer = tChild.GetComponent<AudioSource>();
                sPlayer.clip = Songs[0];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        sPlayer.Play();
    }

    private void ToggleUp()
    {
        
    }
}

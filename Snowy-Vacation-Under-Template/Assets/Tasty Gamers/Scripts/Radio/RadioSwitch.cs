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
                sPlayer.Play();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleUp()
    {
        ++CurrentSong;
        if(CurrentSong < Songs.Count)
        {
            sPlayer.clip = Songs[CurrentSong];
            sPlayer.Play();
        }
        else
        {
            CurrentSong = 0;
            sPlayer.clip = Songs[0];
            sPlayer.Play();
        }
    }

    public void ToggleDown()
    {
        --CurrentSong;
        if(CurrentSong < 0)
        {
            CurrentSong = Songs.Count - 1;
            sPlayer.clip = Songs[CurrentSong];
            sPlayer.Play();
        }
        else
        {
            sPlayer.clip = Songs[CurrentSong];
            sPlayer.Play();
        }
    }
}

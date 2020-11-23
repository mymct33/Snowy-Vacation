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

    public void ToggleUp()
    {
        ++CurrentSong;
        if(CurrentSong < Songs.Count)
        {
            sPlayer.clip = Songs[CurrentSong];
        }
        else
        {
            CurrentSong = 0;
            sPlayer.clip = Songs[0];
        }
    }

    public void ToggleDown()
    {
        --CurrentSong;
        if(CurrentSong > 0)
        {
            sPlayer.Stop();
            sPlayer.clip = Songs[CurrentSong];
            sPlayer.Play();
        }
        else
        {
            sPlayer.Stop();
            CurrentSong = Songs.Count;
            sPlayer.clip = Songs[Songs.Count];
            sPlayer.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    //bgm is background music, ghost is the music of ghost
    public AudioClip bgm;
    public AudioClip ghost;
    public AudioSource BGM;
    public AudioSource GHOST;
    private double playTime;

    void Start()
    {
       
        MusicPlay();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void MusicPlay()
    {
        playTime = AudioSettings.dspTime;
        BGM.clip = bgm;
        GHOST.clip = ghost;
        BGM.PlayScheduled(playTime);
        GHOST.PlayScheduled(playTime + BGM.clip.length);
    }
}

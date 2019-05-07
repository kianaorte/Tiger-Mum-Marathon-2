using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicController : MonoBehaviour
{
    //declaring the slider and the audio source
    public Slider Volume;
    public AudioSource music;

    public void Update()
    {
        //sets the musics volume based on the number in the slider
        music.volume = Volume.value;
    }
}

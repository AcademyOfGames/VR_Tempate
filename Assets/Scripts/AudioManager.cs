using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource source;

    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void Playclip(string clipName)
    {
        //if(source.clip !=null) 

        bool clipPlayed = false;
        foreach (AudioClip clip in clips)
        {
            if (clipPlayed) break;
            if (clip.name != clipName) continue;

            clipPlayed = true;
            //source.Stop();
            //source.clip = clip;
            //source.Play();

        }

        if (!clipPlayed)

        {
   
            Debug.LogWarning(message: "Clip not played. " + clipName + "not found.");
        }
    }
}

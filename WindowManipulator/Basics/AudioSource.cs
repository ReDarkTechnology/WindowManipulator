using System;

public class AudioSource : EngineBehavioural
{
    private bool m_enabled = true;
    public bool enabled
    {
        get
        {
            return m_enabled;
        }
        set
        {
            if (!value) Pause();
            m_enabled = value;
            if (value && playOnAwake && !alreadyPlayedBefore) Play();
        }
    }
    public bool playOnAwake = true;
    private bool alreadyPlayedBefore;
    private AudioClip m_audioClip;
    public bool existingAudio;
    public AudioClip audioClip
    {
        get
        {
            return m_audioClip;
        }
        set
        {
            m_audioClip = value;
            if (existingAudio)
            {
                existingAudio = false;
            }
        }
    }
    public float volume = 1;
    public long time;
    private long temporaryTime;
    public void Start()
    {

    }
    public void Update()
    {
    }
    public void Play()
    {
        if (enabled)
        {
        }
    }
    public void Stop()
    {
        if (enabled)
        {
            temporaryTime = 0;
        }
    }
    public void Pause()
    {
        if (enabled)
        {
        }
    }
}
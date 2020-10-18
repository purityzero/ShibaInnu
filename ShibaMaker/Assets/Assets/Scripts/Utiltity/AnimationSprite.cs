using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class AnimationSprite : MonoBehaviour
{
    public List<Sprite> SpritesName;
    public float UpdateTime = 0;
    private Image ComponetSprite;
    private float Timer = 0;
    private int Count = 0;
    private bool isPlaying = true;
    private void Start()
    {
        ComponetSprite = GetComponent<Image>();
        isPlaying = true;
    }

    void Update()
    {
        if (isPlaying == true)
            Timer += Time.deltaTime;

        if (Timer >= UpdateTime)
        {
            ComponetSprite.sprite = SpritesName[Count];
            Timer = 0;
            Count += 1;
            if (Count >= SpritesName.Count)
                Count = 0;
        }
    }

    public void Play()
    {
        isPlaying = true;
    }

    public void Pause()
    {
        isPlaying = false;
    }

    public void ResetSprite()
    {
        ComponetSprite.sprite = SpritesName[0];
    }
}

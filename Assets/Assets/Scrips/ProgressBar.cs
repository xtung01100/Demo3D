using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform rectTransform;
    public RectTransform mask;
    public RectTransform progressImage;
    private float maxWidth;
    private float maxHeight;

    private void Awake()
    {
        maxWidth = mask.rect.width;
        maxHeight = mask.rect.height;

    }
    public void SetProgressValue(float progress)
    {
        float currentWidth = Mathf.Clamp01(progress) * maxWidth;
        mask.sizeDelta = new Vector2(currentWidth, maxHeight);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

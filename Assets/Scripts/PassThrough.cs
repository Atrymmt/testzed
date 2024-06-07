using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassThrough : MonoBehaviour
{
    WebCamTexture _webCamTexture;
    RawImage _rawImage;

    private static int _size = 256;
    private static int _fps = 30;

    void Start()
    {
        this._rawImage = GetComponent<RawImage>();
        this._webCamTexture = new WebCamTexture(_size, _size, _fps);
        this._rawImage.texture = this._webCamTexture;
        this._webCamTexture.Play();
    }

}
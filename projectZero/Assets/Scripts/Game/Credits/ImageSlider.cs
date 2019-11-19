using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Credits
{
    public class ImageSlider : MonoBehaviour
    {
        [SerializeField]
        private List<Texture> _listOfTextures;

        [SerializeField]
        private RawImage _imagePlaceHolder;

        private int _indexer;

        private bool _isInCoroutine;

        private void Start()
        {
            _indexer = 0;

            _isInCoroutine = false;
        }

        private void Update()
        {
            if (_isInCoroutine == false)
            {
                StartCoroutine(ImageChanger());
            }
        }

        private IEnumerator ImageChanger()
        {
            _isInCoroutine = true;

            yield return new WaitForSeconds(3.7f);

            if (_indexer < _listOfTextures.Count)
            {
                MoveToTheNextImage();
            }

            _isInCoroutine = false;
        }

        private void MoveToTheNextImage()
        {
            _imagePlaceHolder.texture = _listOfTextures[_indexer];

            _indexer++;

            if (_indexer > _listOfTextures.Count)
            {
                // If all pictures were shown - block flag _isInCoroutine
                _isInCoroutine = true;
            }
        }
    }
}

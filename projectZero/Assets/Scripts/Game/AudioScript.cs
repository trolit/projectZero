using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class AudioScript : MonoBehaviour
    {
        public AudioMixer MasterMixer;

        public AudioMixer SfxMixer;

        public AudioMixer MusicMixer;

        public Slider MasterSlider;

        public Slider SFXSlider;

        public Slider MusicSlider;

        private void Start()
        {
            // load Master Slider
            float volume = PlayerPrefs.GetFloat("master");
            MasterSlider.value = volume;

            // load SFX Slider
            float sfx = PlayerPrefs.GetFloat("sfx");
            SFXSlider.value = sfx;

            // load Music Slider
            float music = PlayerPrefs.GetFloat("music");
            MusicSlider.value = music;
        }

        public void SetMasterMixerLevel(float sliderValue)
        {
            MasterMixer.SetFloat("master", Mathf.Log(sliderValue) * 20);
        }

        public void SetSfxMixerLevel(float sliderValue)
        {
            SfxMixer.SetFloat("sfx", Mathf.Log(sliderValue) * 20);
        }

        public void SetMusicMixerLevel(float sliderValue)
        {
            MusicMixer.SetFloat("music", Mathf.Log(sliderValue) * 20);
        }

        public void SaveVolumes()
        {
            // save audio mixer sliders values
            PlayerPrefs.SetFloat("master", MasterSlider.value);

            PlayerPrefs.SetFloat("sfx", SFXSlider.value);

            PlayerPrefs.SetFloat("music", MusicSlider.value);
        }
    }
}

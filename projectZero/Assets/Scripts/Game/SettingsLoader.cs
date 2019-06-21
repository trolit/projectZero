using UnityEngine;
using UnityEngine.Audio;

namespace Assets.Scripts.Game
{
    public class SettingsLoader : MonoBehaviour
    {
        public AudioMixer MasterMixer;

        public AudioMixer SfxMixer;

        public AudioMixer MusicMixer;

        // Start is called before the first frame update
        void Start()
        {
            // load Master Volume
            float volume = PlayerPrefs.GetFloat("master");
            MasterMixer.SetFloat("master", Mathf.Log(volume) * 20);

            // load SFX Volume
            float sfx = PlayerPrefs.GetFloat("sfx");
            SfxMixer.SetFloat("sfx", Mathf.Log(sfx) * 20);

            // load Music Volume
            float music = PlayerPrefs.GetFloat("music");
            MusicMixer.SetFloat("music", Mathf.Log(music) * 20);

            // loading parameters...
            int qualityIndex = PlayerPrefs.GetInt("quality");
            int width_scr = PlayerPrefs.GetInt("width");
            int height_scr = PlayerPrefs.GetInt("height");
            int texture_quality = PlayerPrefs.GetInt("text_q");
            int vsyncSwitch = PlayerPrefs.GetInt("vsync");

            // set vsync
            QualitySettings.vSyncCount = vsyncSwitch;

            // load screen resolution
            Screen.SetResolution(width_scr, height_scr, Screen.fullScreen);

            // load quality level
            QualitySettings.SetQualityLevel(qualityIndex);

            // load texture quality
            QualitySettings.masterTextureLimit = texture_quality;
        }
    }
}

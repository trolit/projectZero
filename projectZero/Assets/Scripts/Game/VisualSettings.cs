using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyButtons;

namespace Assets.Scripts.Game
{
    public class VisualSettings : MonoBehaviour
    {
        // dropdowns here
        public Dropdown ResolutionDropdown;

        public Dropdown GraphicsDropdown;

        public Dropdown AntialiasingDropdown;

        public Dropdown TextureQualityDropdown;

        // toggles here
        public Toggle Vsynctoggle;

        public Toggle FullscreenToggle;

        // arrays here
        Resolution[] _resolutions;

        [Button]
        public void ViewActualSettings()
        {
            Debug.Log("Quality index => " + PlayerPrefs.GetInt("quality"));
            Debug.Log("Screen width => " + PlayerPrefs.GetInt("width"));
            Debug.Log("Screen height => " + PlayerPrefs.GetInt("height"));
            Debug.Log("Texture quality => " + PlayerPrefs.GetInt("text_q"));
            Debug.Log("VSync status  => " + PlayerPrefs.GetInt("vsync"));
            Debug.Log("Fullscreen status => " + PlayerPrefs.GetInt("fullscreen"));
        }

        private void Start()
        {
            // fix?
            useGUILayout = false;

            // loading parameters...
            int qualityIndex = PlayerPrefs.GetInt("quality");
            int width_scr = PlayerPrefs.GetInt("width");
            int height_scr = PlayerPrefs.GetInt("height");
            int texture_quality = PlayerPrefs.GetInt("text_q");
            int vsyncSwitch = PlayerPrefs.GetInt("vsync");
            int fullscreen = PlayerPrefs.GetInt("fullscreen");

            // load quality level
            QualitySettings.SetQualityLevel(qualityIndex);
            GraphicsDropdown.value = qualityIndex;

            // set fullscreen toggle
            FullscreenToggle.isOn = fullscreen == 1;

            // set vsync
            QualitySettings.vSyncCount = vsyncSwitch;

            // load screen resolution
            Screen.SetResolution(width_scr, height_scr, Screen.fullScreen);

            int antialiasing = PlayerPrefs.GetInt("ant_a");

            // load antialiasing 
            QualitySettings.antiAliasing = antialiasing;
            SetAntiAliasingDropdown(antialiasing);

            // load texture quality
            QualitySettings.masterTextureLimit = texture_quality;
            TextureQualityDropdown.value = texture_quality;

            // ------------------------
            // Setting up resolution options
            // ------------------------
            _resolutions = Screen.resolutions;

            ResolutionDropdown.ClearOptions();

            List<string> options = new List<string>();

            int currentresolutionIndex = 0;

            for (int i = 0; i < _resolutions.Length; i++)
            {
                string option = _resolutions[i].width + " x " + _resolutions[i].height;
                options.Add(option);
                if (_resolutions[i].width == Screen.currentResolution.width &&
                    _resolutions[i].height == Screen.currentResolution.height)
                {
                    option = _resolutions[i].width + " x " + _resolutions[i].height;
                    currentresolutionIndex = i;
                }
            }

            ResolutionDropdown.AddOptions(options);
            ResolutionDropdown.value = currentresolutionIndex;
            ResolutionDropdown.RefreshShownValue();
        }

        public void SetResolution(int resolutionIndex)
        {
            Resolution resolution = _resolutions[resolutionIndex];
            Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        }

        public void SetQuality(int qualityIndex)
        {
            QualitySettings.SetQualityLevel(qualityIndex);

            AntialiasingDropdown.value = QualitySettings.antiAliasing - 1;
            AntialiasingDropdown.RefreshShownValue();

            TextureQualityDropdown.value = QualitySettings.masterTextureLimit;
            TextureQualityDropdown.RefreshShownValue();

            GraphicsDropdown.RefreshShownValue();

            if (QualitySettings.vSyncCount > 0)
            {
                Vsynctoggle.isOn = true;
            }
            else if (QualitySettings.vSyncCount == 0)
            {
                Vsynctoggle.isOn = false;
            }
        }

        public void SetFullscreen(bool fullscreen)
        {
            Screen.fullScreen = fullscreen;

            Screen.fullScreenMode = Screen.fullScreen ? FullScreenMode.ExclusiveFullScreen : FullScreenMode.Windowed;

            if (Screen.fullScreenMode == FullScreenMode.ExclusiveFullScreen)
            {
                PlayerPrefs.SetInt("fullscreen", 1);
            }
            else
            {
                PlayerPrefs.SetInt("fullscreen", 0);
            }
        }

        public void SetVsync(bool vsync)
        {
            if (vsync)
            {
                QualitySettings.vSyncCount = 1;
            }
            else
            {
                QualitySettings.vSyncCount = 0;
            }
        }

        public void SetAntiAliasing(int setaa)
        {
            if (setaa == 0)
            {
                QualitySettings.antiAliasing = 0;
            }
            else if (setaa == 1)
            {
                QualitySettings.antiAliasing = 2;
            }
            else if (setaa == 2)
            {
                QualitySettings.antiAliasing = 4;
            }
            else if (setaa == 3)
            {
                QualitySettings.antiAliasing = 8;
            }
        }

        public void SetTextureQuality(int textq)
        {
            if (textq == 0)
            {
                QualitySettings.masterTextureLimit = 0;
            }
            else if (textq == 1)
            {
                QualitySettings.masterTextureLimit = 1;
            }
            else if (textq == 2)
            {
                QualitySettings.masterTextureLimit = 2;
            }
            else if (textq == 3)
            {
                QualitySettings.masterTextureLimit = 3;
            }
        }

        // Sets dropdown default value
        void SetAntiAliasingDropdown(int antialiasing)
        {
            if (antialiasing == 0)
            {
                AntialiasingDropdown.value = 0;
            }
            else if (antialiasing == 2)
            {
                AntialiasingDropdown.value = 1;
            }
            else if (antialiasing == 4)
            {
                AntialiasingDropdown.value = 2;
            }
            else if (antialiasing == 8)
            {
                AntialiasingDropdown.value = 3;
            }
        }

        public void SaveVisualSettings()
        {
            PlayerPrefs.SetInt("quality", QualitySettings.GetQualityLevel());

            PlayerPrefs.SetInt("width", Screen.currentResolution.width);

            PlayerPrefs.SetInt("height", Screen.currentResolution.height);

            PlayerPrefs.SetInt("ant_a", QualitySettings.antiAliasing);

            PlayerPrefs.SetInt("text_q", QualitySettings.masterTextureLimit);

            PlayerPrefs.SetInt("vsync", QualitySettings.vSyncCount);

            PlayerPrefs.SetInt("savedSettings", 1);
        }
    }
}

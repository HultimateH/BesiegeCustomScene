using PluginManager.Plugin;
using UnityEngine;

namespace BesiegeCustomScene
{

    [OnGameInit]
    public class Mod : MonoBehaviour
    {
        public GameObject customSceneMod;

        string DisplayName = "Besiege Custom Scene";

        string Version = "1.10.9";

        private void Start()   
        {

            //���MOD�������͹���
            //new GameObject("Mod�������").AddComponent<Updater>().SetUrl("XultimateX", Name);

            customSceneMod = new GameObject();
            customSceneMod.name = string.Format("{0} {1}", DisplayName, Version);

            customSceneMod.AddComponent<SettingsManager>();
            customSceneMod.AddComponent<LanguageManager>();
            customSceneMod.AddComponent<Prop>();
            customSceneMod.AddComponent<UI.SceneSettingUI>();
            customSceneMod.AddComponent<UI.ToolBoxSettingUI>();
            
            UnityEngine.Object.DontDestroyOnLoad(customSceneMod);

            

        }
    }
}

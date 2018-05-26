using PluginManager.Plugin;
using UnityEngine;

namespace BesiegeCustomScene
{

    [OnGameInit]
    public class SceneMod : MonoBehaviour
    {
        public GameObject Scene;

        string DisplayName = "Besiege Custom Scene";

        string Version = "1.10.7";

        public SceneMod() { }

        private void Start()   
        {

            //���MOD�������͹���
            //new GameObject("Mod�������").AddComponent<Updater>().SetUrl("XultimateX", Name);

            Scene = new GameObject();
            Scene.name = string.Format("{0} {1}", DisplayName, Version);
            Scene.AddComponent<SceneUI>();
            Scene.AddComponent<TimeUI>();
            Scene.AddComponent<MeshMod>();
            Scene.AddComponent<CubeMod>();
            Scene.AddComponent<TriggerMod>();
            Scene.AddComponent<SnowMod>();
            Scene.AddComponent<CloudMod>();
            Scene.AddComponent<WaterMod>();
            Scene.AddComponent<Prop>();
            UnityEngine.Object.DontDestroyOnLoad(Scene);

        }
    }
}

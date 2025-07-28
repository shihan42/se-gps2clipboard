using System.Reflection;
using HarmonyLib;
using VRage.Plugins;

namespace Gps2Clipboard
{
    // ReSharper disable once UnusedType.Global
    // ReSharper disable once UnusedMember.Global
    public class Plugin : IPlugin
    {
        private const string Name = "Gps2Clipboard";

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public void Init(object gameInstance)
        {
            var harmony = new Harmony(Name);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Dispose()
        {}

        public void Update()
        {}
    }
}

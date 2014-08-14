using Orchard.UI.Resources;

namespace frifall.nu {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("FrifallCustom").SetUrl("custom.js").SetDependencies("jQuery");
        }
    }
}

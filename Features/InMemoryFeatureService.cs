using System.Collections.Generic;

namespace gfys.webservices.Features
{
    public class InMemoryFeatureService : IFeatureService
    {
        private IDictionary<string, Feature> features = new Dictionary<string, Feature>();

        public IEnumerable<Feature> GetAllFeatures()
        {
            return features.Values;
        }

        public Feature GetFeature(string name)
        {
            if (features.ContainsKey(name))
            {
                return features[name];
            }
            return null;
        }

        public void CreateFeature(Feature feature)
        {
            features[feature.Name] = feature;
        }

        public void UpdateFeature(Feature feature)
        {
            features[feature.Name] = feature;
        }

        public void DeleteFeature(string featureName)
        {
            features.Remove(featureName);
        }
    }
}
using System.Collections.Generic;

namespace gfys.webservices.Features
{
    public interface IFeatureService
    {
         IEnumerable<Feature> GetAllFeatures();
         void CreateFeature(Feature feature);
         void UpdateFeature(Feature feature);
         void DeleteFeature(string featureName);
    }
}
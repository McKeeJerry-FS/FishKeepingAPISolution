using System.Collections.Generic;
using FishKeepingAPI.Models;

namespace FishKeepingAPI.Data
{
    public class MockFishKeepingAPIRepo : IFishKeepingAPIRepo
    {
        public void CreateFreshwaterTropicalFish(FreshwaterTropicalFish fwf)
        {
            throw new NotImplementedException();
        }

        public void DeleteFreshwaterTropicalFish(FreshwaterTropicalFish fwf)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FreshwaterTropicalFish> GetAllFreshWaterFish()
        {
            var freshWaterFish = new List<FreshwaterTropicalFish> 
            {
                new FreshwaterTropicalFish{
                    CommonName = "Neon Tetra",
                    ScientificName = "Paracheirodon innesi",
                    Family = "Characidae",
                    Temperment = "Community",
                    Origin = "Upper Amazon", 
                    Temp = 75,
                    PH = 6.8F
                },
                new FreshwaterTropicalFish{
                    CommonName = "Emperor Tetra",
                    ScientificName = "Nematobrycon palmeri",
                    Family = "Characidae",
                    Temperment = "Community",
                    Origin = "Northern South America, Columbia", 
                    Temp = 75,
                    PH = 6.8F
                }

            };
            return freshWaterFish;
        }

        public FreshwaterTropicalFish GetFreshwaterTropicalFishById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateFreshwaterTropicalFish(FreshwaterTropicalFish fwf)
        {
            throw new NotImplementedException();
        }
    }
}
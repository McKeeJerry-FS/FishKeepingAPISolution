using FishKeepingAPI.Models;
using System.Collections.Generic;

namespace FishKeepingAPI.Data
{
    public interface IFishKeepingAPIRepo
    {
        bool SaveChanges();

        IEnumerable<FreshwaterTropicalFish> GetAllFreshWaterFish();
        FreshwaterTropicalFish GetFreshwaterTropicalFishById(int id);
        void CreateFreshwaterTropicalFish(FreshwaterTropicalFish fwf);
        void UpdateFreshwaterTropicalFish(FreshwaterTropicalFish fwf);
        void DeleteFreshwaterTropicalFish(FreshwaterTropicalFish fwf);
    }
}
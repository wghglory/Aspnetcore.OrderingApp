using System.Collections.Generic;
using System.Linq;
using Aspnetcore.OrderingApp.Components;

namespace Aspnetcore.OrderingApp.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly List<SurveyProduct> _surveyProducts;

        public SurveyService()
        {
            _surveyProducts = new List<SurveyProduct>()
            {
                new SurveyProduct() { Id = 1, Name = "Hoodies", VoteCount = 8 },
                new SurveyProduct() { Id = 2, Name = "Banners", VoteCount = 1 },
                new SurveyProduct() { Id = 3, Name = "Posters", VoteCount = 4 },
                new SurveyProduct() { Id = 4, Name = "T-Shirts", VoteCount = 2 },
            };
        }

        public List<SurveyProduct> GetSurveyProducts()
        {
            return _surveyProducts;
        }

        public void IncreaseVoteCount(int productId)
        {
            _surveyProducts.FirstOrDefault(x => x.Id == productId).VoteCount += 1;
        }
    }
}

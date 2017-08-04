using System.Threading.Tasks;
using Aspnetcore.OrderingApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.OrderingApp.Components
{
    public class SurveyWidget : ViewComponent
    {
        private readonly ISurveyService _surveyService;

        public SurveyWidget(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var products = _surveyService.GetSurveyProducts();

            if (productId > 0)
            {
                _surveyService.IncreaseVoteCount(productId);
                return View("Results", products);
            }

            return View(products);
        }
    }

    public class SurveyProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
}

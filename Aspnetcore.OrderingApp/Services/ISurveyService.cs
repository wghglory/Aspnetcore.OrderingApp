using System.Collections.Generic;
using Aspnetcore.OrderingApp.Components;

namespace Aspnetcore.OrderingApp.Services
{
    public interface ISurveyService
    {
        List<SurveyProduct> GetSurveyProducts();
        void IncreaseVoteCount(int productId);
    }
}

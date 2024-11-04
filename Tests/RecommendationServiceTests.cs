using Xunit;

public class RecommendationServiceTests
{
    [Fact]
    public void GetRecommendations_ReturnsList()
    {
        var service = new RecommendationService();
        var recommendations = service.GetRecommendations("User123");

        Assert.NotEmpty(recommendations);
    }
}
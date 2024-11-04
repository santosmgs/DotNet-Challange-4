using Microsoft.ML;

public class MLModelBuilder
{
    private readonly MLContext _mlContext;

    public MLModelBuilder()
    {
        _mlContext = new MLContext();
    }

    public void TrainModel(string dataPath)
    {
        var data = _mlContext.Data.LoadFromTextFile<ProductRecommendation>(dataPath, separatorChar: ',', hasHeader: true);
        var pipeline = _mlContext.Recommendation().Trainers.MatrixFactorization("UserId", "ProductId", "Rating");
        var model = pipeline.Fit(data);
    }
}
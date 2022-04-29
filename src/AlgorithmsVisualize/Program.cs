using AlgorithmsVisualize;
using Arrays;
using Cocona;

CoconaApp.Run((string alg, int el) =>
{
    SortAlgorithmType sortAlgorithm = Enum.Parse<SortAlgorithmType>(alg);

    SortingAlgorithmVisualizer.Visualize(sortAlgorithm, el);
});

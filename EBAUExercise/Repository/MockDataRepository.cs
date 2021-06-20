using EBAUExercise.Services;

namespace EBAUExercise.Repository
{
    public class MockDataRepository
    {
        public bool Save()
        {
            Counter.Add();
            return true;
        }
    }
}
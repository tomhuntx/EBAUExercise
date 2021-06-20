using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    /// <summary>
    /// A single counter that resets and increments on every request to the /Tasks endpoint.
    /// </summary>
    public static class Counter
    {
        static int count = 0;

        public static void Add()
        {
            count++;
        }

        public static void Reset()
        {
            count = 0;
        }

        public static int GetCount()
		{
            return count;
		}
    }
}
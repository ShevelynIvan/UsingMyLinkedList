namespace DataStructures
{
    public class Point <T> 
    {
        public Point(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Pointer to next point
        /// </summary>
        public Point<T>? NextPoint { get; set; }

        /// <summary>
        /// Value of this point
        /// </summary>
        public T Value { get; set; }
    }
}

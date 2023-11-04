namespace DataStructures
{
    public class MyLinkedList<T> where T : IEquatable<T>
    {
        /// <summary>
        /// List for storing points 
        /// </summary>
        private List<Point<T>> _points = new List<Point<T>>();

        /// <summary>
        /// First point in list
        /// </summary>
        public Point<T>? First { get; set; }

        /// <summary>
        /// Last point in list
        /// </summary>
        public Point<T>? Last { get; set; }

        /// <summary>
        /// Count of all points in list
        /// </summary>
        public int Count { get => _points.Count; }

        /// <summary>
        /// Adds new point in list in the first place. Updates pointers in other points if it needed.
        /// </summary>
        /// <param name="value">T can be any value, null is possible if T is reference type</param>
        public void AddFirst(T value)
        {
            var newPoint = new Point<T>(value);

            if (Count == 0)
                CountIsNull(newPoint);

            else
            {
                newPoint.NextPoint = First;
                First = newPoint;
                _points.Add(newPoint);
            }
        }

        /// <summary>
        /// Adds new point in the end of list on new last place. Updates pointers in other points if it needed.
        /// </summary>
        /// <param name="value">T can be any value, null is possible if T is reference type</param>
        public void AddNext(T value)
        {
            var newPoint = new Point<T>(value);

            if (First is null || Last is null)
                CountIsNull(newPoint);

            else
            {
                Last.NextPoint = newPoint;
                Last = newPoint;
                _points.Add(newPoint);
            }
        }

        /// <summary>
        /// Removes first occurence of the specific object in MyLinkedList
        /// </summary>
        public void Remove(T value)
        {
            Point<T>? point = First;
            Point<T>? previous = null;

            if (point is null)
                return;

            while (point is not null)
            {
                if (point.Value is null)
                {
                    if (value is null)
                    {
                        DeletingPoint(point, previous);
                        break;
                    }
                }
                else if (point.Value.Equals(value))
                {
                    DeletingPoint(point, previous);
                    break;
                }

                previous = point;
                point = point.NextPoint;
            }
        }

        /// <summary>
        /// Helper method, raises when the first element is adding to the list
        /// </summary>
        /// <param name="newPoint"></param>
        private void CountIsNull(Point<T> newPoint)
        {
            First = newPoint;
            Last = newPoint;
            _points.Add(newPoint);
        }

        /// <summary>
        /// Method raises when element is removing from the list to do it in the right way and update necessary pointers
        /// </summary>
        /// <param name="point"></param>
        /// <param name="previous"></param>
        private void DeletingPoint(Point<T> point, Point<T>? previous)
        {
            if (previous is null)
            {
                First = point.NextPoint;
                _points.Remove(point);
            }
            else if (point == Last)
            {
                Last = previous;
                previous.NextPoint = null;
                _points.Remove(point);
            }
            else
            {
                previous.NextPoint = point.NextPoint;
                _points.Remove(point);
            }
        }

        /// <summary>
        /// Prints all points in the correct order one after the other
        /// </summary>
        public void PrintAllPoints()
        {
            if (First is null)
                return;

            Console.WriteLine($"First: {First.Value}");

            var point = First;

            while (point.NextPoint is not null)
            {
                if (point.NextPoint == Last)
                {
                    Console.WriteLine($"Last: {Last.Value}");
                    break;
                }

                Console.WriteLine($"Next: {point.NextPoint.Value}");
                point = point.NextPoint;
            }
        }

        /// <summary>
        /// Clears all list
        /// </summary>
        public void Clear()
        {
            First = null;
            Last = null;
            _points.Clear();
        }
    }
}

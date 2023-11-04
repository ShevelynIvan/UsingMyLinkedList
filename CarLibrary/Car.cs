namespace CarLibrary
{
    /// <summary>
    /// Class for demonstration removing reference type from MyLinkedList. Implements IEquatable<Car> to compare cars
    /// </summary>
    public class Car : IEquatable<Car>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Car(string name, string color) { Name = name; Color = color; }

        public override bool Equals(Object? obj)
        {
            return Equals(obj as Car);
        }

        public bool Equals(Car? other)
        {
            return other != null && 
                other.Name == Name && 
                other.Color == Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Color);
        }
    }
}

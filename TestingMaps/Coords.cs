namespace TestingMaps
{
  public class Coords
  {
    public Coords(int aX, int aY)
    {
      X = aX;
      Y = aY;
    }
    public int X { get; private set; }
    public int Y { get; private set; }

    public void Move(int aX, int aY)
    {
      X += aX;
      Y += aY;
    }

    public void Reset()
    {
      X = 0;
      Y = 0;
    }

    public bool IsActive
    {
      get
      {
        return (X != 0) && (Y != 0);
      }
    }

    public bool IsOrigin
    {
      get
      {
        return (X == 0) && (Y == 0);
      }
    }

    public bool IsXAxlis
    {
      get
      {
        return Y == 0;
      }
    }
    public bool IsYAxlis
    {
      get
      {
        return X == 0;
      }
    }


    public override string ToString()
    {
      return $"X: { X} Y: {Y}";
    }

    public override bool Equals(object obj)
    {
      if (obj is Coords)
      {
        var lCoords = obj as Coords;

        return (this.X == lCoords.X) && (this.Y == lCoords.Y);
      }

      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}

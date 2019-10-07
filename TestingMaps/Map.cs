using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMaps
{
  public class Map
  {
    public Map(int aRows, int aCols)
    {
      Rows = aRows;
      Cols = aCols;

      BuildMap(); 
    }

    public int Rows { get; private set; }
    public int Cols { get; private set; }

    private Dictionary<Coords, MapElement> fMapCoords = null;
    public Dictionary<Coords, MapElement> MapCoords
    {
      get
      {
        if(fMapCoords == null)
        {
          fMapCoords = new Dictionary<Coords, MapElement>();
        }

        return fMapCoords;
      }
    }

    private void BuildMap()
    {
      MapCoords.Clear();

      for (int lRow = 0; lRow <= this.Rows; lRow++)
      {
        for (int lCol = 0; lCol <= this.Cols; lCol++)
        {
          var lCoord = new Coords(lCol, lRow);

          var lMapElement = new MapElement()
          {
            Owner = this,
            Coords = lCoord
          };

          MapCoords.Add(lCoord, lMapElement);
        }
      }
    }

    public void ClearMap()
    {
      foreach(var lCoord in MapCoords.Keys)
      {
        if(lCoord.IsOrigin)
        {
          MapCoords[lCoord].Value = "0";
          continue;
        }

        if (lCoord.IsXAxlis)
        {
          MapCoords[lCoord].Value = lCoord.X.ToString();
          continue;
        }

        if (lCoord.IsYAxlis)
        {
          MapCoords[lCoord].Value = lCoord.Y.ToString();
          continue;
        }

        MapCoords[lCoord].Value = "";
      }
    }

    public Coords GetCoord(int lRow, int lCol)
    {
      var lCoord = MapCoords.Keys.Where(p => p.X == lCol && p.Y == lRow).FirstOrDefault();

      return lCoord;
    }

    public MapElement GetMapElement(int lRow, int lCol)
    {
      var lCoord = GetCoord(lRow, lCol);

      if (lCoord == null)
        return null;

      return MapCoords[lCoord];
    }

    public void SetValue(int lRow, int lCol, string aValue)
    {
      var lCoord = GetCoord(lRow, lCol);

      if (lCoord == null)
        return;

      MapCoords[lCoord].Value = aValue;
    }
  }
}

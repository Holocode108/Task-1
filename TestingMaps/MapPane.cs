using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingMaps
{
  public partial class MapPane : UserControl
  {
    public MapPane()
    {
      InitializeComponent();

      lblSample.Visible = false;
    }

    public MapPane(int aRows, int aCols)
    {
      InitializeComponent();

      Rows = aRows;
      Cols = aCols;

      BuildMap();
    }

    public int Rows { get; private set; }
    public int Cols { get; private set; }

    private Dictionary<Coords, Label> fMapLabels = null;
    public Dictionary<Coords, Label> MapLabels
    {
      get
      {
        if (fMapLabels == null)
        {
          fMapLabels = new Dictionary<Coords, Label>();
        }

        return fMapLabels;
      }
    }

    public Map Map { get; private set; }

    private void BuildMap()
    {
      Map = new Map(Rows, Cols);

      MapLabels.Clear();

      for (int lRow = 0; lRow <= this.Rows; lRow++)
      {
        for (int lCol = 0; lCol <= this.Cols; lCol++)
        {
          var lX = 8 + (35 + 4) * lCol;
          var lY = 10 + (17 + 4) * lRow;

          var lLabel = new Label()
          {
            Location = new System.Drawing.Point(lX, lY),
            Name = "lblSample",
            Size = new System.Drawing.Size(35, 17),
            Text = "XXX",
            Visible = true
          };

          lLabel.Parent = this;

          var lCoord = Map.GetCoord(lRow, lCol);

          var lMapElement = Map.GetMapElement(lRow, lCol);

          //This code allows responding to the change of value of the Map Element
          lMapElement.OnValueChange += MapPane_OnValueChange;

          MapLabels.Add(lCoord, lLabel);
        }
      }
    }

    public Coords GetCoord(int lRow, int lCol)
    {
      var lCoord = MapLabels.Keys.Where(p => p.X == lCol && p.Y == lRow).FirstOrDefault();

      return lCoord;
    }

    public Label GetLabel(int lRow, int lCol)
    {
      var lCoord = GetCoord(lRow, lCol);

      if (lCoord == null)
        return null;

      return MapLabels[lCoord];
    }

    public void ClearMap()
    {
      Map.ClearMap();

    }

    public void MapPane_OnValueChange(object sender, EventArgs e)
    {
      if(sender is MapElement)
      {
        var lMapElement = sender as MapElement;

        var lMapLabel = GetLabel(lMapElement.Coords.Y, lMapElement.Coords.X);

        if (lMapLabel != null)
        {
          lMapLabel.Text = lMapElement.Value;
        }
      }
    }
  }
}

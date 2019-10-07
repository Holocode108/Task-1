using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingMaps
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private MapPane fMapPane = null;

    public MapPane MapPane
    {
      get
      {
        if(fMapPane == null)
        {
          fMapPane = new MapPane(20, 20);

          fMapPane.Location = new Point(0, 0);
          fMapPane.Parent = pnlMap;
          fMapPane.Dock = DockStyle.Fill;
          fMapPane.Visible = true;
        }

        return fMapPane;
      }
    }

    public Map Map
    {
      get
      {
        return MapPane.Map;
      }
    }

    private void BtnBuildMap_Click(object sender, EventArgs e)
    {
      MapPane.ClearMap();
    }

    private void BtnAddUnits_Click(object sender, EventArgs e)
    {
      Map.SetValue(3, 5, "Hi");
      Map.SetValue(6, 9, "Cop");
      Map.SetValue(13, 15, "Rob");
      Map.SetValue(9, 5, "Luk");
      Map.SetValue(12, 5, "Ply");

    }

    private void BtnMove_Click(object sender, EventArgs e)
    {
      Map.ClearMap();

      timerGame.Enabled = true;

      Map.SetValue(2,2, "BBB");

      Map.SetValue(5, 4, "CCC");

      Map.SetValue(11, 6, "EEE");
    }

    private void BtnStop_Click(object sender, EventArgs e)
    {
      timerGame.Enabled = false;
    }

    private void TimerGame_Tick(object sender, EventArgs e)
    {
      var lRandom = new Random();

      var lList = Map.MapCoords.Values.Where(p => p.Value.Length > 0 && p.Coords.IsActive == true).ToList();

      foreach (var lMapElement in lList)
      {
        if (string.IsNullOrEmpty(lMapElement.Value))
        {
          //lMapElement.Value = lRandom.Next(100, 999).ToString();
        }
        else
        {
          lMapElement.Bump();
        }
      }
    }

    private void PnlMap_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}

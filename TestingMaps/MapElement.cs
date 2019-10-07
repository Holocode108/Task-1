using System;

namespace TestingMaps
{
  public class MapElement
  {
    public Map Owner { get; set; }

    public Coords Coords { get; set; }

    private string fValue = "";
    public string Value
    {
      get
      {
        return fValue;
      }
      set
      {
        fValue = value;

        if(OnValueChange != null)
          OnValueChange(this, EventArgs.Empty);
      }
    }

    public event EventHandler OnValueChange;

    public void Bump()
    {
      var lNext = Owner.GetMapElement(Coords.Y, Coords.X + 1);

      if(lNext != null)
      {
        lNext.Value = this.Value;
        this.Value = "";
      }

    }
  }
}

namespace TestingMaps
{
  partial class MapPane
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblSample = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblSample
      // 
      this.lblSample.Location = new System.Drawing.Point(8, 10);
      this.lblSample.Name = "lblSample";
      this.lblSample.Size = new System.Drawing.Size(35, 17);
      this.lblSample.TabIndex = 0;
      this.lblSample.Text = "XXX";
      this.lblSample.Visible = false;
      // 
      // MapPane
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gray;
      this.Controls.Add(this.lblSample);
      this.Name = "MapPane";
      this.Size = new System.Drawing.Size(800, 800);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblSample;
  }
}

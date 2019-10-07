namespace TestingMaps
{
  partial class Form1
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.btnBuildMap = new System.Windows.Forms.Button();
      this.pnlMap = new System.Windows.Forms.Panel();
      this.btnAddUnits = new System.Windows.Forms.Button();
      this.btnMove = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.timerGame = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // btnBuildMap
      // 
      this.btnBuildMap.Location = new System.Drawing.Point(12, 12);
      this.btnBuildMap.Name = "btnBuildMap";
      this.btnBuildMap.Size = new System.Drawing.Size(75, 23);
      this.btnBuildMap.TabIndex = 0;
      this.btnBuildMap.Text = "Build Map";
      this.btnBuildMap.UseVisualStyleBackColor = true;
      this.btnBuildMap.Click += new System.EventHandler(this.BtnBuildMap_Click);
      // 
      // pnlMap
      // 
      this.pnlMap.Location = new System.Drawing.Point(31, 53);
      this.pnlMap.Name = "pnlMap";
      this.pnlMap.Size = new System.Drawing.Size(1090, 800);
      this.pnlMap.TabIndex = 1;
      this.pnlMap.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMap_Paint);
      // 
      // btnAddUnits
      // 
      this.btnAddUnits.Location = new System.Drawing.Point(108, 12);
      this.btnAddUnits.Name = "btnAddUnits";
      this.btnAddUnits.Size = new System.Drawing.Size(75, 23);
      this.btnAddUnits.TabIndex = 2;
      this.btnAddUnits.Text = "Add Unit";
      this.btnAddUnits.UseVisualStyleBackColor = true;
      this.btnAddUnits.Click += new System.EventHandler(this.BtnAddUnits_Click);
      // 
      // btnMove
      // 
      this.btnMove.Location = new System.Drawing.Point(198, 12);
      this.btnMove.Name = "btnMove";
      this.btnMove.Size = new System.Drawing.Size(75, 23);
      this.btnMove.TabIndex = 3;
      this.btnMove.Text = "Move";
      this.btnMove.UseVisualStyleBackColor = true;
      this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(292, 12);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 4;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
      // 
      // timerGame
      // 
      this.timerGame.Interval = 1000;
      this.timerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1182, 953);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnMove);
      this.Controls.Add(this.btnAddUnits);
      this.Controls.Add(this.pnlMap);
      this.Controls.Add(this.btnBuildMap);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnBuildMap;
    private System.Windows.Forms.Panel pnlMap;
    private System.Windows.Forms.Button btnAddUnits;
    private System.Windows.Forms.Button btnMove;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Timer timerGame;
  }
}


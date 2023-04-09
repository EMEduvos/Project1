namespace Project1.Question2.Desktop
{
  partial class DashboardForm
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
      pictureBox1 = new PictureBox();
      label1 = new Label();
      progressBar1 = new ProgressBar();
      btnFaculty = new Button();
      btnTuition = new Button();
      btnDuration = new Button();
      treeFaculty = new TreeView();
      treeTuition = new TreeView();
      treeDuration = new TreeView();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources.Filled_Ranged_Colour_4x;
      pictureBox1.Location = new Point(63, 12);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(675, 143);
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.TabIndex = 0;
      pictureBox1.TabStop = false;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
      label1.Location = new Point(71, 158);
      label1.Name = "label1";
      label1.Size = new Size(658, 50);
      label1.TabIndex = 1;
      label1.Text = "Eduvos 2023 Study Planner Interface";
      // 
      // progressBar1
      // 
      progressBar1.Location = new Point(63, 247);
      progressBar1.Name = "progressBar1";
      progressBar1.Size = new Size(675, 29);
      progressBar1.TabIndex = 2;
      // 
      // btnFaculty
      // 
      btnFaculty.Location = new Point(63, 297);
      btnFaculty.Name = "btnFaculty";
      btnFaculty.Size = new Size(129, 53);
      btnFaculty.TabIndex = 3;
      btnFaculty.Text = "Faculty";
      btnFaculty.UseVisualStyleBackColor = true;
      // 
      // btnTuition
      // 
      btnTuition.Enabled = false;
      btnTuition.Location = new Point(336, 297);
      btnTuition.Name = "btnTuition";
      btnTuition.Size = new Size(129, 53);
      btnTuition.TabIndex = 4;
      btnTuition.Text = "Tuition";
      btnTuition.UseVisualStyleBackColor = true;
      // 
      // btnDuration
      // 
      btnDuration.Enabled = false;
      btnDuration.Location = new Point(609, 297);
      btnDuration.Name = "btnDuration";
      btnDuration.Size = new Size(129, 53);
      btnDuration.TabIndex = 5;
      btnDuration.Text = "Duration";
      btnDuration.UseVisualStyleBackColor = true;
      // 
      // treeFaculty
      // 
      treeFaculty.FullRowSelect = true;
      treeFaculty.HideSelection = false;
      treeFaculty.Location = new Point(63, 377);
      treeFaculty.Name = "treeFaculty";
      treeFaculty.Size = new Size(176, 246);
      treeFaculty.TabIndex = 6;
      treeFaculty.AfterSelect += TreeFaculty_AfterSelect;
      // 
      // treeTuition
      // 
      treeTuition.Location = new Point(311, 377);
      treeTuition.Name = "treeTuition";
      treeTuition.Size = new Size(176, 246);
      treeTuition.TabIndex = 7;
      treeTuition.AfterSelect += TreeTuition_AfterSelect;
      // 
      // treeDuration
      // 
      treeDuration.Location = new Point(562, 377);
      treeDuration.Name = "treeDuration";
      treeDuration.Size = new Size(176, 246);
      treeDuration.TabIndex = 8;
      // 
      // DashboardForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 666);
      Controls.Add(treeDuration);
      Controls.Add(treeTuition);
      Controls.Add(treeFaculty);
      Controls.Add(btnDuration);
      Controls.Add(btnTuition);
      Controls.Add(btnFaculty);
      Controls.Add(progressBar1);
      Controls.Add(label1);
      Controls.Add(pictureBox1);
      Name = "DashboardForm";
      Text = "Eduvos Planner Dashboard";
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private ProgressBar progressBar1;
    private Button btnFaculty;
    private Button btnTuition;
    private Button btnDuration;
    private TreeView treeFaculty;
    private TreeView treeTuition;
    private TreeView treeDuration;
  }
}
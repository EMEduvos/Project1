using Project1.Question2.Desktop.Entities;

namespace Project1.Question2.Desktop
{
  public partial class DashboardForm : Form
  {
    private readonly List<Faculty> _facultyList = new ();
    private string _selectedFaculty = string.Empty;
    private string _selectedProgram = string.Empty;

    public DashboardForm()
    {
      InitializeComponent();
      CompileData();
      PopulateFacultyTreeView();
      ConfigureProgressBar();
    }

    /// <summary>
    /// Configures the properties of the progress bar
    /// </summary>
    private void ConfigureProgressBar()
    {
      progressBar1.Minimum = 0;
      progressBar1.Maximum = 2;
      progressBar1.Value = 0;
      progressBar1.Step = 1;
    }

    /// <summary>
    /// Populates the Faculty Tree View with the Faculty information
    /// </summary>
    private void PopulateFacultyTreeView()
    {
      treeFaculty.BeginUpdate();
      treeFaculty.Nodes.Clear();

      foreach (var faculty in _facultyList)
      {
        treeFaculty.Nodes.Add(faculty.Name);
        foreach (var program in faculty.FacultyPrograms)
        {
          treeFaculty.Nodes[_facultyList.IndexOf(faculty)].Nodes.Add(program.Name);
        }
      }
      treeFaculty.ExpandAll();
      treeFaculty.EndUpdate();
    }

    /// <summary>
    /// Handle the selection event of the Faculty Tree View
    /// </summary>
    private void TreeFaculty_AfterSelect(object sender, TreeViewEventArgs e)
    {
      // Clear all the options for Tuition and Duration
      treeTuition.Nodes.Clear();
      treeDuration.Nodes.Clear();

      // Set the progress to 0, to allow recalculation of progress
      progressBar1.Value = 0;

      // Disable the buttons
      btnTuition.Enabled = false;
      btnDuration.Enabled = false;

      _selectedFaculty = e.Node.Parent?.Text;
      _selectedProgram = e.Node.Text;

      // Find the Tuitiuon details of the selected faculty program
      var qualifications = _facultyList.Where(x => x.Name == _selectedFaculty)
                                 .FirstOrDefault()?.FacultyPrograms
                                 .Where(c => c.Name == _selectedProgram)
                                 .First()
                                 .Qualifications
                                 .ToList();

      // Update the Tuition tree view with the selected information
      if (qualifications != null)
      {
        treeTuition.BeginUpdate();

        foreach (var qualification in qualifications)
        {
          treeTuition.Nodes.Add(qualification.Name);
          treeTuition.Nodes[qualifications.IndexOf(qualification)].Nodes.Add($"R{qualification.Tuition}");
        }

        treeTuition.ExpandAll();
        treeTuition.EndUpdate();
        progressBar1.PerformStep();
        btnTuition.Enabled = true;
      }
   }

    /// <summary>
    /// Handles the selection event of the Tuition Tree View
    /// </summary>
    private void TreeTuition_AfterSelect(object sender, TreeViewEventArgs e)
    {
      // Clear the Duration tree view
      treeDuration.Nodes.Clear();

      // Select the duration information for the selected faculty program & qualification
      var qualification = _facultyList.Where(x => x.Name == _selectedFaculty)
                                 .FirstOrDefault()?.FacultyPrograms
                                 .Where(c => c.Name == _selectedProgram)
                                 .First().Qualifications
                                 .Where(z => z.Name == e.Node?.Text || z.Name == e.Node?.Parent?.Text)
                                 .First();

      // Update the Duration tree view
      if (qualification != null)
      {
        treeDuration.BeginUpdate();

        treeDuration.Nodes.Add($"Full-Time: {qualification?.DefaultDurationYears} year");
        treeDuration.Nodes.Add($"Part-Time: +{qualification?.AdditionalDurationYears} additional year(s)");
        treeDuration.EndUpdate();

        btnDuration.Enabled = true;
        progressBar1.PerformStep();
      }
    }


    /// <summary>
    /// Compiles the data to be displayed
    /// </summary>
    private void CompileData()
    {
      _facultyList.Clear();
      _facultyList.Add(
        new Faculty("Commerce and Law", new List<FacultyProgram>
        {
          new FacultyProgram("Bachelor of Business Administration", new List<Qualification>
          {
            new Qualification("Higher Certificate", 55000, 1, 1),
            new Qualification("Bachelors Degree", 65000, 3, 1),
            new Qualification("Honours Degree", 50000, 1, 1)
          }),
          new FacultyProgram("Bachelor of Commerce Law", new List<Qualification>
          {
            new Qualification("Higher Certificate", 55000, 1, 1),
            new Qualification("Bachelors Degree", 65000, 3, 1),
            new Qualification("Honours Degree", 50000, 1, 1)
          })
        }));

      _facultyList.Add(
        new Faculty("Applied Science", new List<FacultyProgram>
        {
          new FacultyProgram("Bachelor of Science in Biomedicine", new List<Qualification>
          {
            new Qualification("Higher Certificate", 60000, 1, 1),
            new Qualification("Bachelors Degree", 65000, 3, 1),
            new Qualification("Honours Degree", 70000, 1, 1)
          }),
          new FacultyProgram("Bachelor of Science in Biotechnology Management", new List<Qualification>
          {
            new Qualification("Higher Certificate", 60000, 1, 1),
            new Qualification("Bachelors Degree", 65000, 3, 1),
            new Qualification("Honours Degree", 70000, 1, 1)
          })
        }));
      
      _facultyList.Add(
        new Faculty("Technology", new List<FacultyProgram>
        {
          new FacultyProgram("Bachelor of Science in Computer Science", new List<Qualification>
          {
            new Qualification("Higher Certificate", 75000, 1, 1),
            new Qualification("Bachelors Degree", 65000, 3, 1),
            new Qualification("Honours Degree", 80000, 1, 1)
          }),
          new FacultyProgram("Bachelor of Science in Information Technology", new List<Qualification>
          {
            new Qualification("Higher Certificate", 75000, 1, 1),
            new Qualification("Bachelors Degree", 65000, 3, 1),
            new Qualification("Honours Degree", 80000, 1, 1)
          })
        }));
      
      _facultyList.Add(
        new Faculty("Humanities and Arts", new List<FacultyProgram>
        {
          new FacultyProgram("Bachelor of Arts General", new List<Qualification>
          {
            new Qualification("Higher Certificate", 45000, 1, 1),
            new Qualification("Bachelors Degree", 55000, 3, 1),
            new Qualification("Honours Degree", 60000, 1, 1)
          }),
          new FacultyProgram("Bachelor of Arts in Graphic Design", new List<Qualification>
          {
            new Qualification("Higher Certificate", 45000, 1, 1),
            new Qualification("Bachelors Degree", 55000, 3, 1),
            new Qualification("Honours Degree", 60000, 1, 1)
          })
        }));
    }

  }
}

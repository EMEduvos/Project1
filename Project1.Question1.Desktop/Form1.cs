namespace Project1.Question1.Desktop
{
  public partial class Form1 : Form
  {
    private CampusLocation[] _campusArray;
    int _campusArrayIndex = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ConfigureCampusArray();
      ConfigureTimer(30000);
    }

    /// <summary>
    /// Initializes the campus array with a list of campus objects
    /// </summary>
    private void ConfigureCampusArray()
    {
      _campusArray = new CampusLocation[]
      {
        new CampusLocation ( picWesternCape, lnkLabelWesternCape, lnkWesternCapeDescription),
        new CampusLocation ( picNorthernCape, lnkLabelNorthernCape, lnkNorthernCapeDescription ),
        new CampusLocation ( picEasternCape, lnkLabelEasternCape, lnkEasternCapeDescription ),
        new CampusLocation ( picFreestate, lnkLabelFreestate, lnkFreestateDescription ),
        new CampusLocation ( picNorthWest, lnkLabelNorthWest, lnkNorthwestDescription ),
        new CampusLocation ( picGauteng, lnkLabelGauteng, lnkGautengDescription ),
        new CampusLocation ( picMpumalanga, lnkLabelMpumalanga, lnkMpumalangaDescription ),
        new CampusLocation ( picKwazuluNatal, lnkLabelKwazuluNatal,lnkKwazuluNatalDescription )
      };
    }

    /// <summary>
    /// Configures the timer with a given interval
    /// </summary>
    /// <param name="timerInterval">The interval to be used for the timer</param>
    private void ConfigureTimer(int timerInterval)
    {
      if(timerInterval <= 0)
        throw new ArgumentException("Time interval must be greater than 0", nameof(timerInterval));

      System.Windows.Forms.Timer timer = new()
      {
        Interval = timerInterval
      };
      timer.Tick += Timer_Tick; ;
      timer.Start();
    }

    /// <summary>
    /// Handles the rick event of the timer
    /// </summary>
    private void Timer_Tick(object? sender, EventArgs e)
    {
      _campusArray[_campusArrayIndex].LocationPinPicture.Visible = true;
      _campusArray[_campusArrayIndex].ProvinceLabel.Visible = true;
      _campusArray[_campusArrayIndex].ProvinceDescriptionLabel.Visible = true;

      if (_campusArrayIndex < _campusArray.Length - 1)
        _campusArrayIndex++;
      else
        _campusArrayIndex = 0;
    }
  }
}
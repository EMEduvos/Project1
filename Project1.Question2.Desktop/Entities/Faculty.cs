namespace Project1.Question2.Desktop.Entities
{
  /// <summary>
  /// Represents a Faculty 
  /// </summary>
  internal class Faculty
  {
    /// <summary>
    /// Instantiates a new instance of a <see cref="Faculty"/>
    /// </summary>
    /// <param name="name">The name of the <see cref="Faculty"/></param>
    /// <param name="facultyPrograms">The programs hosted by the <see cref="Faculty"/></param>
    public Faculty(string name, List<FacultyProgram> facultyPrograms)
    {
      Name = name;
      FacultyPrograms = facultyPrograms;
    }

    public string Name { get; }
    public List<FacultyProgram> FacultyPrograms { get; }
  }

  /// <summary>
  /// Represents a program hosted by a <see cref="Faculty"/> 
  /// </summary>
  internal class FacultyProgram
  {
    /// <summary>
    /// Creates a new instance of a <see cref="FacultyProgram"/>
    /// </summary>
    /// <param name="name">The name of the program</param>
    /// <param name="qualifications">The list of qualifications included in the program</param>
    public FacultyProgram(string name, List<Qualification> qualifications)
    {
      Name = name;
      Qualifications = qualifications;
    }

    public string Name { get; }
    public List<Qualification> Qualifications { get; }
  }

  /// <summary>
  /// Represents a qualification that can be obtained in a <see cref="FacultyProgram"/>
  /// </summary>
  internal class Qualification
  {
    /// <summary>
    /// Creates an instance of a <see cref="Qualification"/>
    /// </summary>
    /// <param name="name">The name of the qualification</param>
    /// <param name="tuition">The tuition required for the qualification</param>
    /// <param name="defaultDurationYears">The default duration to obtain the qualification</param>
    /// <param name="additionalDurationYears">Additional years required to obtain the qualification when studying part-time</param>
    public Qualification(string name, int tuition, int defaultDurationYears, int additionalDurationYears)
    {
      Name = name;
      Tuition = tuition;
      DefaultDurationYears = defaultDurationYears;
      AdditionalDurationYears = additionalDurationYears;
    }

    public string Name { get; }
    public int Tuition { get; }
    public int DefaultDurationYears { get; }
    public int AdditionalDurationYears { get; }
  }
}

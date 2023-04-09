namespace Project1.Question1.Desktop
{
  /// <summary>
  /// Represents a campus location with a pin, province and list of campuses
  /// </summary>
  internal class CampusLocation
  {
    private PictureBox _locationPinPicture;
    private LinkLabel _provinceLabel;
    private LinkLabel _provinceDescriptionLabel;

    /// <summary>
    /// Creates an instance of a <see cref="CampusLocation"/>
    /// </summary>
    /// <param name="locationPinPicture">The <see cref="PictureBox"/> to be used</param>
    /// <param name="provinceLabel">The <see cref="LinkLabel"/> for the Province</param>
    /// <param name="provinceDescriptionLabel">The <see cref="LinkLabel"/> for the Province Description</param>
    public CampusLocation(PictureBox locationPinPicture, LinkLabel provinceLabel, LinkLabel provinceDescriptionLabel)
    {
      _locationPinPicture = locationPinPicture;
      _provinceLabel = provinceLabel;
      _provinceDescriptionLabel = provinceDescriptionLabel;
    }

    public PictureBox LocationPinPicture { get { return _locationPinPicture; } }
    public LinkLabel ProvinceLabel { get { return _provinceLabel; } }
    public LinkLabel ProvinceDescriptionLabel { get { return _provinceDescriptionLabel; } }
  }
}

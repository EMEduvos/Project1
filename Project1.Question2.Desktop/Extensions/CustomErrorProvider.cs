namespace Project1.Question2.Desktop.Extensions
{
  /// <summary>
  /// Provides an extension of the <see cref="ErrorProvider"/>
  /// </summary>
  internal class CustomErrorProvider : ErrorProvider
  {
    private bool _hasErrors { get; set; }

    /// <inheritdoc/>
    public new void SetError(Control control, string value)
    {
      base.SetError(control, value);
      _hasErrors = true;
    }

    /// <inheritdoc/>
    public new void Clear()
    {
      base.Clear();
      _hasErrors = false;
    }

    /// <summary>
    /// Indicates whether errors have been set
    /// </summary>
    public bool HasErrors
    {
      get
      {
        return _hasErrors;
      }
    }
  }
}

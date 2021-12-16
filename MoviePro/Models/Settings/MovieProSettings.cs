namespace MoviePro.Models.Settings;

public class MovieProSettings
{
    public string DefaultBackdropSize { get; set; }
    public string DefaultPosterSize { get; set; }
    public string DefaultYouTubeKey { get; set; }
    public string DefaultCastImage { get; set; }
    public DefaultCollection DefaultCollection { get; set; }
}

public class DefaultCollection
{
    public string Name { get; set; }
    public string Description { get; set; }
}
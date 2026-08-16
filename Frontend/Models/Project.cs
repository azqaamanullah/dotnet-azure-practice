namespace Frontend.Models;

public class Project
{
    public string Title { get; set; } = "";

    public string Description { get; set; } = "";
    public string Image { get; set; } = string.Empty;
    public string LiveUrl { get; set; } = string.Empty;

    public List<string> Technologies { get; set; } = [];

    public string GitHubUrl { get; set; } = "";
}
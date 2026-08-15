namespace dotnet_azure_practice.Models;

public class Project
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string[] Technologies { get; set; } = [];

    public string GitHubUrl { get; set; } = "#";

    public string LiveUrl { get; set; } = "#";

    public string Image { get; set; } = string.Empty;
}
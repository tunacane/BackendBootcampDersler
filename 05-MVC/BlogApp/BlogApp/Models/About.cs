using System;
using Microsoft.Extensions.FileProviders;

namespace BlogApp.Models;

public class About
{
public string Name { get; set; }
public string Email { get; set; }

public IFileInfo UploadCV { get; set; }
}

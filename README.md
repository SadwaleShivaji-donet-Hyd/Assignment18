# 🖼️ Parallel Image Processing in C#

This project demonstrates **parallel image resizing** using C# and the **SixLabors.ImageSharp** library.  
It processes multiple images simultaneously using `.Parallel.ForEach`, improving performance by utilizing all available CPU cores.

---

## 🚀 Features

- Processes multiple images **in parallel**
- Automatically **resizes** each image to thumbnail size
- Saves processed images in an **output** directory
- Handles **errors gracefully**
- Cross-platform (works on Windows, macOS, Linux)

---

## 🧰 Technologies Used

| Component | Description |
|------------|--------------|
| **C# (.NET 8)** | Core programming language |
| **SixLabors.ImageSharp** | Modern, cross-platform image processing library |
| **System.Threading.Tasks.Parallel** | Used for parallelizing image processing |

---

## 🏗️ Project Structure

ImageProcessingParallel/
│
├── ImageProcessingParallel.csproj # Project file
├── Program.cs # Main source code
├── input/ # Folder containing original images
└── output/ # Folder for resized thumbnails

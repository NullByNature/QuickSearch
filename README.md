# 🔍 QuickSearch

**QuickSearch** is a simple C# console application that allows you to search for a **keyword** across files in selected directories (Desktop, Documents, or Downloads).  
It uses asynchronous file reading for better performance and responsiveness.

---

## 📦 Features

- 🗂️ Search files in Desktop, Documents, or Downloads folders
- ⚡ Asynchronous keyword scanning using `File.ReadAllTextAsync`
- ✅ Validates user input
- 📄 Lists all files where the keyword is found

---

## 💻 Technologies

- C# (.NET)
- `System.IO`
- `System.Threading.Tasks`
- `Environment.SpecialFolder`

---

## 🔮 Future Updates
Planned improvements and new features:

➕ Add more folder options (e.g. Music, Pictures, Custom Path Input)

🛠️ Choose what to do with matched files:

Open the file

Delete the file

Copy/move it to another folder

🔁 Option to include subfolders in the search

💾 Option to save results to a log or text file

📊 Show number of files scanned, skipped, and matched

⏱️ Display time taken for the full scan

🧼 Add a cleanup utility to remove empty or junk files



## 🚀 How to Run

1. Clone the repo:

   ```bash
   git clone https://github.com/yourusername/QuickSearch.git

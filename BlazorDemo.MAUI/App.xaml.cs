namespace BlazorDemo.MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //CopyDatabaseToAppData(Path.Combine("DataSources", "issue-list.db"));
            MainPage = new AppShell();
        }

//        public static void CopyDatabaseToAppData(string databaseName)
//        {
//            string filePath = Path.Combine(FileSystem.Current.CacheDirectory, "issue-list.db");
//            if (!File.Exists(filePath))
//            {
//#if IOS
//            File.Copy(databaseName, filePath);
//#else
//                var file = File.Create(filePath);
//                var task = FileSystem.Current.OpenAppPackageFileAsync(databaseName);
//                task.Wait();
//                var fileStream = task.Result;
//                fileStream.CopyTo(file);
//                fileStream.Close();
//                file.Close();
//#endif
//            }
//        }
    }
}
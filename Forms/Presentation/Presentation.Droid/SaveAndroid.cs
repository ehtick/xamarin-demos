#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.IO;
using Android.Content;
using Java.IO;
using Xamarin.Forms;
using System.Threading.Tasks;
using SampleBrowser;
using SampleBrowser.Presentation.Droid;
using AndroidX.Core.Content;

[assembly: Dependency(typeof(SaveAndroid))]
namespace SampleBrowser.Presentation.Droid
{
    class SaveAndroid: ISave
    {
        public void Save(string fileName, String contentType, MemoryStream stream)
        {
            string exception = string.Empty;
            string root = null;
            if (Android.OS.Environment.IsExternalStorageEmulated)
            {
                root = Android.App.Application.Context.GetExternalFilesDir(Android.OS.Environment.DirectoryDownloads).AbsolutePath;
            }
            else
                root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Java.IO.File myDir = new Java.IO.File(root + "/Syncfusion");
            myDir.Mkdir();

            Java.IO.File file = new Java.IO.File(myDir, fileName);

            if (file.Exists()) file.Delete();

            try
            {
                FileOutputStream outs = new FileOutputStream(file);
                outs.Write(stream.ToArray());

                outs.Flush();
                outs.Close();
            }
            catch (Exception e)
            {
                exception = e.ToString();
            }
            if (file.Exists() && contentType != "application/html")
            {
                Android.Net.Uri path = Android.Net.Uri.FromFile(file);
                string extension = Android.Webkit.MimeTypeMap.GetFileExtensionFromUrl(Android.Net.Uri.FromFile(file).ToString());
                string mimeType = Android.Webkit.MimeTypeMap.Singleton.GetMimeTypeFromExtension(extension);
                Intent intent = new Intent(Intent.ActionView);
                intent.SetFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                path = FileProvider.GetUriForFile(Android.App.Application.Context, Android.App.Application.Context.PackageName + ".provider", file);
                intent.SetDataAndType(path, mimeType);
                intent.AddFlags(ActivityFlags.GrantReadUriPermission);
                Android.App.Application.Context.StartActivity(intent);
            }
        }
    }
   
}
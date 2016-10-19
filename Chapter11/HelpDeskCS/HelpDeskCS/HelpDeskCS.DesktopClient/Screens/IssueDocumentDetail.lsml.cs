﻿// You can use and redistribute the code from this book (and sample application) for non-commercial and 
// most commercial purposes as long as you acknowledge the source and authorship. 
// You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
// The acknowledgment should include author, title, publisher, and ISBN. 
// An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2015 by Tim Leung, published by Apress, ISBN 978-1-4842-0767-3".

using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;
using System.Windows.Controls;
using Microsoft.LightSwitch.Threading;
using System.Runtime.InteropServices.Automation;

namespace LightSwitchApplication
{
    public partial class IssueDocumentDetail
    {
        partial void IssueDocument_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.IssueDocument);
        }

        partial void IssueDocument_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.IssueDocument);
        }

        partial void IssueDocumentDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.IssueDocument);
        }


        //Listing 11-8. Downloading a file
        partial void SaveFileFromDatabase_Execute()
        {
            // Invoke the method on the main UI thread                         
            Dispatchers.Main.Invoke(() =>
            {
                System.IO.MemoryStream ms =
                    new System.IO.MemoryStream(IssueDocument.IssueFile);

                Dispatchers.Main.Invoke(() =>
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();

                    if (saveDialog.ShowDialog() == true)
                    {
                        using (Stream fileStream = saveDialog.OpenFile())
                        {
                            ms.WriteTo(fileStream);
                        }
                    }

                });
            });
        }


        //Listing 11-9. Opening files in their default applications
        partial void OpenFileFromDatabase_Execute()
        {
            try
            {
                if ((AutomationFactory.IsAvailable))
                {
                    //this is where we'll save the file
                    string fullFilePath = System.IO.Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        IssueDocument.DocumentName);

                    byte[] fileData = IssueDocument.IssueFile.ToArray();

                    if ((fileData != null))
                    {
                        using (FileStream fs =
                            new FileStream(
                                fullFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fs.Write(fileData, 0, fileData.Length);
                            fs.Close();
                        }
                    }

                    dynamic shell = AutomationFactory.CreateObject("Shell.Application");
                    shell.ShellExecute(fullFilePath);
                }
            }
            catch (Exception ex)
            {
                this.ShowMessageBox(ex.ToString());
            }
        }





    }
}
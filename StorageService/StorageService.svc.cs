using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StorageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StorageService : IStorageService
    {
        public string Storefile(string fileName)
        {
            string fileNameMessage = "File Could Not Be Saved";
            string savePath = "C:\\Users\\isbob\\OneDrive\\Desktop\\CSE Class Projects\\445\\Project3\\GUI\\Files\\";
            int lastslash = 0;
            for(int i = 0; i < fileName.Length; i++) 
            {
                if(fileName[i].Equals("\\")) {
                    lastslash = i;
                }

            }
            string file = fileName.Substring(lastslash, fileName.Length - 1);
            string pathToCheck = savePath + file;
            string tempFileName = "";

            if(System.IO.File.Exists(pathToCheck))
            {
                int counter = 2;
                while (System.IO.File.Exists(pathToCheck))
                {
                    tempFileName = file + counter.ToString();
                    pathToCheck = savePath + tempFileName;
                    counter++;
                }
                fileNameMessage = savePath + tempFileName;
            }
            else
            {
                fileNameMessage = pathToCheck;
            }
            
            return fileNameMessage;
        }
    }
}

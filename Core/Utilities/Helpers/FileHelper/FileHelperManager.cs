﻿using Core.Utilities.Helpers.GuidHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath)) { 
            
            
            File.Delete(filePath);

            
            
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);  
            }

            return Upload(file, root);


        }

        public string Upload(IFormFile file, string root)
        {

            if (file.Length>0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);

                }




            }


            string extension = Path.GetExtension(file.FileName); // uzantı oluşturduk
            string guid = GuidHelper.GuidHelper.Create();   // unique bir isim yarattık
            string filePath = extension + guid;  // isim ve uzantı birleşti

            using (FileStream fileStream = File.Create(root + filePath))
            {

                file.CopyTo(fileStream);
                fileStream.Flush();  //arabellekten siliyor.
                return filePath;





            }


          









        }

        
    }
}

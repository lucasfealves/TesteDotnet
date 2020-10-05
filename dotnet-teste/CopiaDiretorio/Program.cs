using System;
using System.IO;

namespace Copia.Diretorio
{
    public class CopiaArquivosDiretorios
    {
        public static void Main(string[] args)
        {
            string pathNew = @"C:\NovoDiretorio";
            string pathOld = @"C:\Users\Public\Pictures";
            string fileName;
            string destFile;
            
            try
            {
                if (!Directory.Exists(pathOld)) {
                    throw new Exception("Camninho de imagens original não existe!");
                }

                if (Directory.Exists(pathNew)) {
                    Console.WriteLine(" Diretorio Existe!");
                }
                else
                {
                    Directory.CreateDirectory(pathNew);
                }    

                string[] files = Directory.GetFiles(pathOld);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string archive in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = Path.GetFileName(archive);
                    destFile = Path.Combine(pathNew, fileName);
                    try
                    {
                        File.Copy(archive, destFile, false);    
                    }
                    catch (System.Exception)
                    {
                         Console.WriteLine("Arquivo " + fileName + " já existe no caminho destino.");
                    }
                    
                } 

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}

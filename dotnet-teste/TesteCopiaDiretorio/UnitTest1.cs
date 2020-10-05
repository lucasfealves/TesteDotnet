using System;
using Xunit;
using System.IO;
using Copia.Diretorio;

namespace TesteCopiaDiretorio
{
    public class UnitTestandoDiretorios
    {
    
        [Fact]
        public void DiretoriosNaoExistentes()
        {
            string pathNew = @"C:\NovoDiretorio";
            string pathOld = @"C:\Users\Public\Pictures";
            
            Boolean dirExists = Directory.Exists(pathOld);
            Assert.True(dirExists);
            dirExists = Directory.Exists(pathNew);
            Assert.False(dirExists);
  
            CopiaArquivosDiretorios.Main(null);

            dirExists = Directory.Exists(pathNew);
            Assert.True(dirExists);

            int CountFiles = Directory.GetFiles(pathNew).Length;
            int CountFilesOldPath = Directory.GetFiles(pathOld).Length;
            Assert.True(CountFiles == CountFilesOldPath);
        }

        [Fact]
        public void DiretoriosExistentes()
        {
            string pathNew = @"C:\NovoDiretorio";
            string pathOld = @"C:\Users\Public\Pictures";
            
            Boolean dirExists = Directory.Exists(pathOld);
            Assert.True(dirExists);
            dirExists = Directory.Exists(pathNew);
            Assert.True(dirExists);

            CopiaArquivosDiretorios.Main(null);

            int CountFiles = Directory.GetFiles(pathNew).Length;
            int CountFilesOldPath = Directory.GetFiles(pathOld).Length;
            Assert.True(CountFiles == CountFilesOldPath);
        }

        [Fact]
        public void DiretoriosNaoExistentes2()
        {
            string pathNew = @"C:\NovoDiretorio";
            string pathOld = @"C:\Users\Public\Pictures2";
            
            Boolean dirExists = Directory.Exists(pathOld);
            Assert.False(dirExists);

            CopiaArquivosDiretorios.Main(null);

            int CountFiles = Directory.GetFiles(pathNew).Length;
            int CountFilesOldPath = 0;
            Assert.False(CountFiles == CountFilesOldPath);
        }
    }
}

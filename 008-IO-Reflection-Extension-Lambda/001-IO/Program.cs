using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace _001_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarDriveInfo();
            //MostrarDirectoryInfo();
            //MostrarFileInfo();
            //MostrarEnvironment();
            MostrarStreamReader();
            Console.ReadKey();
        }

        private static void MostrarStreamReader()
        {
            //MostrarLeituraPorLinha();
            MostrarLeituraAll();
        }

        private static void MostrarLeituraAll()
        {
            using (var arquivo = new StreamReader("Arquivo.txt"))
            {
                var conteudo = arquivo.ReadToEnd();

                Console.WriteLine(conteudo);

                arquivo.Close();
            }
        }

        private static void MostrarLeituraPorLinha()
        {
            using (var arquivo = new StreamReader("Arquivo.txt"))
            {
                var linha = String.Empty;

                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }

                arquivo.Close();
            }
        }

        private static void MostrarEnvironment()
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
        }

        private static void MostrarFileInfo()
        {
            foreach (var item in Directory.GetFiles(@"C:\Users\Admin\Desktop"))
            {
                var fi = new FileInfo(item);

                Console.WriteLine("Nome completo: {0}", fi.FullName);
                Console.WriteLine("Nome: {0}", fi.Name);
                Console.WriteLine("Extensão: {0}", fi.Extension);
                Console.WriteLine("Diretório (pasta): {0}",
fi.DirectoryName);
                Console.WriteLine("Tamanho: {0}", fi.Length);
                Console.WriteLine("Somente leitura? {0}", fi.IsReadOnly);
                Console.WriteLine("Criado em: {0}", fi.CreationTime);
                Console.WriteLine("Último acesso: {0}", fi.LastAccessTime);
                Console.WriteLine("Última gravação: {0}", fi.LastWriteTime);
                Console.WriteLine();
            }

            //File.Create(@"C:\Users\Admin\Desktop\arquivo.txt");

            //File.Delete(@"C:\Users\Admin\Desktop\arquivo.txt");
        }

        private static void MostrarDirectoryInfo()
        {
            var di = new DirectoryInfo("C:\\Users\\Admin\\Desktop"); 

            Console.WriteLine("Nome completo: {0}", di.FullName);
            Console.WriteLine("Existe: {0}", di.Exists);
            Console.WriteLine("Nome: {0}", di.Name);
            Console.WriteLine("Parent: {0}", di.Parent.Name);
            Console.WriteLine("Root: {0}", di.Root);
            Console.WriteLine("Criado em: {0}", di.CreationTime);
            Console.WriteLine("Data do último acesso: {0}",
di.LastAccessTime);
            Console.WriteLine("Data da última gravação: {0}",
di.LastWriteTime);

            Console.WriteLine();

            DirectoryInfo novo = di.CreateSubdirectory("novo");

            foreach (var item in novo.GetFiles())
            {
                Console.WriteLine(item.Name);
            }

            novo.Delete(true);
            
            Console.WriteLine();

            Console.WriteLine("Existe o outro? {0}", Directory.Exists(@"C:\Users\Admin\Desktop\outro"));

            Directory.CreateDirectory(@"C:\Users\Admin\Desktop\outro");

            Console.WriteLine("Existe o outro? {0}",
Directory.Exists(@"C:\Users\Admin\Desktop\outro"));
            
            Directory.Delete(@"C:\Users\Admin\Desktop\outro");
            
            Console.ReadKey();
        }

        private static void MostrarDriveInfo()
        {
            foreach (var item in DriveInfo.GetDrives())
            {
                Console.WriteLine("RootDirectory: {0}", item.RootDirectory);
                Console.WriteLine("IsReady: {0}", item.IsReady);

                if (item.IsReady)
                {
                    Console.WriteLine("VolumeLabel: {0}", item.VolumeLabel);
                    Console.WriteLine("TotalSize: {0}", item.TotalSize / 1024 / 1024);
                    Console.WriteLine("TotalFreeSpace: {0}", item.TotalFreeSpace/1024/1024);
                    Console.WriteLine("DriveFormat: {0}", item.DriveFormat);
                    Console.WriteLine("DriveType: {0}", item.DriveType);
                }

                Console.WriteLine();
            }
        }
    }
}

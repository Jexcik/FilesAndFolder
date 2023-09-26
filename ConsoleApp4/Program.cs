using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //DriveInfo[] drives = DriveInfo.GetDrives();//Получаем колличество дисков на компьютере
            //foreach (DriveInfo drive in drives)
            //{
            //Console.WriteLine($"Название: {drive.Name}");//Получаем имя диска
            //Console.WriteLine($"Тип: {drive.DriveFormat}");//Получаем формат диска
            //if (drive.IsReady) //Если диск готов к использованию
            //{
            //    Console.WriteLine($"Объем диска: {drive.TotalSize / 1024 / 1024 / 1024}");
            //    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace / Math.Pow(1024, 3)}");
            //}

            //Console.WriteLine(Directory.Exists(@"C:\Autodesk"));//Метод для проверки существования каталога

            //string dirName = @"C:\Users\User\Desktop\Сертификаты и портфолио";
            ////string dirName = ".";
            //DirectoryInfo directory = new DirectoryInfo(dirName);//Создаем класс асоциирующийся с текущей папкой
            //if (directory.Exists)//Метод для проверки существования каталога
            //{
            //    Console.WriteLine("Подкаталоги:");
            //    DirectoryInfo[] dirs = directory.GetDirectories();
            //    foreach (DirectoryInfo dir in dirs)
            //    {
            //        Console.WriteLine(dir.FullName);
            //    }
            //    Console.WriteLine();

            //    Console.WriteLine("Файлы: ");
            //    FileInfo[] files = directory.GetFiles();//Получаем список файлов которые находятся в данной папке
            //    foreach (FileInfo file in files)
            //    {
            //        Console.WriteLine(file.Name);
            //    }
            //}

            ////Создание папки
            //string path = @"C:\Users\User\Desktop\Stream";
            //string subpath = @"josef\directories";
            //DirectoryInfo dirInfo = new DirectoryInfo(path);
            //if(!dirInfo.Exists) 
            //{
            //    dirInfo.Create();
            //}
            //dirInfo.CreateSubdirectory(subpath);

            //Получение Информации о каталоге
            //string dirName = @"C:\Users\User\Desktop\Stream\josef\directories";
            //DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            //Console.WriteLine($"Название каталога: {dirInfo.Name}");
            //Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            //Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            //Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            //Console.WriteLine($"Родительский каталог: {dirInfo.Parent}");

            //Удаление каталога
            //string dirName = @"C:\Users\User\Desktop\Stream\josef";
            //try
            //{
            //    DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            //    dirInfo.Delete(false);//Папку надо удалять со всем содержимым
            //    Console.WriteLine("Каталог удален");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Работа с файлами
            //File; //Статический класс для работы с файлами
            //FileInfo file = new FileInfo(""); //Динамический класс для работы с конкретным файлом

            //Получение информации о файле
            //string path = @"C:\Users\User\Desktop\Сертификаты и портфолио\Foto.jpg";
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
            //{
            //    Console.WriteLine("Имя файла: {0}", fileInf.Name);
            //    Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
            //    Console.WriteLine("Размер: {0}", fileInf.Length);
            //}

            ////Удаление файла
            //string path = @"C:\Users\User\Desktop\Ссылки на видеоматериалы по курсу WEB на  ASP.NET.Core.txt";
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
            //{
            //    fileInf.Delete();
            //}

            ////Перемещение файла с одного места на другое
            //string path = @"C:\Users\User\Desktop\Макет сайта\IPhon14.jpg";
            //string newPath = @"C:\Users\User\Desktop\Сертификаты и портфолио\IPhon14.jpg";
            //FileInfo fileInf = new FileInfo(path);
            //if(fileInf.Exists) 
            //{
            //    fileInf.MoveTo(newPath);
            //}

            ////Копирование файла
            //string path = @"C:\Users\User\Desktop\Макет сайта\IPhon14.jpg";
            //string newPath = @"C:\Users\User\Desktop\Сертификаты и портфолио\IPhon14.jpg";
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
            //{
            //    fileInf.CopyTo(newPath,true); //Копирует файл из одной папки в другую, true значит что файл перезаписывается если он существует
            //}

            //Чтение и запись из файла

            //Создаем каталог для файла
            //string path = @"C:\Users\e.egorov\Desktop\FilesAndFolders";
            //    DirectoryInfo dirInfo = new DirectoryInfo(path);
            //    if (!dirInfo.Exists)
            //    {
            //        dirInfo.Create();
            //    }
            //Console.WriteLine("Введите строку для записи в файл:");
            //string text = Console.ReadLine();

            //Запись в файл
            //using (FileStream fstream = new FileStream($@"{path}\Произвольный файл.txt", FileMode.OpenOrCreate)) //using Открываем соединение с файлом
            //{
            //    //Преобразуем строку в байты
            //    byte[] array = System.Text.Encoding.Default.GetBytes(text); //Кодирование строки в массив байтов
            //    //Запись массива байтов в файл
            //    fstream.Write(array, 0, array.Length);
            //    Console.WriteLine("Текст записан в файл");
            //}

            //Чтение из файла
            //using (FileStream fstream = File.OpenRead($@"{path}\Произвольный файл.txt"))
            //{
            //    //Преобразуем строку в байты
            //    byte[] array = new byte[fstream.Length];
            //    //Считываем данные
            //    fstream.Read(array, 0, array.Length);
            //    //Декодируем байты в строку
            //    string textFromFile = System.Text.Encoding.Default.GetString(array);
            //    Console.WriteLine($"Текст из файла: {textFromFile}");
            //}

            Console.WriteLine("Введите название создаваемого файла");
            string file = Console.ReadLine();
            string writePath = $@"C:\Users\e.egorov\Desktop\FilesAndFolders\{file}.txt"; //Получаем ссылку на файл для записи

            Console.WriteLine("Введите информацию для записи в файл!");
            string text = Console.ReadLine();//Вводим новый текст который мы хотим записать в файл
            //Класс позволяющий записывать данные в файл
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.UTF8)) //Открываем соединение с файлом
            {
                sw.WriteLine(text);// Записываем в файл введеный текст
            }

            //using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            //{
            //    sw.WriteLine("Дозапись");
            //    sw.Write(4.5);
            //}
            //Console.WriteLine("Запись выполнена!");
            string readPath = $@"C:\Users\e.egorov\Desktop\FilesAndFolders\{file}.txt"; //Получаем ссылку на файл для чтения
            using(StreamReader sr = new StreamReader(readPath))
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
//}

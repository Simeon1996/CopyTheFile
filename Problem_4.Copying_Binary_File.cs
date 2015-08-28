using System;
using System.IO;

    class Problem_4_Copying_Binary_File
    {
        static void Main()
        {

            Console.WriteLine("Please, enter the path of the file you want to copy: ");
            string filePath = Console.ReadLine();

            FileStream reader = new FileStream(filePath,FileMode.Open,FileAccess.Read);
            FileStream writer = new FileStream("copiedFile", FileMode.Create, FileAccess.Write);

            using (reader)
            {
                using (writer)
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }

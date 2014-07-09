using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class Workflow
    {

        static void wf()
        {
             var watch = Stopwatch.StartNew();

            String mail = null;

            //Console.WriteLine("Enter the path of the folder with files to be encrypted/decrypted...");

            string beginPath = "C:\\Users\\Lucas\\Desktop\\Projet DAD\\en crypt session 1 key";
            string outFile = "C:\\Users\\Lucas\\Desktop\\Projet DAD\\en crypt session 1 key\\result.txt";
            TextWriter tw = new StreamWriter(outFile);


            string filePath = "C:\\Users\\Lucas\\Desktop\\Projet DAD\\en crypt session 1 key\\F18.txt";



            //string[] files = Directory.GetFiles(beginPath, "*.txt"); 

            //Console.WriteLine("Enter the path of the output file.");

            //string endPath = Console.ReadLine(); //Variable which holds the output file's location.
            //Parallel.ForEach(files, filePath =>
           // {
                Console.WriteLine("Ouverture du fichier " + filePath);


                Parallel.For(10000, 100000, i =>
                {
                    String enKey = i.ToString();
                    String result = Decrypt.EncryptDecrypt(File.ReadAllText(filePath), enKey);
                   
                    /*mail = CheckMail(result);

                    if (mail != null)
                    {
                        //watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds;
                        Console.WriteLine("MAIL : " + mail + "; KEY : " + enKey + "; FILE : " + filePath);


                        TextWriter.Synchronized(tw).WriteLine("MAIL : " + mail + "; KEY : " + enKey + "; FILE : " + filePath);
                        TextWriter.Synchronized(tw).WriteLine("TIME TO FIND EMAIL : " + elapsedMs);

                        tw.Flush();


                    }
                    */

                    //TextWriter tw = new StreamWriter(endPath);

                    //tw.WriteLine(encoded);


                    // tw.Close();



                    //Console.WriteLine("Encoding finished.");

                    //Console.WriteLine("Opening output file now...");

                    //Process.Start("notepad.exe", endPath);


                });

                watch.Stop();
                var elapsedMs2 = watch.ElapsedMilliseconds;
                Console.WriteLine("Rien dans " + filePath);
                TextWriter.Synchronized(tw).WriteLine("TIME TO DECRYPT WITH ALL KEY : " + elapsedMs2);

                tw.Flush();
                tw.Close();
            //});
   
            Console.ReadLine();

        }
        }
    }


using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_threaded_programming
{
    class Program
    {
        private static object args;
        private static int a;
        private static int b;

        static object Main(string[] args)
        {
            //1
            int i = 0;
            List<int> numbers = new List<int>();
            while (i < 100)
            {
                Random r = new Random[next.(0, 50)];
                i++;
            }
            List<int> result_list = List.Where(i < 10).ToList();
            List<int> result_list = list.Where(i % 3 == 0).ToList();
            List<int> result_list = list.Where(i > 20 && i % 2  0).ToList();
            int e = 100;
            while (e > 0)
            {
                e--;
            }



            //2
            List<string> names = List.ToList();
            names.Add(new List("Asaf", "avi", "adi", "ami", "asi", "eli", "emi", "edi", "peni", "iosi"));



            //3
            static int Add(int x, int y)
            {
                return x + y;
            }



            //7
            class EventArgs
        {
            public string DishName { get; set; };
        }
           

        class kitchen
        {
            public event EventHandler<DishEventArgs> DishReady d()
        }
        static void PrepareDish p()
        {
            Console.WriteLine(PrepareDish);
            p.OnDishReady;
            static void OnDishReady o()
                {
                if(prop is not null)
                {
                    d.invokw;
                }

            }
            class waiter
            static void OnDishReady()
        {
            Console.WriteLine($"Servingcustomers, {DishName} ")");

        }
        kitchen k = new kitchen();
        waiter w = new waiter();
    }



    //12
    Thread t22 = Thread.Run(() => Console.WriteLine("helo word");



            //14
            static int dwon()
            {
                Console.WriteLine(" file Downloading ");
                Thread.Sleep(5000);
                Console.WriteLine("completed");
            }
            static int xx(int x, int y)
            {
                return x * y;
            }

            //19
            public void DoctorTreatment();
            {
                object key = null;
                lock (key)
                {
                    Console.WriteLine(" Whaiting fot my turn ");
                    Thread Sleep(5000);


                }.ContinueWith(("checking is Nurse ") =>
                    {
                    object key = null;
                    lock (key)
                    {
                        Console.WriteLine(" Whaiting fot my turn ");
                        Thread Sleep(5000);
                        Console.WriteLine("!please patient Next .");
                    }
                    Task t2 = Task.Run(() =>
                    {


                        Thread.Sleep(5000);
                        Thread.Sleep(5000);
                        Thread.Sleep(5000);

                    });

                    t2.Start();
                };
            } }


           //22
           private ManualResetEvent gate = new ManualResetEvent(false);
        public void EnterClab()
        {

            gate.WaitOne();
            Console.WriteLine("Waiting to enter");
        }
        int i = 0;
        while (i<=50)
            {
            Thread t8 = new Thread();
        i++;
    } }
    new Thread(() => { gate.EnterClab(); }).Start();
    Thread.Sleep(3000);
    Console.ReadLine();
private AutoResetEvent gate = new AutoResetEvent(false);




//question 25,b
Task t = new Task(() =>
            {
                Thread.Sleep(10000);
            }, TaskCreationOptions.LongRunning);
            t.Start();
            t.Wait();


            //question 26
            Task<int> t1 = new Task<int>(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Hello from Task world!");
                return 5 + 5;
            }, TaskCreationOptions.LongRunning);
            t1.Start();
            t1.Wait();
            Console.WriteLine($"result is {t1.Result}");


            //question 27, b
            Task.Run<string>(() =>
            {
                Console.WriteLine($"Starting task ....{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
                Console.WriteLine($"Task completed ....{Thread.CurrentThread.ManagedThreadId}");
                return "Welcome";

            }).ContinueWith((Task<string> antecendent) =>
            {
                Console.WriteLine("Task child");
                Console.WriteLine($"Task completed ....{Thread.CurrentThread.ManagedThreadId}");
                return "Goodbye";
            });


            //question 28
            Task d = Task.Run(() =>
            {
                DateTime d = DateTime.Now;
                Console.WriteLine($"The date is {d}");
            }).ContinueWith((Task child) =>
            {
                (TaskContinuationOptions.NotOnFaulted;
                DateTime d = DateTime.Now;
                Console.WriteLine($"The child d is{d}");
            });



            //question 29. b
            Task t11 = new Task(() =>
              {

                  Thread.Sleep(5000);
              }
              );
            t11.Start();
            Console.WriteLine(t11.IsCompleted);

            Task t2 = Task.Run(() =>
            {

                Thread.Sleep(5000);

            });

            t2.Start();
            Console.WriteLine(t2.IsCompleted);

            Task t3 = Task.Run(() =>
            {

                Thread.Sleep(5000);

            });

            t3.Start();
            Console.WriteLine(t3.IsCompleted);

            Console.WriteLine("All tasks are done");


            Task.WaitAll(new[] { t11, t2, t3 });


            //question 30

            Task ta = new Task(() =>
            {
                Random r = new Random();
                int sleep_time = r.Next();

                Thread.Sleep(sleep_time);

                Console.WriteLine("hello from new Task ended...");
            }
           );

            ta.Start();



            Task tb = Task.Run(() =>
            {
                Random r = new Random();
                int sleep_time = r.Next();

                Thread.Sleep(sleep_time);
                Console.WriteLine("hello from new Task.Run ended...");
            });

            tb.Start();


            Task tc = Task.Run(() =>
            {
                Random r = new Random();
                int sleep_time = r.Next();

                Thread.Sleep(sleep_time);
                Console.WriteLine("hello from new Task.Run ended...");
            });

            tc.Start();
            Task.WaitAny(new[] { ta, tb, tc, Task.Run(() => { }) });

            Console.WriteLine("Task is done");


            //question 33

            const int x = 40;
            Task M1 = Task.Run(() =>
            {
                public static void MyTimer()
                {
                    while ()
                    {
                        int Count = 0;
                        Count++;
                        Thread.Sleep(1000);
                    }
                }
            });
            Console.WriteLine("starting is Timer ");
            M1.Start();
            Console.ReadLine();
            M1.Dispose();
            Console.WriteLine("X: stopped is Timer");



            //question 34
            List<int> number = new List<int> { 15, 3 };
            Workers w = new Workers();
            w.MultiplyX2(number);
        }


        //question 38
        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }


        private static async Task WriteWebRequestSizeAsync(string url)
        {
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    await webRequest.GetResponseAsync();
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        await reader.ReadToEndAsync();
                    Console.WriteLine(
                        FormatBytes(text.Length));
                }
            }
            catch (WebException)
            {
                // ...
            }
            catch (IOException)
            {

                // ...
            }
            catch (NotSupportedException)
            {
                // ...
            }
            string url = "http://www.IntelliTect.com";
            if (args.Length > 0)
            {
                url = args[0];
            }

            Console.Write(url);

            Task task = WriteWebRequestSizeAsync(url);

            while (!task.Wait(100))
            {
                Console.Write(".");
            }
            

        }

    }

}


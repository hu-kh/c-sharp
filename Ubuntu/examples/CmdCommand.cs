
using System;
using System.Threading;

namespace CMDCommand
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("write your Command: ");
            string cmd = Console.ReadLine();

            ExecuteCommandSync(cmd);

            Console.ReadKey();
        }


        static void ExecuteCommandSync(object command)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                string result = proc.StandardOutput.ReadToEnd();

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        static void ExecuteCommandAsync(string command)
        {
            try
            {
                Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync));
                objThread.IsBackground = true;
                objThread.Priority = ThreadPriority.AboveNormal;
                objThread.Start(command);
            }
            catch (ThreadStartException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (ThreadAbortException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}


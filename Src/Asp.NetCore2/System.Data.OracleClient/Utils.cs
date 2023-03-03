//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Reflection;
//using System.Text;
//using System.Linq;

//namespace System.Data.OracleClient
//{
//    /// <summary>
//    /// OracleUtils 用于设置在 Linux下的 Oracle_instant_client 客户端的路径;
//    /// </summary>
//    public static class OracleUtils
//    {
//        /// <summary>
//        /// 设置 Oracle Instant Client的路径; <br/>
//        /// 如果已经设置，则不进行任何操作;
//        /// </summary>
//        /// <param name="dir">不带后面的 / </param>
//        public static void SetInstantClientDir(string dir)
//        {
//            if (System.Environment.OSVersion.Platform == PlatformID.Unix) 
//            {
//                var oracleHome = System.Environment.GetEnvironmentVariable("ORACLE_HOME");
//                var currentDir = Path.GetDirectoryName(StartupDllFilename);
//                if (oracleHome != dir) // 变更;
//                {
//                    string cmd = @$"export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:{dir}
//export NLS_LANG=""SIMPLIFIED CHINESE_CHINA.ZHS16GBK""
//export OCI_HOME={dir}
//export OCI_LIB_DIR={dir}
//export ORACLE_HOME={dir}
//cp -f {dir}/libociei.so {currentDir}/runtimes/linux-x64/native/liboci.so";
//                    Console.WriteLine(cmd);
//                    cmd.Split('\n').ToList().ForEach(x => x.Trim().Bash());
//                }
//            }


//        }
//        public static string Bash(this string cmd)
//        {
//            var escapedArgs = cmd.Replace("\"", "\\\"");

//            var process = new Process() {
//                StartInfo = new ProcessStartInfo {
//                  //  FileName = "/bin/bash",
//                    FileName = cmd,
//                    // Arguments = cmd, // $"-c \"{escapedArgs}\"",
//                    RedirectStandardOutput = true,
//                    UseShellExecute = false,
//                    CreateNoWindow = true,
//                }
//            };
//            process.Start();
//            string result = process.StandardOutput.ReadToEnd();
//            process.WaitForExit();
//            return result;
//        }
//        /// <summary>
//        /// 启动的dll名称或者exe文件的名称
//        /// </summary>
//        public static string StartupDllFilename
//        {
//            get
//            {
//                var args = Environment.GetCommandLineArgs()[0];
//                if (args.StartsWith("dotnet"))
//                {
//                    return Assembly.GetEntryAssembly().Location;
//                }
//                return args;
//            }
//        }
//    }
//}

using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Util
{
    public static class Trace
    {
        public static void WriteLine(string message,
                                     [CallerFilePath] string file = "",
                                     [CallerLineNumber] int line = 0,
                                     [CallerMemberName] string member = "")
        {
            var s = string.Format("{0}:{1} - {2}: {3}", file, line, member, message);
            Debug.WriteLine(s);
        }

        public static void WriteMethod([CallerFilePath] string file = "",
                                       [CallerMemberName] string member = "")
        {
            // ファイルパスからファイル名のみ抜き出す
            var paths = file.Split('/');
            var fileName = paths[paths.Length - 1];

            var s = string.Format("{0} - {1}", fileName, member);
            Debug.WriteLine(s);
        }
    }
}

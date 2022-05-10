using System;
using System.Collections;

public partial class ユーザー天翔記クラス : 天翔記クラス
{
    public static void デバッグ出力(object obj)
    {
        System.Diagnostics.Trace.WriteLine(obj);
    }

    public static void デバッグ出力(string str)
    {
        System.Diagnostics.Trace.WriteLine(str);
    }
}

public static class ユーザー天翔記クラス特殊拡張
{
    public static bool Exists(this System.Collections.ICollection list, int 番号)
    {
        if (0 <= 番号 && 番号 < list.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
 }



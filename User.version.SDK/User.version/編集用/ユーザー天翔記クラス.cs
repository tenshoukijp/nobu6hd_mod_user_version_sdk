using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


public partial class ユーザー天翔記クラス : 天翔記クラス
{
    /// 起動環境設定オブジェクトだけ扱える。
    public static void My_ランチャーウィンドウ起動時()
    {
    }

    /// これ以降は原則的には全て扱える。
    public static void My_ゲームウィンドウ起動時()
    {
    }

    public static string My_データファイル読込直前(string 元ファイル名)
    {
        return "";
    }

    public static string My_ＢＧＭ再生直前(int ＢＧＭ番号, int ＢＧＭシーン番号, string 元ファイル名)
    {
        return "";
    }

    public static string My_ＭＯＶＩＥ再生直前(int ＭＯＶＩＥ番号, string 元ファイル名)
    {
        return "";
    }

    public static void My_シナリオ選択直後(string シナリオファイル名)
    {
    }

    public static string My_噴出メッセージ直前(string 元メッセージ, 噴出メッセージパラメタ型 パラメタ)
    {
        return "";
    }

    public static void My_戦略_軍団ターン変更時(int 軍団番号)
    {
    }

    public static void My_戦争開始時(int 城番号, 戦争開始パラメタ型 パラメタ)
    {
    }

    public static void My_戦争参加勢力決定直後()
    {
    }

    public static void My_戦争_残りターン変更時(int 残りターン数)
    {
    }

    public static void My_戦争終了時()
    {
    }
}


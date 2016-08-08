# ExcelCSX

ExcelCSXは、Microsoft Excel上で C# Scriptを実行可能とするExcelアドインです。

ExcelCSXを使うことで、VBAのような手軽さで、C# Scriptを用いてExcelを操作できるようになります。

導入方法や使い方、C# ScriptでExcelを操作する方法について詳しくは、

- [Excel C# Script入門講座へようこそ！](http://mokumokucsharp.hateblo.jp/entry/2016/07/13/140602)

をご参照下さい。

## このプロジェクトについて

Excel上でC# Scriptを実行するにあたっては、[Roslyn for Scripting](https://github.com/dotnet/roslyn/wiki/Scripting-API-Samples)を用いています。

C# Scriptの記法については、[Roslyn for Scripting](https://github.com/dotnet/roslyn/wiki/Scripting-API-Samples)に準拠しています。

ExcelCSXでは、より手軽にExcelを操作できるように若干の機能の追加（デフォルト状態での参照ライブラリの追加と、Excel.Applicationオブジェクトへの簡易アクセス手段の追加）を施しています。

## ExcelCSXを動作させるための必須要件

- Windows7以降
- .NET Framework 4.6以上
- Excel2007以降

## ライセンス

- [The MIT License (MIT)](https://github.com/dck-jp/ExcelCSX/blob/master/LICENSE.txt)

MIT ライセンスの下で公開する、オープンソース / フリーソフトウェアです。


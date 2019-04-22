2019/04/22以降、このプロジェクトに関しては "開発休止" とさせていただきます。 つまり、今後は改善や新機能のご提案についてお応えできません。 バイナリについては停止をとりやめ、ソースコードのみ公開を継続します。
※　社内ツールとして2019初頭まで利用していたため、ビルドは可能な"はず"です (無保証です)。

もしかすれば、ふと余裕ができたときに、突然開発を再開するかもしれません。
が、再開の可能性は低いため、改良を加えたくなった場合は、フォークしてください。

---

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


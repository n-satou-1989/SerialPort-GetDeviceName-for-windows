# SerialPort-GetDeviceName-for-windows

シリアルポートに接続済みデバイス名とCOM番号を取得する

### 使用ライブラリ

https://www.nuget.org/packages/Microsoft.Windows.Compatibility

### 対応プラットフォームをWindows7以降に限定する

「AssemblyInfo.cs」に下記を追加
> [assembly: System.Runtime.Versioning.SupportedOSPlatform("windows7.0")]

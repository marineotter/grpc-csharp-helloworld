### 環境

```shell
$ uname -r
5.10.102.1-microsoft-standard-WSL2

$ cat /etc/os-release
PRETTY_NAME="Ubuntu 22.04 LTS"

$ dotnet --version
6.0.300
```

### プロジェクトの初期化

1. `dotnet new grpc` で.NET 6.0のプロジェクトを作成。
2. `dotnet new gitignore` で.gitignoreファイルを作成。
3. `dotnet build` で一度ビルドしておく。
4. Properties/launchSettings.json を編集し、httpのみのlistenに変更。
5. Protos フォルダのprotoファイルを使用したいものに差し替え。.csprojファイルの定義も同様に差し替え。 Services フォルダのサービスも作り変え。


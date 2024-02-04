# Console Framework
Console framework for [Rust](https://store.steampowered.com/app/252490/Rust/) using the [Oxide/uMod](https://umod.org) extension platforms allowing you to log in Pterodactyl's console using colors. *(might work in other console, but hasn't been tested)*

## Getting Started
1. Grab the Oxide.Ext.ConsoleExt.dll from latest release
2. Put the DLL into `RustDedicated_Data\Managed` folder
3. Restart the server

## Usage
```csharp
using Oxide.Ext.ConsoleExt;

// some code
OxideConsole.Log("Hello World", OxideConsole.GREEN);
```
![image](https://github.com/ilovepatatos-rust/console-extension/assets/49655463/ce609a19-1f12-4554-b488-9043555a9b40)

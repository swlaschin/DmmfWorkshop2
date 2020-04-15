## F# Syntax 

For help with F# syntax, see `doc/fsharp-basic-syntax.pdf`

## Troubleshooting the editor

If you see red squigglies,
* In all systems, delete the "obj" directory and clear caches

VS Code errors:
1. go to VSCode settings 
2. "Use Sdk Scripts": Use 'dotnet fsi' instead of 'fsi.exe'/'fsharpi' checkbox. 
3. (optionally) "Dot Net Root": change to /usr/share/dotnet/ or whatever the path is

## Troubleshooting F# compiler errors

If you don't understand a compiler error, try reading `doc/TroubleshootingFsharp.pdf`


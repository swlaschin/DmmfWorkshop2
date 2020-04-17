// ================================
// Check that F# is working
//
// Highlight/select the "printfn "Hello World" line below
// and run it interactively

printfn "Hello World"

// Using VisualStudio:
//   1. right click and do "Execute in Interactive"
//      shortcut: Alt+Enter
//   2. then check that "F# interactive" window appears and "Hello World" is output
//
// Using VS Code:
//   1. Ctrl+Shift+P and do "FSI: Send Selection"
//      shortcut: Alt+Enter
//   2. then check that "F# interactive" terminal appears and "Hello World" is output
//
// ================================

// expected output...
(*

Hello World
val it : unit = ()

*)


// ================================
// Troubleshooting
// ================================

(*
If you see red squigglies,
* In all systems, delete the "obj" directory and clear caches

VS Code errors:
1. go to VSCode settings
2. "Use Sdk Scripts": Use 'dotnet fsi' instead of 'fsi.exe'/'fsharpi' checkbox.
3. (optionally) "Dot Net Root": change to /usr/share/dotnet/ or whatever the path is

*)

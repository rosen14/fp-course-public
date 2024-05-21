// For more information see https://aka.ms/fsharp-console-apps
open MyLibrary

[<EntryPoint>]
let entrada args =
    printfn "Esta es la funcion entry point"
    Say.hello "Rosendo"
    Math.imprimeAdd 2 3
    0

//printfn "Hello from F#"

// Learn more about F# at http://fsharp.org

open System
open MyLibrary.Types

[<EntryPoint>]
let main argv =
    let myVar = MyType ""
    printfn "%i" (MyTypeExtensions.ValueLength myVar) // this works
    myVar.ValueLength() // this does not work
    0 // return an integer exit code

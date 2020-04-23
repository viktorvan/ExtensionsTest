namespace MyLibrary.Types
open System.Runtime.CompilerServices

[<Extension>]
module MyType =
    [<Extension>]
    let ValueLength (m: MyType) = m.Value.Length

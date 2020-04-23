namespace MyLibrary.Types
open System.Runtime.CompilerServices

[<Extension>]
module MyTypeExtensions =
    [<Extension>]
    let ValueLength (m: MyType) = m.Value.Length

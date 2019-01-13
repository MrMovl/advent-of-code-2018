module HelloWorld

open System.IO
let hello: string = 
    let ParseFile = File.ReadAllLines("input")
    
    ParseFile
        |> Seq.sum 
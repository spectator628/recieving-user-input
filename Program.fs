open System

[<EntryPoint>]
let main argv =
    printfn "Hey whats your name?"

    let name = Console.ReadLine()

    printfn "Where are you from?"

    let address = Console.ReadLine();

    printfn "Where are you visiting?"

    let visiting = Console.ReadLine();

    printfn "So %s, you're here visiting %s from %s, how nice, have a greagt trip!" name address visiting

    0 // return an integer exit code

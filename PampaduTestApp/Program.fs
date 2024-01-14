open StateMachine
open Types
open StringConverters
open System

// Заполнение массива с консоли
let readArrayFromConsole() =
    printfn "\nВведите количество событий: "
    
    let mutable size = 0
    try
        size <- Console.ReadLine() |> int
    with
        | ex -> 
            printfn("\nНекорректно задан размер массива событий!")
            ()

    if size > 0 then
        printfn "\nВведите события:"
    
    // Чтение элементов массива пока он не заполнится
    let rec readValues(index, acc) =
        if index >= size then
            acc
        else
            printf "Событие %d: " (index + 1)
            let value = Console.ReadLine()
            let event = eventFromString(value)
            let updatedAcc = acc @ [ event ]
            readValues(index + 1, updatedAcc)

    readValues(0, [])

[<EntryPoint>]
let main _ =
    Console.WriteLine("Введите начальное событие:")
    let startState = Console.ReadLine() |> GetState
    let mutable endState = startState
    if startState <> ERROR then
        let events = readArrayFromConsole()
        endState <- processEvents(startState, events)
    printfn "\nКонечное состояние:\n%s" (endState.ToString())
    0
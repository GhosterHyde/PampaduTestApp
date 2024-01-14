module StateMachine

open System
open Types
open Transitions

// Переход между состояниями по заданным событиям
let processEvents (startState, events) =
    let rec processOnce current_state events =
        match events with
        | [] -> current_state
        | e :: rest ->
            let state = transition current_state e
            processOnce state rest
    try
        processOnce startState events
    with
    | :? InvalidOperationException -> ERROR
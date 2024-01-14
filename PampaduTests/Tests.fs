namespace PampaduTests

open Microsoft.VisualStudio.TestTools.UnitTesting
open StateMachine
open Types
open StringConverters

[<TestClass>]
type TestClass () =

    let startState = CLOSED

    let mapEventArrayToList array =
        let eventList = 
            array
            |> Array.map eventFromString
            |> Array.toList
        eventList

    member private this.TestStateTransaction(events : string[], expectedState : State) =
        let eventList = mapEventArrayToList(events)
        let endState = processEvents(startState, eventList)
        Assert.AreEqual(expectedState, endState)

    [<TestMethod>]
    member this.Established_ResultCorrect() =
        this.TestStateTransaction([|"APP_PASSIVE_OPEN"; "APP_SEND"; "RCV_SYN_ACK"|], ESTABLISHED)

    [<TestMethod>]
    member this.Syn_Sent_ResultCorrect() =
        this.TestStateTransaction([|"APP_ACTIVE_OPEN"|], SYN_SENT)

    [<TestMethod>]
    member this.Error_Result() =
        this.TestStateTransaction([|"APP_ACTIVE_OPEN"; "RCV_SYN_ACK"; "APP_CLOSE"; "RCV_FIN_ACK"; "RCV_ACK"|], ERROR)
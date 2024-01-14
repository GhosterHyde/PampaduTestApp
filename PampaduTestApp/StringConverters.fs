module StringConverters
open Types

// Преобразование строковых значений состояний в типизированный
let GetState str = 
    match str with 
        | "CLOSED" -> State.CLOSED
        | "LISTEN" -> State.LISTEN
        | "SYN_SENT" -> State.SYN_SENT
        | "SYN_RCVD" -> State.SYN_RCVD
        | "ESTABLISHED" -> State.ESTABLISHED
        | "CLOSE_WAIT" -> State.CLOSE_WAIT
        | "LAST_ACK" -> State.LAST_ACK
        | "FIN_WAIT_1" -> State.FIN_WAIT_1
        | "FIN_WAIT_2" -> State.FIN_WAIT_2
        | "CLOSING" -> State.CLOSING
        | "TIME_WAIT" -> State.TIME_WAIT
        | _ -> State.ERROR

// Преобразование строковых значений событий в типизированный
let eventFromString s =
    match s with
        | "APP_PASSIVE_OPEN" -> APP_PASSIVE_OPEN
        | "APP_ACTIVE_OPEN" -> APP_ACTIVE_OPEN
        | "APP_SEND" -> APP_SEND
        | "APP_CLOSE" -> APP_CLOSE
        | "APP_TIMEOUT" -> APP_TIMEOUT
        | "RCV_SYN" -> RCV_SYN
        | "RCV_ACK" -> RCV_ACK
        | "RCV_SYN_ACK" -> RCV_SYN_ACK
        | "RCV_FIN" -> RCV_FIN
        | "RCV_FIN_ACK" -> RCV_FIN_ACK
        | _ -> UNKNOWN
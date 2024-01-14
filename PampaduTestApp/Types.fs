module Types

// События
type Event =
    | APP_PASSIVE_OPEN
    | APP_ACTIVE_OPEN
    | APP_SEND
    | APP_CLOSE
    | APP_TIMEOUT
    | RCV_SYN
    | RCV_ACK
    | RCV_SYN_ACK
    | RCV_FIN
    | RCV_FIN_ACK
    | UNKNOWN // Добавлен для упрощения работы программы

// Состояния
type State =
    | CLOSED
    | LISTEN
    | SYN_SENT
    | SYN_RCVD
    | ESTABLISHED
    | CLOSE_WAIT
    | LAST_ACK
    | FIN_WAIT_1
    | FIN_WAIT_2
    | CLOSING
    | TIME_WAIT
    | ERROR // Добавлен для упрощения работы программы
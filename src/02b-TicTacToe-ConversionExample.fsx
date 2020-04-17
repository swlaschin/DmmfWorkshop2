module rec TicTacToe

// F# types built from the example at
// 01b-DomainModel-TicTacToe.txt

// it's useful to have an "undefined" type
type undefined = exn


/// Workflow: Start a new game
type StartGame = unit -> GameState * MoveResult
// NOTE: "unit" is like "void" -- means no data

// Workflow: Play a move in an existing game
type PlayMove =
    MoveInformation * GameState // input
      -> MoveResult * GameState // output

// NOTE: the -> arrow needs to be indented to avoid error.

type MoveInformation = {
   Location : Location
   Player : Player
   }

type Player = X | O

type Location = {
    Row : Row
    Column : Column
    }

// wrappers around ints. There are other ways to model these.
type Row = Row of int
type Column = Column of int

type MoveResult =
   | Won of Player
   | Drawn
   | NextTurn of Player
   | MoveError of MoveError

type MoveError =
    | SquareOccupied of Location
    | NotYourTurn of Player

type GameState = undefined
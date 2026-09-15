namespace Feliz.ReactNative

open Fable.Core.JsInterop
open Feliz

type ReactComponent = Feliz.ReactComponentAttribute

type ColorScheme =
    | Light
    | Dark
    | Unspecified

module React =
    [<Hook>]
    let useColorScheme () =
        match (import "useColorScheme" "react-native")() with
        | "light" -> Light
        | "dark" -> Dark
        | _ -> Unspecified

    /// <summary>Return the height, the width, the scale and the fontScale of the window.</summary>
    /// <example>```
    /// let height, width, scale, fontScale = React.useWindowDimensions()
    /// ```</example>
    [<Hook>]
    let useWindowDimensions () : float * float * float * float =
        let dimensions = (import "useWindowDimensions" "react-native")()
        dimensions?height, dimensions?width, dimensions?scale, dimensions?fontScale
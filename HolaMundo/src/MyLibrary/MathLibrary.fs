namespace MyLibrary

module Math =

    let add x y =
        x + y
    
    let imprimeAdd x y =
        let s = add x y
        Say.imprimeFloat s


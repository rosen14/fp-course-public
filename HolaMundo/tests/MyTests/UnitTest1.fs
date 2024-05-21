module MyTests

open NUnit.Framework
open MyLibrary

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()

[<Test>]
let ``Suma 2 mas 2``() =
    let expected = 4
    let actual = Math.add 2 1

    Assert.That(expected, Is.EqualTo(actual))
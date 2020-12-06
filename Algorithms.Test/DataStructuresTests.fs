module DataStructuresTests

open Expecto
open BST

[<Tests>]
let dataStructureTests =
    testList "Data Structures Tests" [
        
        testList "Binary Search Tree Tests" [
            test "Simple BST creation" {
                let actual = BST.fromList [20; 10; 30]
                let expected =
                    Some 
                        { Data = 20
                          Left = Some { Data = 10; Left = None; Right = None }
                          Right = Some { Data = 30; Left = None; Right = None }}
                Expect.equal actual expected "Testing"
            }
        ]
    ]
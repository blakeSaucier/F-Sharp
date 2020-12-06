module BST

type Node =
    { Data: int
      Left: Node option
      Right: Node option }

let rec add data tree =
    match tree with
    | None -> { Data = data; Left = None; Right = None }
    | Some t ->
        if t.Data > data then
            { t with Left = Some (add data t.Left) }
        else
            { t with Right = Some (add data t.Right) }

let fromList lst = lst |> List.fold (fun tree data -> Some (add data tree)) None
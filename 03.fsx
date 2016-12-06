let input = [("KV", "zel"); ("KO", "zel"); ("KV", "mod"); ("KR", "mod"); ("KV", "cer")]

let sortPresents input =
  let key = Map.ofList ["cer", 1; "mod", 2; "zel", 3; "KR", 1; "KV", 2; "KO", 3]
  let sortFunction a b =
    if snd a = snd b
    then key.[fst a] - key.[fst b]
    else key.[snd a] - key.[snd b]
  List.sortWith sortFunction input

sortPresents [("KV", "zel"); ("KO", "zel"); ("KV", "mod"); ("KR", "mod"); ("KV", "cer")]
  |> printfn "%A"
// [("KV", "cer"); ("KR", "mod"); ("KV", "mod"); ("KV", "zel"); ("KO", "zel")]

sortPresents [("KR", "cer"); ("KR", "cer"); ("KV", "zel"); ("KV", "mod"); ("KO", "zel"); ("KR", "mod"); ("KV", "cer"); ("KR", "cer"); ("KV", "mod"); ("KO", "mod"); ("KR", "mod"); ("KR", "zel"); ("KV", "zel"); ("KR", "mod"); ("KR", "zel"); ("KV", "mod"); ("KV", "mod"); ("KV", "zel"); ("KR", "cer"); ("KR", "cer"); ("KR", "zel"); ("KV", "zel"); ("KR", "cer"); ("KV", "mod"); ("KR", "mod"); ("KR", "cer"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KO", "mod"); ("KO", "mod"); ("KR", "mod"); ("KO", "mod"); ("KO", "zel"); ("KO", "zel"); ("KO", "mod"); ("KR", "cer"); ("KR", "zel"); ("KO", "mod"); ("KV", "zel"); ("KV", "mod"); ("KR", "mod"); ("KV", "zel"); ("KO", "mod"); ("KO", "mod"); ("KR", "zel"); ("KO", "zel"); ("KR", "cer"); ("KO", "cer"); ("KO", "cer")]
  |> printfn "%A"
// [("KR", "cer"); ("KR", "cer"); ("KR", "cer"); ("KR", "cer"); ("KR", "cer"); ("KR", "cer"); ("KR", "cer"); ("KR", "cer"); ("KR", "cer"); ("KV", "cer"); ("KO", "cer"); ("KO", "cer"); ("KR", "mod"); ("KR", "mod"); ("KR", "mod"); ("KR", "mod"); ("KR", "mod"); ("KR", "mod"); ("KV", "mod"); ("KV", "mod"); ("KV", "mod"); ("KV", "mod"); ("KV", "mod"); ("KV", "mod"); ("KO", "mod"); ("KO", "mod"); ("KO", "mod"); ("KO", "mod"); ("KO", "mod"); ("KO", "mod"); ("KO", "mod"); ("KO", "mod"); ("KR", "zel"); ("KR", "zel"); ("KR", "zel"); ("KR", "zel"); ("KR", "zel"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KV", "zel"); ("KO", "zel"); ("KO", "zel"); ("KO", "zel"); ("KO", "zel")]

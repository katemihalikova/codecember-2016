// using .reverse()
function isPalindrom(input) {
  input = String(input).replace(/\s/g, "").toLowerCase();
  return input === input.split("").reverse().join("");
}

// without using .reverse()
function isPalindrom(input) {
  input = String(input).replace(/\s/g, "").toLowerCase();

  for (var i = 0, lastIndex = input.length - 1; i < lastIndex / 2; i++) {
    if (input[i] !== input[lastIndex - i]) return false;
  }
  return true;
}

console.log(isPalindrom("Dar hotelu Letohrad") === true);
console.log(isPalindrom("Telecí v separé si žere režisér a pes více let") === true);
console.log(isPalindrom("Ďasa na pusu supa nasaď") === true);
console.log(isPalindrom("Zelený nelez") === true);
console.log(isPalindrom("Zelený nejez") === false);

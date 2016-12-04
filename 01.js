function isTicketValid(input) {
  var inputAsString = String(input);
  var inputAsNumber = Number(input);

  // ignorujeme případné znaménko na začátku
  if (inputAsString[0] === "+" || inputAsString[0] === "-") inputAsString = inputAsString.substr(1);

  // kontrola, že číslo lístku nezačíná nulou
  if (inputAsString[0] === "0") return false;

  // kontrola, že počet číslic v čísle lístku je sudé (dělitelné 2) 
  if (inputAsString.length % 2 !== 0) return false;

  // kontrola, že je číslo lístku dělitelné 3
  if (inputAsNumber % 3 !== 0) return false;

  // kontrola, že je číslo lístku dělitelné 5
  if (inputAsNumber % 5 !== 0) return false;

  // všechny kontroly prošly
  return true;
};

console.log(isTicketValid(555555) === true);
console.log(isTicketValid(55555) === false); // lichý počet číslic
console.log(isTicketValid(333333) === false); // není dělitelné 5
console.log(isTicketValid(100000) === false); // není dělitelné 3
console.log(isTicketValid(+555555) === true);
console.log(isTicketValid(-555555) === true);

console.log(isTicketValid("555555") === true);
console.log(isTicketValid("55555") === false); // lichý počet číslic
console.log(isTicketValid("045450") === false); // začíná nulou
console.log(isTicketValid("333333") === false); // není dělitelné 5
console.log(isTicketValid("100000") === false); // není dělitelné 3
console.log(isTicketValid("+555555") === true);
console.log(isTicketValid("-555555") === true);

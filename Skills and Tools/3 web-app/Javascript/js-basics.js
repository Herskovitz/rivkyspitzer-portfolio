let x = xcrypt("Hello world", 5);
console.log(x);

let y = xcrypt(x, -5);
console.log(y);





function xcrypt(phrase, number) {
    let phrasearray = phrase.split("");
    let shiftedcharsarray = [];

    for (let n of phrasearray) {
        let charcode = n.charCodeAt(0) + number;
        let shiftedchar = String.fromCharCode(charcode);
        shiftedcharsarray.push(shiftedchar);
    }
    return shiftedcharsarray.join("");
}


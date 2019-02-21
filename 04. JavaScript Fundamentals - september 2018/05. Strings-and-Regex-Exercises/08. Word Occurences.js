function solve(string, wordToChech) {
    let word = wordToChech;
    let regex = new RegExp(`\\b${word}\\b`, "gi");

    if (string.match(regex) !== null) {
        console.log(string.match(regex).length);
    } else {
        console.log(0);
    }
}

solve(['How do you plan on achieving that? How? How can you even think of that?', 'how'])
function solve(input) {
    let regex = /\b_([a-zA-Z0-9]+)\b/g;
    let match = input.match(regex);
    let result = [];

    for (let i = 0; i < match.length; i++) {
        result.push(match[i].substring(1));
    }

    console.log(result.join());
}

solve('The _id and _age result are both integers.');
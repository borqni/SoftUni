function solve(string, delimiter) {
    string
        .split(delimiter)
        .forEach(s => console.log(s));
}

solve('One-Two-Three-Four-Five', '-')
function solve() {
    let typeCount = new Map;
    for (let arg of arguments) {
        let type = typeof arg;
        if (!typeCount.has(type)) {
            typeCount.set(type, 0);
        }

        let oldValue = typeCount.get(type);
        typeCount.set(type, oldValue + 1);

        console.log(`${type}: ${arg}`)
    }

    [...typeCount]
    .sort((a, b) => b[1] - a[1])
        .forEach(x => console.log(`${x[0]} = ${x[1]}`))

}

solve('cat', 42, function() {
    console.log('Hello world!');
})
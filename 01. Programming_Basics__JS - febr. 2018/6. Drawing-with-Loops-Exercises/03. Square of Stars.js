function test([arg]) {
    let n = Number(arg);
    for (let i = 0; i < n; i++) {
        console.log('* '.repeat(n));
    }
}
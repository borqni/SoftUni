function test([n]) {
    n = Number(n);
    for (let row = 1; row <= n; row++) {
        console.log('$ '.repeat(row));
    }
}
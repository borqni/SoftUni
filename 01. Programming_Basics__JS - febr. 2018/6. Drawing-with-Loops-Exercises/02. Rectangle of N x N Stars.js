function test([n]) {
    n = Number(n);
    for (let i = 0; i < n; i++) {
        console.log('*'.repeat(n));
    }
}
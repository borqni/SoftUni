function test(n) {
    n = Number(n);
    let num = 1;

    for (let i = 0; i <= n; i++) {
        console.log(num);
        num *= 2;
    }
}
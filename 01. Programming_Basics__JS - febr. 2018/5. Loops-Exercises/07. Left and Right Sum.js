function test(arg) {
    let n = Number(arg[0]);
    let left = 0;
    let right = 0;

    for (let i = 1; i <= n; i++) {
        let num = Number(arg[i]);
        left += num;
    }

    for (let i = n + 1; i <= 2 * n; i++) {
        let num = Number(arg[i]);
        right += num;
    }

    if (left == right) {
        console.log(`Yes, sum = ${left}`);
    } else {
        console.log(`No, diff = ${(Math.abs(left - right))}`);
    }
}
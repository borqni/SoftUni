function test(arg) {
    let n = Number(arg[0]);
    let odd = 0;
    let even = 0;

    for (let i = 1; i <= n; i++) {
        let num = Number(arg[i]);
        if (i % 2 == 1) {
            odd += num
        } else {
            even += num
        }
    }

    if (odd == even) {
        console.log('Yes')
        console.log(`Sum = ${even}`);
    } else {
        console.log('No')
        console.log(`Diff = ${Math.abs(odd-even)}`);
    }
}
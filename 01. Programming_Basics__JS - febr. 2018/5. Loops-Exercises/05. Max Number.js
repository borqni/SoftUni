function sumNumbers(args) {
    let n = Number(args[0]);
    let max = Number.NEGATIVE_INFINITY;

    for (let i = 1; i <= n; i++) {
        let num = Number(args[i]);
        if (num > max) {
            max = num;
        }
    }

    console.log(max)
}
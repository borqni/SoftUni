function test(arg) {
    let n = Number(arg[0]);
    let sum = 0;
    let maxNum = Number.NEGATIVE_INFINITY;

    for (let i = 1; i <= n; i++) {
        let num = Number(arg[i]);
        sum += num;
        if (num > maxNum) {
            maxNum = num
        }
    }

    let otherSum = sum - maxNum;
    if (otherSum == maxNum) {
        console.log('Yes')
        console.log(`Sum = ${maxNum}`);
    } else {
        console.log('No')
        console.log(`Diff = ${Math.abs(otherSum-maxNum)}`);
    }
}
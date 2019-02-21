function test([n]) {
    n = Number(n);
    let width = 5 * n;
    let height = n;
    let glassW = 2 * n;
    let frameIndex = Math.floor((n / 2) - 1);
    if (n % 2 == 0) {
        frameIndex = Math.floor((n / 2) - 1) - 1;
    }

    let frame = ' '.repeat(n);

    console.log('*'.repeat(glassW) + frame + '*'.repeat(glassW));

    for (let row = 0; row < height - 2; row++) {
        if (row == frameIndex) {
            frame = '|'.repeat(n);
        } else {
            frame = ' '.repeat(n);
        }
        console.log(`*${'/'.repeat(glassW-2)}*${frame}*${'/'.repeat(glassW-2)}*`);
    }

    frame = ' '.repeat(n);

    console.log('*'.repeat(glassW) + frame + '*'.repeat(glassW));
}
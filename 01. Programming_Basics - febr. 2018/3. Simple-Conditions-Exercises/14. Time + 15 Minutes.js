function test([arg1, arg2]) {
    h = Number(arg1);
    m = Number(arg2) + 15;

    if (m >= 60) {
        h += 1;
        m -= 60;
    }
    if (h >= 24) {
        h -= 24;
    }
    if (m < 10) {
        console.log(`${h}:0${m}`);
    } else {
        console.log(`${h}:${m}`);
    }
}
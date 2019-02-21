function test([town, s]) {
    s = Number(s);

    if (s <= 0) {
        console.log('error')
    }

    let result = 0;
    if (town == 'Sofia') {
        if (s <= 500) {
            result = 0.05 * s
            console.log(result);
        } else if (s <= 1000) {
            console.log(0.07 * s);
        } else if (s <= 10000) {
            console.log(0.08 * s);
        } else if (s > 10000) {
            console.log(0.12 * s);
        } else {
            console.log('error');
        }
    } else if (town == 'Varna') {
        if (s <= 500) {
            console.log(0.045 * s);
        } else if (s <= 1000) {
            console.log(0.075 * s);
        } else if (s <= 10000) {
            console.log(0.1 * s);
        } else if (s > 10000) {
            console.log(0.13 * s);
        } else {
            console.log('error');
        }
    } else if (town == 'Plovdiv') {
        if (s <= 0) {
            console.log('error')
        } else if (s <= 500) {
            console.log(0.055 * s);
        } else if (s <= 1000) {
            console.log(0.08 * s);
        } else if (s <= 10000) {
            console.log(0.12 * s);
        } else if (s > 10000) {
            console.log(0.145 * s);
        } else {
            console.log('error');
        }
    } else {
        console.log('error')
    }
}
function test([n]) {
    n = Number(n);
    let row = 1;
    let symbol = 1;
    let finish = false;

    while (true) {
        let text = '';

        for (let i = 0; i < row; i++) {
            text += symbol + ' '
            if (symbol == n) {
                finish = true;
                break;
            }
            symbol++;
        }

        console.log(text);

        if (finish) {
            break;
        }

        row++;
    }
}
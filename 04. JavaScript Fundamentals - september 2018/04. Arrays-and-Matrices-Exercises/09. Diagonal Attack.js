function diagonalAttack(matrixRows) {
    let matrix = matrixRows.map(row => row.split(' ').map(n => +n));
    let primarySum = 0;
    let secondarySum = 0;

    for (let r = 0; r < matrix.length; r++) {
        primarySum += matrix[r][r];
        secondarySum += matrix[r][matrix.length - r - 1];
    }

    if (primarySum === secondarySum) {
        for (let row = 0; row < matrix.length; row++) {
            for (let colum = 0; colum < matrix.length; colum++) {
                if (colum !== row &&
                    colum !== matrix.length - row - 1) {
                    matrix[row][colum] = primarySum;
                }
            }
        }
    }

    console.log(matrix.map(row => row.join(' ')).join('\n'));
}
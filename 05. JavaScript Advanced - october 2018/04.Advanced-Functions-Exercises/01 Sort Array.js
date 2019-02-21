function sortArr(input, method) {
    if (method === 'asc') {
        return (input.sort((a, b) => {
            return a - b;
        }));
    } else {
        return (input.sort((a, b) => {
            return b - a;
        }));
    }
}

console.log(sortArr([14, 7, 17, 6, 8], 'asc'));
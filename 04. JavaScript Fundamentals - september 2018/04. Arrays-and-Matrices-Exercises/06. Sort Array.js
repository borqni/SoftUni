function sortArray(input) {
    let x = input
        .sort()
        .sort((a, b) => a.length > b.length);

    console.log(x.join('\n'));


    // вар 2
    // console.log(input.sort((a, b)=>a.length - b.length || a.localeCompare(b)).join('\n'));

}
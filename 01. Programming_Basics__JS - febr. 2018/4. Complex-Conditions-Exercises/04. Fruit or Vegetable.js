function food([arg]) {
    if (arg == 'banana' || arg == 'apple' || arg == 'kiwi' ||
        arg == 'cherry' || arg == 'lemon' || arg == 'grapes') {
        console.log('fruit');
    } else if (arg == 'tomato' || arg == 'cucumber' || arg == 'pepper' || arg == 'carrot') {
        console.log('vegetable');
    } else {
        console.log('unknown')
    }
}